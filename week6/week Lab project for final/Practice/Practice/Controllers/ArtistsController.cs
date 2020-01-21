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
        private ArtistDb Db = new ArtistDb();
        // GET: Artists


        public ActionResult ArtistList()
        {


            var artistdata = new ArtistDb();


            var viewModel = new ArtistListViewModel(artistdata.Artists);

            return View(viewModel);
        }
        public ActionResult listofArtists(string searchCriteria)
        {
            /*
            var artistdata = new ArtistDb();

        var artists = new ArtistDb().Artists.ToList();
            return View(artists);
            */

            var artistdata = new ArtistDb();

            IQueryable<Artist> artists = artistdata.Artists.OrderBy(p => p.ArtistName);

            if(searchCriteria != null)
                {

                artists = artists.Where(p => p.ArtistName.Contains(searchCriteria));
         
            }
            var artistList1 = artists.Take(2).ToList();
            return View(artistList1);

        }

        public ActionResult Details (int id)
        {
            var artistdata = new ArtistDb();

            Artist found = artistdata.Artists.Where(p => p.Artist_Id == id).FirstOrDefault();

            return View(found);


        }

    }
}