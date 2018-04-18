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
                fileRegex = new Regex(@"<a href=""https:\/\/(.{1,111}?\.(?:gif?|webm?|jpeg?|png?|mp4?|jpg))"" target=""_blank"">");
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
            // Round 2
            if (url.Contains("8ch"))
            {
                fileRegex = new Regex(@"<a(?: title="".{1,120}(?:webm?|mp4?|jpg?|gif?|png?|jpeg)""|) href=""https:\/\/(.{1,120}\.(?:mp4?|webm?|jpg?|gif?|png?|jpeg))"">");
                foreach (Match match in fileRegex.Matches(fetchedText))
                {
                    if (!ret.Contains(match.Groups[1].Value))
                    {
                        ret.Add(match.Groups[1].Value);
                    }
                }
            }
            return ret;
        }
        // Get Count of Items
        public int GetItemCount()
        {
            Regex fileRegex;
            int count;
            if (url.Contains("8ch"))
            {
                fileRegex = new Regex(@"<a href=""https:\/\/(.{1,111}?\.(?:gif?|webm?|jpeg?|png?|mp4?|jpg))"" target=""_blank"">");
                count = fileRegex.Matches(fetchedText).Count;
                fileRegex = new Regex(@"<a(?: title="".{1,120}(?:webm?|mp4?|jpg?|gif?|png?|jpeg)""|) href=""https:\/\/(.{1,120}\.(?:mp4?|webm?|jpg?|gif?|png?|jpeg))"">");
                count += fileRegex.Matches(fetchedText).Count;
            }
            else
            {
                fileRegex = new Regex(@"(?:a title=.*? href|a href)=\""\/\/(.{1,50}?\.(?:gif?|webm?|jpg?|png))");
                count = fileRegex.Matches(fetchedText).Count;
            }            
            return count;
        }
        // Get List of All Thumbnail URLs
        public List<string> GetThumbList()
        {
            List<string> ret = new List<string>();
            Regex fileRegex;

            if (url.Contains("8ch"))
            {
                fileRegex = new Regex(@"<img class=""post-image"" src=""(https:\/\/.*?/thumb\/.{1,120}\.(?:jpeg?|gif?|jpg?|png?|mp4?|webm))");
            }
            else
            {
                fileRegex = new Regex(@"<img src=""\/\/(.{1,50}\.jpg)");
            }
            foreach (Match match in fileRegex.Matches(fetchedText))
            {
                ret.Add(match.Groups[1].Value);
            }
            // Round 2
            if (url.Contains("8ch"))
            {
                fileRegex = new Regex(@"<img class=""post-image"" src=""(\/file_store\/thumb\/.{1,111}?\.(?:gif?|webm?|jpeg?|png?|mp4?|jpg))""");
                foreach (Match match in fileRegex.Matches(fetchedText))
                {
                    if (!ret.Contains(match.Groups[1].Value))
                    {
                        ret.Add(match.Groups[1].Value);
                    }
                }
            }
            return ret;
        }
        // Get Thread Name and Return Random in case of BLANK
        public string GetThreadname()
        {
            string ret = "";
            Regex nameRegex;
            if (url.Contains("8ch"))
            {
                nameRegex = new Regex(@"<span class=""subject"">(.*?)<\/span>");
                ret = nameRegex.Match(fetchedText).Groups[1].Value;
                if (ret.Contains("p class") || ret == "")
                {
                    nameRegex = new Regex(@"<span class=""heading"">(.*?)<\/span>");
                }
            }
            else
            {
                nameRegex = new Regex(@"<span class=""subject"">(.*?)<\/span>"); 
            }
            ret = nameRegex.Match(fetchedText).Groups[1].Value;
            if (ret == "")
            {
                if (url.Contains("8ch"))
                {
                    nameRegex = new Regex(@"<div class=""body"">(.*?)<\/div>");
                    ret = nameRegex.Match(fetchedText).Groups[1].Value;
                    if (ret.Contains("body-line ltr"))
                    {
                        nameRegex = new Regex(@"<p class=""body-line ltr "">(.*?)<\/p>");
                        ret = nameRegex.Match(ret).Groups[1].Value;
                    }
                }
                else
                {
                    nameRegex = new Regex(@"<blockquote class=""postMessage"" id="".*?"">(.*?)<\/blockquote>");
                }
                ret = nameRegex.Match(fetchedText).Groups[1].Value;
                if (ret.Length > 30)
                {
                    ret = ret.Substring(0, 30);
                }
            }
            if (ret == "")
            {
                ret = new Random().Next(1, 9999).ToString("0000");
            }
            return ret;
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
        public bool DownloadThumb(string url,string path)
        {
            try
            {
                client.DownloadFile("http://" + url, path);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string GetURL()
        {
            return url;
        }
    }
}
