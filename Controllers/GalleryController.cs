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


namespace E_Commerce.Controllers
{
    public class GalleryController : Controller
    {
        private readonly ILogger<GalleryController> _logger;
        private readonly IHttpClientFactory clientFactory;
        private readonly JumaContext db;

        public GalleryController(ILogger<GalleryController> logger, JumaContext injectedContext)
        {
            _logger = logger;
            db = injectedContext;
        }
        [Route("Gallery")]

        public IActionResult Gallery()
        {
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
