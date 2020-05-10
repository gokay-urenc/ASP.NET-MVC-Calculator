using CalcMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace CalcMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Name, string Password)
        {
            if (new LoginState().IsLoginSuccess(Name, Password))
                return RedirectToAction("HesapMakinesi", "Home");
            return View();
        }

        public ActionResult HesapMakinesi()
        {
            return View();
        }
    }
}