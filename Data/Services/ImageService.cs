using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;

namespace E_Commerce.Data
{
    public class ImageService : IImageService
    {
        private readonly JumaContext db;

        public ImageService(JumaContext injectedContext)
        {
            db = injectedContext;
        }

        public void FileReader(int ItemNumber, string ItemName, string ImageURL, DateTime DateTaken)
        {
            ItemNumber = 000;
            string MasterPath = "/Users/Seoras/Pictures/Shows/Show1";
            foreach(string AllFiles in Directory.EnumerateFiles(MasterPath))
            {
                ItemNumber++;
                ItemName = Path.GetFileName(AllFiles);
                ImageURL = Path.GetFullPath(AllFiles);
                DateTaken = File.GetCreationTime(AllFiles);
                Console.WriteLine("Item Number = {0}, ItemName = {1}, ImageURL = {2}, Date Taken = {3}", ItemNumber, ItemName, ImageURL, DateTaken);
            }           
        }
        public void Add(Images Images)
        {
            db.Images.Add(Images);
            db.SaveChanges();
        }

        public void Delete(int ItemNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Images> GetAll()
        {
            var result = db.Images.ToList();
            return result;
        }

        public Images GetImages(int ItemNumber)
        {
            throw new NotImplementedException();
        }

        public Images Update(int ItemNumber, Images Images)
        {
            throw new NotImplementedException();
        }
    }
}