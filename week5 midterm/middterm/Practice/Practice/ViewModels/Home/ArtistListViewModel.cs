using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practice.Models;
using System.Web.Mvc;

namespace Practice.ViewModels.Home
{
    public class ArtistListViewModel
    {
        public IEnumerable<SelectListItem> ArtistList { get; private set; }


        public Artist Name { get; set; }


        public ArtistListViewModel(IEnumerable<Artist> artists)
        {
            ArtistList = artists.Select(c => new SelectListItem() { Text = c.ArtistName });
            Name = artists.OrderByDescending(c => c.ArtistName).FirstOrDefault();


        }
    }

}