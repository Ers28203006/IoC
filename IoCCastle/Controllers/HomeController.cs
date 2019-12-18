using IoCCastle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IoCCastle.Controllers
{
    //Castle.Windsor.Web.Mvc
    public class HomeController : Controller
    {
        ILanguage language;
        public HomeController(ILanguage language)
        {
            this.language = language;
        }
        public ActionResult Index()
        {
            ViewBag.Language = language.Message();
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
    }
}