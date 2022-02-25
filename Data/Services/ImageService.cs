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

        public IEnumerable<Images> FindLastItem(int ItemNumber)
        {
            var result = db.Images.ToList().Max();
            return (IEnumerable<Images>)result;
        }

        public Images Update(int ItemNumber, Images Images)
        {
            throw new NotImplementedException();
        }
    }
}