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

        private List<string> itemURLs, thumbnailURLs, threadURLs;
        private List<WebClient> asyncDownloads;
        int countCompleteDownload, countPrevDownload, countFailedDownload, countCancelledDownload, mode;
        bool readyNextThread, controlLock;
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
            controlLock = false;
            mode = 0;
        }
        // Inintiate New Thread Grab
        private void buttonGrab_Click(object sender, EventArgs e)
        {
            if (textOutputPath.Text == "")
            {
                MessageBox.Show("Please select output path before continuing.");
                return;
            }
            if (textNewURL.Text == "")
            {
                return;
            }
            if (mode == 0)
            {
                Load_Thread_Preview();
            }
            else if (mode == 1)
            {
                ToggleControlLock();
                Load_Thread(textNewURL.Text);
                Download_Loaded_Thread();
            }
            else if (mode == 2)
            {
                if (!threadURLs.Contains(textNewURL.Text))
                {
                    listBoxThreads.Items.Add(textNewURL.Text);
                    threadURLs.Add(textNewURL.Text);
                    textNewURL.Text = "";
                }
            }
        }
        // Clear Old Info
        private void ClearUI()
        {
            if (checkBoxFiles.Items.Count > 0)
            {
                checkBoxFiles.Items.Clear();
            }
            if (listBoxThreads.Items.Count > 0)
            {
                listBoxThreads.Items.Clear();
            }
            textThreadTitle.Text = "";
            previewBox.Image = null;
            SetCheckedLabel(0);
            SetFoundLabel(0);
        }
        // Single with Preview Action
        private void Load_Thread_Preview()
        {
            ClearUI();
            thread = new ThreadObj(textNewURL.Text);
            if (!thread.PageFound())
            {
                MessageBox.Show("Failed to fetch thread!");
                return;
            }
            textThreadTitle.Text = thread.GetThreadname();
            itemURLs = thread.GetItemList();
            foreach (string pic in itemURLs)
            {
                checkBoxFiles.Items.Add(pic, true);
            }
            thumbnailURLs = thread.GetThumbList();
            FileUtilities.ThumbFolderSetup(thumbnailPath);
            SetFoundLabel(itemURLs.Count);
            SetCheckedLabel(itemURLs.Count);
            if (checkBoxFiles.Items.Count > 0)
            {
                checkBoxFiles.SelectedIndex = 0;
            }
        }
        private bool Load_Thread(string url)
        {
            thread = new ThreadObj(url);
            if (!thread.PageFound())
            {
                return false;
            }
            if (mode == 0)
            {
                textThreadTitle.Text = thread.GetThreadname();
            }
            itemURLs = thread.GetItemList();
            return true;
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
            if (textOutputPath.Text == "")
            {
                MessageBox.Show("Please select output path before continuing.");
                return;
            }
            if (mode == 0)
            {
                if (thread != null)
                {
                    ToggleControlLock();
                    Download_Loaded_Thread();
                }
            }
            else if (mode == 2)
            {
                ToggleControlLock();
                progressThreads.Maximum = threadURLs.Count;
                progressThreads.Value = 0;
                Thread downloadWorker = new Thread(() => DownloadMultipleThreads());
                downloadWorker.Start();
            }
        }
        private void Download_Loaded_Thread()
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
            if (radioM.Checked)
            {
                Invoke(new Action(() => progressBarDownload.Maximum = itemURLs.Count));
                Invoke(new Action(() => progressBarDownload.Value = 0)); 
                asyncDownloads = new List<WebClient>();
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
                            Invoke(new Action(() => progressBarDownload.PerformStep())); 
                        }
                    }
                    else
                    {
                        countPrevDownload++;
                        Invoke(new Action(() => progressBarDownload.PerformStep())); 
                    }
                    asyncDownloads.Add(downloader);
                }
                CheckAndDisplayDownloadComplete();
            }
            else if (radioDownSeq.Checked)
            {
                progressBarDownload.Maximum = itemURLs.Count;
                progressBarDownload.Value = 0;
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
                progressBarDownload.Maximum = itemURLs.Count;
                progressBarDownload.Value = 0;
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
            Invoke(new Action(() => progressBarDownload.PerformStep())); 
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
            if (mode == 2)
            {
                Thread displayThread = new Thread(() => MessageBox.Show(resultMessage));
                displayThread.Start();
            }
            else
            {
                MessageBox.Show(resultMessage);
            }
        }
        // Check if all async downloads are completed/failed.
        private void CheckAndDisplayDownloadComplete()
        {
            int countTotalComplete = countCompleteDownload + countFailedDownload + countPrevDownload + countCancelledDownload;
            if (countTotalComplete == itemURLs.Count)
            {
                if (mode != 2)
                {
                    progressBarDownload.Value = progressBarDownload.Maximum;
                    if (mode == 0)
                    {
                        buttonDownload.Visible = true;
                    }
                    ToggleControlLock();
                }
                else
                {
                    readyNextThread = true;
                }
                DisplayResults();
            }
        }
        // Download Thread THREADED
        private void DownloadMultipleThreads()
        {
            foreach (string currentThread in threadURLs)
            {
                readyNextThread = false;
                Load_Thread(currentThread);
                Download_Loaded_Thread();
                while (!readyNextThread)
                {
                    Thread.Sleep(1000);
                }
                Invoke(new Action(() => progressThreads.PerformStep()));
            }
            MessageBox.Show("Completed " + threadURLs.Count + " threads.");
            Invoke(new Action(() => ToggleControlLock()));
        }
        // Create the Output Path from Options
        private string GenerateOutputPath()
        {
            string folder = textOutputPath.Text;
            if (radioFullPath.Checked)
            {
                folder += "\\" + thread.GetBoard() + "\\" + thread.GetThreadname();
            }
            else if (radioNoBoard.Checked)
            {
                folder += "\\" + thread.GetThreadname();
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

        private void Download_Mode_Switch(object sender, EventArgs e)
        {
            ClearUI();
            if (radioSP.Checked)
            {
                buttonGrab.Text = "Load";
                groupPreview.Visible = true;
                buttonDownload.Visible = true;
                buttonCancel.Visible = true;
                listBoxThreads.Visible = false;
                progressThreads.Visible = false;
                radioDownSeq.Enabled = true;
                mode = 0;
            }
            else if (radioS.Checked)
            {
                buttonGrab.Text = "Download";
                groupPreview.Visible = false;
                buttonDownload.Visible = false;
                buttonCancel.Visible = false;
                listBoxThreads.Visible = false;
                progressThreads.Visible = false;
                radioDownSeq.Enabled = true;
                mode = 1;
            }
            else if (radioM.Checked)
            {
                threadURLs = new List<string>();
                buttonGrab.Text = "Add";
                groupPreview.Visible = false;
                buttonDownload.Visible = true;
                buttonCancel.Visible = true;
                listBoxThreads.Visible = true;
                progressThreads.Visible = true;
                radioDownSeq.Enabled = false;
                radioDownPar.Checked = true;
                mode = 2;
            }
        }
        // Toggle Control Lock
        private void ToggleControlLock()
        {
            controlLock = !controlLock;
            if (!controlLock)
            {
                groupDownload.Enabled = true;
                groupPreview.Enabled = true;
                groupMode.Enabled = true;
                buttonGrab.Enabled = true;
                textNewURL.Enabled = true;
                buttonDownload.Enabled = true;
                textThreadTitle.Enabled = true;
            }
            else
            {
                groupDownload.Enabled = false;
                groupPreview.Enabled = false;
                groupMode.Enabled = false;
                buttonGrab.Enabled = false;
                textNewURL.Enabled = false;
                buttonDownload.Enabled = false;
                textThreadTitle.Enabled = false;
            }
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
