
using System;
using System.Net;
using System.Security.Cryptography;
using System.Web.Mvc;
using AutoHub.Models.User;
using BusinessLogic;
using BusinessLogic.Interfaces;
using Domain.Entities.Responces;
using Domain.Entities.User;

namespace AutoHub.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession _session;

        public LoginController() 
        {
            var bl = new BusinessLogic.BusinessLogic1();
            _session = bl.GetSessionBL();
        }

        // GET : Login
        public ActionResult Index()
        { 
            return View(new UActionLogin()); 
        }

        [HttpPost]
        public ActionResult LogIn(UActionLogin data) 
        {
            
            var address = base.Request.UserHostAddress;
            var ulData = new UserLoginData
            {
                Credential = data.Credential,
                Password = data.Password,
                LastLogin = DateTime.Now,
                UserIp = address
            };

            BaseResponces resp = _session.ValidateUserCredentialAction(ulData);

            return null;
        }

        // NEED to implement POST for USER Request
    }
}