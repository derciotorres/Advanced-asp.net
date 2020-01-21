using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Models;
using Practice.ViewModels.Home;

namespace Practice.Controllers
{
    public class ArtistsController : Controller
    {
        // GET: Artists
        public ActionResult ArtistList()
        {
            var artistdata = new ArtistDb();


            var viewModel = new ArtistListViewModel(artistdata.Artists);

            return View(viewModel);
        }
    }
}