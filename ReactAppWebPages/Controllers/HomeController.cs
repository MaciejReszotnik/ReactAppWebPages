using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactAppWebPages.Models;

namespace ReactAppWebPages.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var product = new Product {
                ProductID = 1111,
                Name = "Kayak",
                Description = "A boat for one person",
                Price = 275M
            };

            return View(product);
        }
    }
}