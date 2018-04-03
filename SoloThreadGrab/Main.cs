using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Windows.Forms;


namespace SoloThreadGrab
{
    public partial class Main : Form
    {

        private List<string> itemURLs, thumbnailURLs;
        ThreadObj thread;
        private string thumbnailPath = "thumbnails";
        WebClient downloader;

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
            string path = GenerateOutputPath();
            if (!SetupOutputFolder(path))
            {
                return;
            }
            buttonDownload.Enabled = false;
            progressBarDownload.Maximum = itemURLs.Count;
            progressBarDownload.Value = 0;
            downloader = new WebClient();
            //downloader.DownloadFileCompleted += DownloadFileCompleted;
            foreach (string file in itemURLs)
            {
                string fileName = thread.FilenameFromURL(file);
                string fullPath = path + "\\" + fileName;
                if (!FileUtilities.IsSaved(fullPath))
                {
                    downloader.DownloadFile(new Uri("http://" + file), fullPath);
                }
                else
                {
                    progressBarDownload.PerformStep();
                    if (progressBarDownload.Value == progressBarDownload.Maximum)
                    {
                        buttonDownload.Enabled = true;
                    }
                }
            }
        }
        /*
        // Completed File Event
        private void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            progressBarDownload.PerformStep();
            if (progressBarDownload.Value == progressBarDownload.Maximum)
            {
                buttonDownload.Enabled = true;
            }
        }
        */
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
