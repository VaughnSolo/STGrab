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
        string url;
        string fetchedText;
        // WebClient Initializer
        public ThreadObj(string address)
        {
            client = new WebClient
            {
                UseDefaultCredentials = true
            };
            client.Headers.Add("User-Agent: Other");
            url = address;
            if (!(url.Contains("http://") || url.Contains("https://")))
            {
                url = "http://" + url;
            }
            try
            {
                fetchedText = client.DownloadString(url);
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
            Regex fileRegex;
            if (url.Contains("8ch"))
            {
                fileRegex = new Regex(@"(?:a title=.*? href)=\""https:\/\/(.{1,111}?\.(?:gif?|webm?|jpeg?|png?|mp4?|jpg))");
            }
            else
            {
                fileRegex = new Regex(@"(?:a title=.*? href|a href)=\""\/\/(.{1,50}?\.(?:gif?|webm?|jpg?|png))");
            }
            foreach (Match match in fileRegex.Matches(fetchedText))
            {
                if (!ret.Contains(match.Groups[1].Value))
                {
                    ret.Add(match.Groups[1].Value);
                }
            }
            return ret;
        }
        // Get List of All Thumbnail URLs
        public List<string> GetThumbList()
        {
            List<string> ret = new List<string>();
            Regex fileRegex;

            if (url.Contains("8ch"))
            {
                fileRegex = new Regex(@"<img class=""post-image"" src=""https:\/\/(.{1,100}\.(?:jpg?|png))");
            }
            else
            {
                fileRegex = new Regex(@"<img  src=""\/\/(.{1,50}\.jpg)");
            }
            foreach (Match match in fileRegex.Matches(fetchedText))
            {
                ret.Add(match.Groups[1].Value);
            }
            return ret;
        }
        // Get Thread Name
        public string GetThreadname()
        {
            string ret;
            if (url.Contains("8ch"))
            {
                Regex nameRegex = new Regex(@"<span class=""subject"">(.*?)<\/span>");
                ret = nameRegex.Match(fetchedText).Groups[1].Value;
                return ret;
            }
            else
            {
                string titleMarker = "<meta name=\"description\" content=\"";
                string endMarker = " - &quot;/";
                int titlePos = fetchedText.IndexOf(titleMarker) + titleMarker.Length;
                int titlePosEnd = fetchedText.IndexOf(endMarker);
                if (titlePosEnd < 0)
                {
                    return "";
                }
                ret = fetchedText.Substring(titlePos, titlePosEnd - titlePos);
                return ret;
            }
        }
        // Get Board Name
        public string GetBoard()
        {
            string ret;
            Regex boardRegex;
            if (url.Contains("8ch"))
            {
                boardRegex = new Regex(@".net\/(.*?)\/");
            }
            else
            {
                boardRegex = new Regex(@"\.org\/(.*?)\/.*");
            }
            ret = boardRegex.Match(url).Groups[1].Value;
            return ret;
        }
        // Get Filename from URL
        public string FilenameFromURL(string url)
        {
            string ret;
            Regex nameRegex = new Regex(@".*\/(.*?\.(?:webm?|gif?|png?|jpeg?|jpg?|jpeg?|mp4))");
            ret = nameRegex.Match(url).Groups[1].Value;
            return ret;
        }
        // Get Single Thumbnail
        public void DownloadThumb(string url,string path)
        {
            client.DownloadFile("http://" + url, path);
        }
    }
}
