using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;

namespace E_Commerce.Data.Services
{
    public class ImageService : IImageService
    {
        public ImageService(JumaContext db)
        {
        }

        private readonly JumaContext db;

        public void Add(Images images)
        {
            db.Images.Add(images);
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

        public Images Update(int ItemNumber, Images newImages)
        {
            throw new NotImplementedException();
        }
    }
}