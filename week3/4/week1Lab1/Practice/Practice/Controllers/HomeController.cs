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
            var viewModel = new ViewModels.Home.ShowLanguagesViewModel(CultureInfo.GetCultures(CultureTypes.SpecificCultures));
            return View(viewModel);
        }

        public ActionResult Singer()
        {
            ViewModels.Home.SingerViewModel[] singerlist = new ViewModels.Home.SingerViewModel[2];

            singerlist[0] = new ViewModels.Home.SingerViewModel();
            singerlist[0].SingerName = "Bananas";
            singerlist[0].SingerTracks = 132;

            singerlist[1] = new ViewModels.Home.SingerViewModel();
            singerlist[1].SingerName = "apples";
            singerlist[1].SingerTracks = 13;

            return View(singerlist);
        }
    }
}