using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Vidly.Controllers;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //routes.MapRoute("MoviesByReleaseDate", "movies/released/{year}/{month}",
            //    new {controller = "Movies", action = "ByReleaseDate"},
            //    //new {year = @"\d{4}", month = @"\d{2}"});  // Rok musi miec 4 cyfry, miesiac musi miec 2 (np 03 lub 11)
            //    new {year = @"2015 | 2016", month = @"\d{2}"}); // Tylko rok 2015 lub 2016
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
