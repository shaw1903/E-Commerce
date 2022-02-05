using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;
using E_Commerce.Controllers;

namespace E_Commerce.Data.Services
{
    public class FileProperties
    {
        public void FileReader(int ItemNumber, string ItemName, string ImageURL)
        {
            ItemNumber = 0000;
            string MasterPath = "/Users/Seoras/Pictures/Shows/Show1";
            foreach(string AllFiles in Directory.EnumerateFiles(MasterPath))
            {
                ItemNumber++;
                ItemName = Path.GetFileName(AllFiles);
                ImageURL = Path.GetFullPath(AllFiles);
                Console.WriteLine("Item Number = {0}, ItemName = {1}, ImageURL = {2}", ItemNumber, ItemName, ImageURL);
            }
        }

    }
}

