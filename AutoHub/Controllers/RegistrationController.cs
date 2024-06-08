using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoHub.Models.User;
using BusinessLogic.Interfaces;
using Domain.Entities.User;

namespace AutoHub.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ISession _session;
        public RegistrationController()
        {
            var bl = new BusinessLogic.BusinessLogic1();
            _session = bl.GetSessionBL();
        }
        // GET: Registration
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Registration user)
        {

            if (ModelState.IsValid)
            {
                URegister newUser = new URegister();
                {
                    newUser.Name = user.Name;
                    newUser.Surname = user.Surname;
                    newUser.Email = user.Email;
                    newUser.Password = user.Password;

                }
                _session.RegisterAction(newUser);

                ViewBag.Message = user.Name + " " + user.Surname + " успешно зарегистрирован";
            }
            return View();
        }
    }
}