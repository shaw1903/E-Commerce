using System;
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
using E_Commerce.Data.Services;


namespace E_Commerce.Controllers
{
    public class ImageController : Controller
    {
        private readonly ILogger<ImageController> _logger;
        private readonly IHttpClientFactory clientFactory;
        private IImageService _service;
        public ImageController(ILogger<ImageController> logger, IImageService service)
        {
            _logger = logger;
            _service = service;
        }

        [Route("Gallery")]
        public IActionResult Gallery()
        {
            return View();
        }
        [Route("/Shows")]

        public IActionResult Shows()
        {
            var data = _service.GetAll();
            //var data = db.Images.ToList();
            return View(data);
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
