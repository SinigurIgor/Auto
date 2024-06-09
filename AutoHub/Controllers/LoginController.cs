using System;
using System.Web;
using System.Web.Mvc;
using AutoHub.Models.User;
using AutoMapper;
using BusinessLogic.Interfaces;
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

        // GET: Login
        public ActionResult Index(UserLogin login)
        {
            if (ModelState.IsValid)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<UserLogin, UserLoginData>());
                var mapper = config.CreateMapper();
                var data = mapper.Map<UserLoginData>(login);
                data.UserIp = Request.UserHostAddress;
                data.LoginDateTime = DateTime.Now;
                var userLogin = _session.UserLogin(data);
                if (userLogin.Status)
                {
                    HttpCookie cookie = _session.GenCookie(login.Email);
                    ControllerContext.HttpContext.Response.Cookies.Add(cookie);
                    HttpCookie xKeyCookie = new HttpCookie("X-KEY", cookie.Value);
                    ControllerContext.HttpContext.Response.Cookies.Add(xKeyCookie);

                    return RedirectToAction("Index", "Loged");
                }
                else
                {
                    ModelState.AddModelError("Login or password wrong", userLogin.StatusMsg);
                }
            }
            return View("LogIn", login);
        }

        //[HttpPost]
        //public ActionResult LogIn(UActionLogin data)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        // Возвращаем пользователя на страницу входа с сообщением об ошибке
        //        return View("Index", data);
        //    }

        //    var address = Request.UserHostAddress;
        //    var ulData = new UserLoginData
        //    {

        //        Password = data.Password,
        //        LastLogin = DateTime.Now,
        //        UserIp = address
        //    };

        //    //BaseResponces resp = _session.ValidateUserCredentialAction(ulData);

        //    //if (resp.IsSuccess)
        //    //{
        //    //    // Логин успешен
        //    //    // Возможно, установим сессию или куки для пользователя
        //    //    // Например, можно использовать FormsAuthentication для управления аутентификацией
        //    //    // FormsAuthentication.SetAuthCookie(data.Credential, false);

        //    //    // Перенаправляем пользователя на домашнюю страницу или в личный кабинет
        //    //    return RedirectToAction("Index", "Home");
        //    //}
        //    //else
        //    //{
        //    //    // Логин не удался
        //    //    // Добавляем ошибку в ModelState
        //    //    ModelState.AddModelError("", "Invalid login attempt.");

        //    //    // Возвращаем пользователя на страницу входа с сообщением об ошибке
        //    //    return View("Index", data);
        //    //}
        //}

        // Дополнительно можно добавить метод для выхода пользователя
        public ActionResult LogOut()
        {
            // Например, можно использовать FormsAuthentication для выхода
            // FormsAuthentication.SignOut();

            // Перенаправляем пользователя на страницу входа
            return RedirectToAction("Index");
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}