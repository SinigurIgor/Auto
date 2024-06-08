
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


            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Contacts()
        {
            return View();
        }

        public ActionResult China()
        {
            return View();
        }
        public ActionResult Corea()
        {


            return View();
        }
        public ActionResult USA()
        {
            return View();
        }
    }

}