using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
namespace SoloThreadGrab
{
    class ThreadObj
    {
        WebClient client;
        string fetchedText;
        // WebClient Initializer
        public ThreadObj(string address)
        {
            client = new WebClient
            {
                UseDefaultCredentials = true
            };
            client.Headers.Add("User-Agent: Other");
            try
            {
                fetchedText = client.DownloadString(address);
            }
            catch
            {
                fetchedText = "";
            }
        }
        // Check if Object was Created Successfully
        public bool PageFound()
        {
            if (fetchedText != "")
            {
                return true;
            }
            return false;
        }

        // Get List of All Item URLs
        public List<string> GetItemList()
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
        public List<string> GetThumbList()
        {
            List<string> ret = new List<string>();
            Regex fileRegex = new Regex(@"<img src=""\/\/(.{1,50}\.jpg)");
            foreach (Match match in fileRegex.Matches(fetchedText))
            {
                ret.Add(match.Groups[1].Value);
            }
            return ret;
        }
        // Get Thread Name For Folder
        public string GetThreadname()
        {
            string ret;
            string titleMarker = "<meta name=\"description\" content=\"";
            string endMarker = " - &quot;/";
            int titlePos = fetchedText.IndexOf(titleMarker) + titleMarker.Length;
            int titlePosEnd = fetchedText.IndexOf(endMarker);
            ret = fetchedText.Substring(titlePos, titlePosEnd - titlePos);
            return ret;
        }
        // Get Single Thumbnail
        public void DownloadThumb(string url,string path)
        {
            client.DownloadFile("http://" + url, path);
        }
    }
}
