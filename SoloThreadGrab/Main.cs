﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace SoloThreadGrab
{
    public partial class Main : Form
    {

        private List<string> itemURLs, thumbnailURLs;
        private List<WebClient> asyncDownloads;
        int countCompleteDownload, countPrevDownload, countFailedDownload, countCancelledDownload;
        ThreadObj thread;
        private string thumbnailPath = "thumbnails";

        public Main()
        {
            InitializeComponent();
        }
        // Load Default Values
        private void Main_Load(object sender, EventArgs e)
        {
            textOutputPath.Text = Properties.Settings.Default.OutputPath;
        }
        // Inintiate New Thread Grab
        private void buttonGrab_Click(object sender, EventArgs e)
        {
            if (checkBoxFiles.Items.Count > 0)
            {
                checkBoxFiles.Items.Clear();
            }
            thread = new ThreadObj(textNewURL.Text);
            if (!thread.PageFound())
            {
                MessageBox.Show("Failed to fetch thread!");
                return;
            }
            textThreadTitle.Text = thread.GetThreadname();
            textThreadFolder.Text = textThreadTitle.Text;
            itemURLs = thread.GetItemList();
            foreach (string pic in itemURLs)
            {
                checkBoxFiles.Items.Add(pic, true);
            }
            thumbnailURLs = thread.GetThumbList();
            MessageBox.Show(thumbnailURLs.Count + "");
            FileUtilities.ThumbFolderSetup(thumbnailPath);
            SetFoundLabel(itemURLs.Count);
            SetCheckedLabel(itemURLs.Count);
            groupPreview.Enabled = true;
            groupDownload.Enabled = true;
            if (textOutputPath.Text != "")
            {
                buttonDownload.Enabled = true;
            }
            if (checkBoxFiles.Items.Count > 0)
            {
                checkBoxFiles.SelectedIndex = 0;
            }
        }
        // Update Found
        private void SetFoundLabel(int count)
        {
            labelFileCount.Text = "Found: " + count;
        }
        // Update Checked Label
        private void SetCheckedLabel(int count)
        {
            labelCheckedCount.Text = "Checked: " + count;
        }
        // Update Checked Total
        private void checkBoxFiles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkBoxFiles.CheckedIndices.Contains(checkBoxFiles.SelectedIndex))
            {
                SetCheckedLabel(checkBoxFiles.CheckedItems.Count - 1);
            }
            else
            {
                SetCheckedLabel(checkBoxFiles.CheckedItems.Count + 1);
            }
        }
        // Download Checked Files to Selected Path
        private void buttonDownload_Click(object sender, EventArgs e)
        {
            countPrevDownload = 0;
            countFailedDownload = 0;
            countCompleteDownload = 0;
            countCancelledDownload = 0;
            string path = GenerateOutputPath();
            if (!SetupOutputFolder(path))
            {
                return;
            }
            progressBarDownload.Maximum = itemURLs.Count;
            progressBarDownload.Value = 0;
            if (radioDownSeq.Checked)
            {
                buttonDownload.Enabled = false;
                WebClient downloader = new WebClient();
                foreach (string file in itemURLs)
                {
                    string fileName = thread.FilenameFromURL(file);
                    string fullPath = path + "\\" + fileName;
                    Uri fullURI = new Uri("http://" + file);
                    if (!FileUtilities.IsSaved(fullPath))
                    {
                        try
                        {
                            downloader.DownloadFile(fullURI, fullPath);
                            countCompleteDownload++;
                        }
                        catch
                        {
                            countFailedDownload++;
                        }
                    }
                    else
                    {
                        countPrevDownload++;
                    }
                    progressBarDownload.PerformStep();
                }
                CheckAndDisplayDownloadComplete();
            }
            else if (radioDownPar.Checked)
            {
                asyncDownloads = new List<WebClient>();
                buttonDownload.Visible = false;
                foreach (string file in itemURLs)
                {
                    WebClient downloader = new WebClient();
                    string fileName = thread.FilenameFromURL(file);
                    string fullPath = path + "\\" + fileName;
                    Uri fullURI = new Uri("http://" + file);
                    if (!FileUtilities.IsSaved(fullPath))
                    {
                        try
                        {
                            downloader.DownloadFileAsync(fullURI, fullPath);
                            downloader.DownloadFileCompleted += AsyncDownloadCompleted;
                        }
                        catch
                        {
                            countFailedDownload++;
                            progressBarDownload.PerformStep();
                        }
                    }
                    else
                    {
                        countPrevDownload++;
                        progressBarDownload.PerformStep();
                    }
                    asyncDownloads.Add(downloader);
                }
                CheckAndDisplayDownloadComplete();
            }
        }
        // Handler for completed download event, increment tracker and check if complete.
        private void AsyncDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            progressBarDownload.PerformStep();
            if (!e.Cancelled)
            {
                Interlocked.Increment(ref countCompleteDownload);
            }
            else
            {
                Interlocked.Increment(ref countCancelledDownload);
            }
            CheckAndDisplayDownloadComplete();
        }
        // Display result message to user.
        private void DisplayResults()
        {
            string resultMessage = countCompleteDownload + "/" + itemURLs.Count + " downloaded successfully.";
            if (countPrevDownload > 0)
            {
                resultMessage += " [" + countPrevDownload + " already existed]";
            }
            if (countFailedDownload > 0)
            {
                resultMessage += " [" + countFailedDownload + " failed to download]";
            }
            if (countCancelledDownload > 0)
            {
                resultMessage += " [" + countCancelledDownload + " cancelled]";
            }
            MessageBox.Show(resultMessage);
        }
        // Check if all async downloads are completed/failed.
        private void CheckAndDisplayDownloadComplete()
        {
            int countTotalComplete = countCompleteDownload + countFailedDownload + countPrevDownload + countCancelledDownload;
            if (countTotalComplete == itemURLs.Count)
            {
                buttonDownload.Enabled = true;
                buttonDownload.Visible = true;
                progressBarDownload.Value = progressBarDownload.Maximum;
                DisplayResults();
            }
        }
        // Create the Output Path from Options
        private string GenerateOutputPath()
        {
            string folder = textOutputPath.Text;
            if (radioFullPath.Checked)
            {
                folder += "\\" + thread.GetBoard() + "\\" + textThreadFolder.Text;
            }
            else if (radioNoBoard.Checked)
            {
                folder += "\\" + textThreadFolder.Text;
            }
            folder = folder.Replace('/', '#');
            return folder;
        }
        // Create Output Folder or Alert User of Issues
        private bool SetupOutputFolder(string path)
        {
            string result = FileUtilities.DownloadFolderSetup(path);
            if (result != "")
            {
                if (result.ToLower().Contains("exists") && checkBoxCombine.Enabled && !checkBoxCombine.Checked)
                {
                    MessageBox.Show("Folder already exists! Change name or select combine.");
                    return false;
                }
                else if (result.ToLower().Contains("invalid"))
                {
                    MessageBox.Show("Invalid folder name or path.");
                    return false;
                }
            }
            return true;
        }
        // Locate Output Location
        private void buttonOutputSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult res = fbd.ShowDialog();
            textOutputPath.Text = fbd.SelectedPath;
            buttonDownload.Enabled = true;
            SaveOutputSetting();
        }

        // Save Most Recent Output Path
        private void SaveOutputSetting()
        {
            Properties.Settings.Default.OutputPath = textOutputPath.Text;
            Properties.Settings.Default.Save();
        }
        // Check if Folder Structure Requires Checkbox
        private void FolderStruct_Changed(object sender, EventArgs e)
        {
            if (((RadioButton)sender) != radioNoFolders)
            {
                checkBoxCombine.Enabled = true;
            }
            else
            {
                checkBoxCombine.Enabled = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            foreach (WebClient client in asyncDownloads)
            {
                client.CancelAsync();
            }
        }

        // Switch Image Preview Event
        private void checkBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkBoxFiles.SelectedIndex;
            string thumbFilename = thumbnailPath + "\\" + index + ".jpg";
            if (!FileUtilities.IsSaved(thumbFilename))
            {
                thread.DownloadThumb(thumbnailURLs[index], thumbFilename);
            }
            previewBox.Image = FileUtilities.LoadImage(thumbFilename);
        }
    }
}
