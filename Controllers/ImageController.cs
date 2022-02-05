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
        private readonly IImageService _service;
        private readonly JumaContext db;


        public ImageController(IImageService service)
        {
            _service = service;
        }
        [Route("Gallery")]

        public IActionResult Gallery()
        {
            var data = _service.GetAll();
            return View();
        }
        [Route("/Shows")]

        public IActionResult Shows()
        {
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
