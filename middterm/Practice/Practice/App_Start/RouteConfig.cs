using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Practice
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
           routes.MapRoute(" About", "About", new { controller = "Home", action = "About" });
           routes.MapRoute(" Contact", "Contact", new { controller = "Home", action = "Contact" });
            routes.MapRoute(" Register", "Register", new { controller = "Home", action = "Contact" });
            routes.MapRoute(" ArtistList", "ArtistList", new { controller = "Artists", action = "ArtistList" });
            routes.MapRoute(" AlbumList", "AlbumList", new { controller = "AlbumL", action = "AlbumList" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

            );
        }
    }
}
