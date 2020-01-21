using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Register()
        {
            ViewBag.Message = "Your Register page.";

            return View();
        }

        public ActionResult memes()
        {
            var languages = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            ViewBag.LanguagesList = languages;
            return View();
        }
    }
}