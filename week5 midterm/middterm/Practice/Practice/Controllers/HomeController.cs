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
            ViewBag.Message = "Startup";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Test";

            return View();
        }

        public ActionResult memes()
        {
            var viewModel = new ViewModels.Home.ShowLanguagesViewModel(CultureInfo.GetCultures(CultureTypes.SpecificCultures));
            return View(viewModel);
        }

        
    }
}