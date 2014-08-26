using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewPassingModel.Models;

namespace PartialViewPassingModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            //Product p1 = new Product() { Name = "Ice Cream", Price = 200 };
            //Product p2 = new Product() { Name = "Potato", Price = 300 };
            //Product p3 = new Product() { Name = "Lonka", Price = 500 };


            //List<Product> producList = new List<Product>();
            //  producList.Add(p1);
            //  producList.Add(p2);
            //  producList.Add(p3);

            Product[] productList = new[]
                            {
                                new Product() { Name = "Ice Cream", Price = 200},
                                new Product() { Name = "Potato", Price = 300 },
                                new Product() { Name = "Lonka", Price = 500 }
                               
                            };
           
            return View(productList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
