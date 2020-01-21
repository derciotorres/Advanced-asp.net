using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.ViewModels.Home;
using Practice.Models;

namespace Practice.Controllers
{
    public class AlbumController : Controller
    {
        // GET: Album
        public ActionResult AlbumList()
        {

            var music = new AlbumDB();

            var viewModel = new AlbumListViewModel(music.Albums);
            return View(viewModel);
        }
    }
}