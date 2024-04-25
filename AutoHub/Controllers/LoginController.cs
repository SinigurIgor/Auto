
using System.Web.Mvc;
using BusinessLogic;
using BusinessLogic.Interfaces;

namespace AutoHub.Controllers
{
    public class LoginController : Controller
    {

        private readonly ISession _session;

        public LoginController()
        {
            var bl = new BusinessLogic1();
            _session = bl.GetSessionBL();
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
    }
}