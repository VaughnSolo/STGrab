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

namespace SoloThreadGrab
{
    public partial class Main : Form
    {
        private List<string> itemsToGrab;
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
        }
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
            int fileCount = 0;
            List<string> ret = new List<string>();
            string test = "";
            Regex fileRegex = new Regex("(?:a title=.*? href|a href)=\"\\/\\/(.{1,50}?\\.(?:gif?|webm))");
            foreach (Match match in fileRegex.Matches(fetchedText))
            {
                fileCount++;
                ret.Add(match.Groups[1].Value);
                test += match.Groups[1].Value + "\r\n";
            }
            MessageBox.Show(test);
            MessageBox.Show(fileCount.ToString());
            return ret;
        }
    }
}
