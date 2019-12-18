using IoCNinjection.Models;
using IoCNinjection.Module;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IoCNinjection.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var language = kernel.Get<ILanguage>();
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