using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
namespace SoloThreadGrab
{
    class FileUtilities
    {
        // Setup Thumbs/Clear Old Thumbs
        public static void ThumbFolderSetup(string thumbnailPath)
        {
            if (!Directory.Exists(thumbnailPath))
            {
                Directory.CreateDirectory(thumbnailPath);
            }
            else
            {
                foreach (string file in Directory.GetFiles(thumbnailPath))
                {
                    File.Delete(file);
                }
            }
        }
        // Check if File Exists
        public static bool IsSaved(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            return false;
        }

        // Load Image from URL to Preview
        public static Image LoadImage(string path)
        {
            Image img;
            using (var temp = new Bitmap(path))
            {
                img = new Bitmap(temp);
            }
            return img;
        }
    }
}
