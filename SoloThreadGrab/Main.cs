using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
namespace SoloThreadGrab
{
    public partial class Main : Form
    {
        private List<string> itemsToGrab, thumbs;
        private string thumbnailPath = "thumbnails";
        public Main()
        {
            InitializeComponent();
        }
        // WebClient Initializer
        private WebClient generateClient()
        {
            WebClient client = new WebClient();
            client.UseDefaultCredentials = true;
            client.Headers.Add("User-Agent: Other");
            return client;
        }
        // Setup Thumbs/Clear Old Thumbs
        private void thumbFolderSetup()
        {
            if (!Directory.Exists(thumbnailPath))
            {
                Directory.CreateDirectory(thumbnailPath);
            }
            else
            {
                if (previewBox.Image != null)
                {
                    previewBox.Image.Dispose();
                }
                foreach (string file in Directory.GetFiles(thumbnailPath))
                {
                    File.Delete(file);
                }
            }
        }
        // Inintiate New Thread Download
        private void buttonGrab_Click(object sender, EventArgs e)
        {
            if (checkBoxFiles.Items.Count > 0)
            {
                checkBoxFiles.Items.Clear();
            }
            WebClient client = generateClient();
            string downloadString = client.DownloadString(textNewURL.Text);
            findThreadName(downloadString);
            itemsToGrab = findItems(downloadString);
            foreach (string pic in itemsToGrab)
            {
                checkBoxFiles.Items.Add(pic, true);
            }
            thumbs = findThumbs(downloadString);
            thumbFolderSetup();
            MessageBox.Show(itemsToGrab.Count + " " + thumbs.Count);
        }
        // Load Selected Item to Preview Box

        // Get Thread Name For Folder
        private string findThreadName(string fetchedText)
        {
            string ret;
            string titleMarker = "<meta name=\"description\" content=\"";
            string endMarker = " - &quot;/";
            int titlePos = fetchedText.IndexOf(titleMarker) + titleMarker.Length;
            int titlePosEnd = fetchedText.IndexOf(endMarker);
            ret = fetchedText.Substring(titlePos, titlePosEnd - titlePos);
            return ret;
        }
        // Get List of All Item URLs
        private List<string> findItems(string fetchedText)
        {
            List<string> ret = new List<string>();
            Regex fileRegex = new Regex(@"(?:a title=.*? href|a href)=\""\/\/(.{1,50}?\.(?:gif?|webm?|jpg?|png))");
            foreach (Match match in fileRegex.Matches(fetchedText))
            {
                ret.Add(match.Groups[1].Value);
            }
            return ret;
        }
        // Get List of All Thumbnail URLs
        private List<string> findThumbs(string fetchedText)
        {
            List<string> ret = new List<string>();
            Regex fileRegex = new Regex(@"<img src=""\/\/(.{1,50}\.jpg)");
            foreach (Match match in fileRegex.Matches(fetchedText))
            {
                ret.Add(match.Groups[1].Value);
            }
            return ret;
        }
        // Switch Image Preview Event
        private void checkBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkBoxFiles.SelectedIndex;
            string thumbFilename = thumbnailPath + "\\" + index + ".jpg";
            if (!File.Exists(thumbFilename))
            {
                WebClient client = generateClient();
                client.DownloadFile("http://" + thumbs[index], thumbFilename);
            }
            loadImage(thumbFilename);
        }
        // Load Image from URL to Preview
        private void loadImage(string path)
        {
            Image img;
            using (var temp = new Bitmap(path))
            {
                img = new Bitmap(temp);
            }
            previewBox.Image = img;
        }

    }
}
