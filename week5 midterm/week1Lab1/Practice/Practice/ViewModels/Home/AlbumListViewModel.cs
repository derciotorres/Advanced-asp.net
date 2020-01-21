using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Models;

namespace Practice.ViewModels.Home
{
    public class AlbumListViewModel
    {
        public IEnumerable<SelectListItem> AlbumList { get; private set; }

        public Album MostTracks { get; set; }

        public AlbumListViewModel(IEnumerable<Album> albums)
        {


            AlbumList = albums.Select(c => new SelectListItem() { Text = c.Number_Tracks });

            MostTracks = albums.OrderByDescending(c => c.Number_Tracks).FirstOrDefault();


        }

    }
}