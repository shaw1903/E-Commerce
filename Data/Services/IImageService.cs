using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;

namespace E_Commerce.Data.Services
{
    public interface IImageService
    {
        IEnumerable<Images> GetAll();
        Images GetImages(int ItemNumber);
        void Add(Images images);
        Images Update(int ItemNumber, Images newImages);
        void Delete(int ItemNumber);
    }
}