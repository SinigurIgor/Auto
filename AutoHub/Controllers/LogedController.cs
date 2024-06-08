using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoHub.Controllers
{
    public class LogedController : Controller
    {
        private readonly ISession _session;

        public LogedController()
        {
            var bl = new BusinessLogic.BusinessLogic1();
            _session = bl.GetSessionBL();
        }
        // GET: Loged
        public ActionResult Index()
        {
            var xKeyCookie = Request.Cookies["X-KEY"];
            if (xKeyCookie != null)
            {
                var user = _session.GetUserByCookie(xKeyCookie.Value);
                if (user != null)
                {
                    return View();
                }
            }
            if (xKeyCookie == null)
            {
                return RedirectToAction("LogIn", "Login");
            }
            return View();
        }
    }
}