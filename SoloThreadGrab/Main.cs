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
namespace SoloThreadGrab
{
    public partial class Main : Form
    {
        private List<string> itemsToGrab, thumbs;
        public Main()
        {
            InitializeComponent();
        }
        // Inintiate New Thread Download
        private void buttonGrab_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.UseDefaultCredentials = true;
            client.Headers.Add("User-Agent: Other");
            string downloadString = client.DownloadString(textNewURL.Text);
            findThreadName(downloadString);
            itemsToGrab = findItems(downloadString);
            thumbs = findThumbs(downloadString);
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
            Regex fileRegex = new Regex(@"(?:a title=.*? href|a href)=\""\/\/(.{1,50}?\.(?:gif?|webm))");
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
    }
}
