using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MapPracticeApp.Models;

namespace MapPracticeApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Map aMap = new Map();
            aMap.Location = "Dacca";
            aMap.Latitude = 23.7526973;
            aMap.Longitude = 90.3949638;
            aMap.Height = 300;
            aMap.Width = 300;
            ViewData["MapVal"] = aMap;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ShowMap()
        {
            ViewBag.MapTitle = "Dhaka";
            ViewBag.MapLat = 23.7806365;
            ViewBag.MapLon = 90.4193257;
            ViewBag.MapHeight = 300;
            ViewBag.MapWidth = 200;
            return View();
        }
    }
}