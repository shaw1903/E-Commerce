using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Net.Http.Json;
using E_Commerce.Models;
using E_Commerce.Data;
using System.Text.Encodings.Web;
using System.IO;


namespace E_Commerce.Controllers
{
    public class ImageController : Controller
    {
        private readonly ILogger<ImageController> _logger;
        private readonly IHttpClientFactory clientFactory;
        private ImageService _ImageService;
        private IImageService _service;
        private readonly JumaContext db;
        public ImageController(ILogger<ImageController> logger, IImageService service, JumaContext injectedContext, ImageService ImgSer)
        {
            _logger = logger;
            _service = service;
            db = injectedContext;
            _ImageService = ImgSer;
        }


        [Route("Gallery")]
        public IActionResult Gallery()
        {
            return View();
        }
        [Route("/Shows")]

        public IActionResult Shows(int ItemNumber, string ItemName, string ImageURL, DateTime DateTaken, Images Images)
        {   
            if(ModelState.IsValid)
            {
                try{
                string MasterPath = "/Users/Seoras/Pictures/Shows/Show1";                
                //Write files not in database to database and save.
            
                string[] Files = Directory.GetFiles($"{MasterPath}");
                string[] dbImageURLs = db.Images.AsEnumerable().Select(x => x.ImageURL).ToArray();
                string[] diff = Files.Except(dbImageURLs).ToArray();

                foreach(string item in diff)
                    {
                        Images.ItemID = 000;
                        Images.ItemName = Path.GetFileName(item);
                        Images.ImageURL = Path.GetFullPath(item);
                        Images.DateTaken = System.IO.File.GetCreationTime(item);
                        Images.Event = "Testing";
                        Images.ItemPrice = 14.40M;
                        //Images.ItemID = Images.ItemID;
                        //db.Entry(Images).State = EntityState.Modified;
                        //db.SaveChanges();
                        db.Images.Add(Images);
                        db.SaveChanges();

                        //db.Images.Update(Images);
                        //db.Entry(Images).State = EntityState.Modified;
                    }
                    
                        //db.SaveChanges();
                    var detail = db.Images.ToList();
                    return View(detail);
                }
                catch(Exception ex)
                {
                    return View(ex.Message);
                }
            }
        ModelState.AddModelError("","Error");
        return View();
        }

        [Route("/Weddings")]
        public IActionResult Weddings()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
