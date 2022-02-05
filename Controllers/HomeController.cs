using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using E_Commerce.Models;
using E_Commerce.Data;
using System;
using System.IO;
using System.Threading.Tasks;
using E_Commerce.Data.Services;

namespace E_Commerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory clientFactory;
        private readonly JumaContext db;

        public HomeController(ILogger<HomeController> logger, JumaContext injectedContext)
        {
            _logger = logger;
            db = injectedContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("Services")]
        public IActionResult Services()
        {
            return View();
        }  
        
        public IActionResult Customers()
        {
            var AllCustomers = db.Customers.ToList();
            return View(AllCustomers);
        } 

        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult Shows()
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
