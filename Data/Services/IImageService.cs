using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Models;

namespace E_Commerce.Data
{
    public interface IImageService
    {
        IEnumerable<Images> GetAll();
        Images GetImages(int ItemNumber);
        void Add(Images Images);
        Images Update(int ItemNumber, Images images);
        void Delete(int ItemNumber);
    }
}