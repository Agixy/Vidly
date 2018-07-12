using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            return View(movie);  // zwraca wiodk obiektu "movie"
            //return HttpNotFound();    // zwraca błąd
            // return  new EmptyResult();   // zwraca nic - pusta strona
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });  // index-nazwa akcji(metody), Home-kontroler, parametry routingu - po czym ma szukać, wyswietlac
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}