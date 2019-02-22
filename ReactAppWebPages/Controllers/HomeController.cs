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
        SimpleRepository Repository = SimpleRepository.SharedRepository;

        public IActionResult Index()
        {
            return View(SimpleRepository.SharedRepository.Products.Where(prod => prod.Price < 50));
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View(new Product());
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            Repository.AddProducts(product);
            return RedirectToAction("Index");
        }
    }
}