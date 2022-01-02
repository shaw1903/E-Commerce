using System;
using System.IO;
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
using E_Commerce;
using System.Text.Encodings.Web;
using static System.Console;

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

        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }
        
        
        public IActionResult Customers()
        {
            var AllCustomers = db.Customers.ToList();
            return View(AllCustomers);
/*

                        var model = db
            .Customers
            .TemporalAll()
            .Where(e => e.CustomerName == "Seoras")
            .OrderBy(e => e.CustomerName)
            .Select(e => e.CustomerName)
            .ToList();


        

            var model = new CustomersViewModel
            {
                VisitorCount = 12,
                Customers = db.Customers.ToList()
            };

                    IEnumerable<CustomersViewModel> model = db.Customers
        .Include(p => p.CustomerName)
        .Include(p => p.PostCode);
            
            
            var model = new CustomersViewModel
            {
                VisitorCount = 12,
                Customers = db.Customers.ToList()
            };
                var model = db.Customers
                // query is a DbSet<Product>
                .Where(Customers => Customers.CustomerName.Length >= 1)
                // query is now an IQueryable<Product>
                .OrderBy(Customers => Customers.CustomerName)
                // query is now an IOrderedQueryable<Product>
                .Select(Customers => new // anonymous type
                {
                    Customers.CustomerName,
                    Customers.PostCode,
                    Customers.PhoneNumber
                })
                .ToList();
                
                foreach (var item in model)
                {
                WriteLine("{0}: {1} costs {2}",
                    item.CustomerName, item.PostCode, item.PhoneNumber);
                }

                return View(model.ToList());

           // var DbQuery = db.Customers.Include(c => c.Customer);
                 
            var model = new CustomersViewModel
            {
                VisitorCount = 12,
                Customers = db.Customers.ToList()
            };

                var model = db.Customers
                // query is a DbSet<Product>
                .Where(Customers => Customers.CustomerName.Length >= 1)
                // query is now an IQueryable<Product>
                .OrderBy(Customers => Customers.CustomerName)
                // query is now an IOrderedQueryable<Product>
                .Select(Customers => new // anonymous type
                {
                    Customers.CustomerName,
                    Customers.PostCode,
                    Customers.PhoneNumber
                })
                .ToList();
                foreach (var item in model)
                {
                WriteLine("{0}: {1} costs {2}",
                    item.CustomerName, item.PostCode, item.PhoneNumber);
                }
            
            return View(model.ToList());

            
           Customers model = db.Customers.Where(x => x.CustomerName.Length >= 0)
           .Include(x => x.CustomerName).FirstOrDefault();
            return View(model);*/
/*
            var model = db.Customers
            .SingleOrDefaultAsync(p => p.CustomerName.Length >= 0 );
            return View(model);
            
                var model = db.Customers
                // query is a DbSet<Product>
                .Where(Customer => Customer.CustomerName.Length >= 1)
                // query is now an IQueryable<Product>
                .OrderBy(Customer => Customer.CustomerName)
                // query is now an IOrderedQueryable<Product>
                .Select(Customer => new // anonymous type
                {
                    Customer.CustomerName,
                    Customer.PostCode,
                    Customer.PhoneNumber
                })
                .ToList();
                foreach (var item in model)
                {
                WriteLine("{0}: {1} costs {2}",
                    item.CustomerName, item.PostCode, item.PhoneNumber);
                }
                WriteLine();
        
           
            using (var db = new JumaContext())
            {
                var model = db.Customers
                // query is a DbSet<Product>
                .Where(Customer => Customer.CustomerName.Length >= 1)
                // query is now an IQueryable<Product>
                .OrderBy(Customer => Customer.CustomerName)
                // query is now an IOrderedQueryable<Product>
                .Select(Customer => new // anonymous type
                {
                    Customer.CustomerName,
                    Customer.PostCode,
                    Customer.PhoneNumber
                })
                .ToList();
                foreach (var item in model)
                {
                WriteLine("{0}: {1} costs {2}",
                    item.CustomerName, item.PostCode, item.PhoneNumber);
                }
                WriteLine();
            }
            return View(Customer.ToList());*/
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
/*
         public async Task<IActionResult> Customers(string CustomerName)
            {
                string uri;
                if (string.IsNullOrEmpty(CustomerName))
                {
                    ViewData["Title"] = "All Customers Worldwide";
                    uri = "api/customers/";
                }
                else
                {
                    ViewData["Title"] = $"Customers in {CustomerName}";
                    uri = $"api/customers/?country={CustomerName}";
                }
                var client = clientFactory.CreateClient(
                name: "JumaService");

                var request = new HttpRequestMessage(
                    method: HttpMethod.Get, requestUri: uri);

                HttpResponseMessage response = await client.SendAsync(request);
                            var model = await response.Content
                    .ReadFromJsonAsync<IEnumerable<Customers>>();
                
                return View(model);

                var model = db.Customers
                // query is a DbSet<Product>
                .Where(Customer => Customer.CustomerName.Length >= 1)
                // query is now an IQueryable<Product>
                .OrderBy(Customer => Customer.CustomerName)
                // query is now an IOrderedQueryable<Product>
                .Select(Customer => new // anonymous type
                {
                    Customer.CustomerName,
                    Customer.PostCode,
                    Customer.PhoneNumber
                })
                .ToList();
                foreach (var item in model)
                {
                WriteLine("{0}: {1} costs {2}",
                    item.CustomerName, item.PostCode, item.PhoneNumber);
                }
                WriteLine();
            }
    */

    
    }
}
