using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using System.Windows.Forms;


namespace SoloThreadGrab
{
    public partial class Main : Form
    {

        private List<string> itemsToGrab, thumbnailURLs;
        ThreadObj thread;
        private string thumbnailPath = "thumbnails";


        public Main()
        {
            InitializeComponent();
        }

        // Inintiate New Thread Download
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
            string threadTitle = thread.GetThreadname();
            itemsToGrab = thread.GetItemList();
            foreach (string pic in itemsToGrab)
            {
                checkBoxFiles.Items.Add(pic, true);
            }
            thumbnailURLs = thread.GetThumbList();
            FileUtilities.ThumbFolderSetup(thumbnailPath);
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
