
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AUTO.Models;

namespace AutoHub.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            UserData u = new UserData
            {
                Username = "Customer",
                Products = new List<string> { "Product #1", "Product #2", "Product #3", "Product #4" }
            };

            return View(u);
        }

        public ActionResult Privacy()
        {
            return View();
        }
        public ActionResult Contacts()
        {
            return View();
        }

        public ActionResult Catalog()
        {
            return View();
        }
        public ActionResult China()
        {
            return View();
        }
        public ActionResult Corea(String name)
        {
            
            ViewBag.Title = "Corea";
            
            ViewBag.Name = name;
            
            return View();
        }
}
}