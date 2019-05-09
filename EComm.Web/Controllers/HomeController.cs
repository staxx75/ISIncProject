using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EComm.Web.Models;
using EComm.DataAccess;
using EComm.Model;
using Microsoft.EntityFrameworkCore;

namespace EComm.Web.Controllers
{
    public class HomeController : Controller
    {

        private ECommDataContext _dataContext;

        public HomeController(ECommDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            //Random rnd = new Random();
            //int value = rnd.Next(0, 3);
            //switch (value)
            //{
            //    case 1:
            //        return Content("Hello from HomeController");
            //        break;
            //    case 2:
            //        return Content("<em>Hello</em> from HomeController", "text/html");
            //        break;
            //    case 3:
            //        return Content("{\"Greeting\":\"Hello\"}", "application/json");
            //        break;
            //    default:
            //        return View();
            //        break;
            //}
            //return Content("Hello from HomeController");
            //return Content("<em>Hello</em> from HomeController", "text/html");
            //return Content("{\"Greeting\":\"Hello\"}", "application/json");

            // var products = _dataContext.Products.Include(p => p.Supplier).ToList();

            //return View(products);

            //return Content($"Number of products: {_dataContext.Products.Count()}");

            return View();
        }

        
        public List<Product> Index2()
        {
            return _dataContext.Products.ToList();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
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
