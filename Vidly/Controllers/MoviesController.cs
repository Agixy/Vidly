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

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format($"pageIndex={pageIndex}&sortBy={sortBy}"));
        }
    }
}