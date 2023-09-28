using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rentals.Models;
using rentals.ViewModels;

namespace rentals.Controllers
{
    public class MoviesController : Controller
    {
        // GET: movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var movie = new Movie() { Name = "Shreik!" };

            // if (!pageIndex.HasValue)
            //    pageIndex = 1;
            // if (String.IsNullOrWhiteSpace(sortBy))
            //    sortBy = "Name";

            // return Content(String.Format("pageIndex={0}%sortBy={1}", pageIndex, sortBy)); --- change content by parameters

            // return View(movie);
            // return Content("Hello World");
            // return HttpNotFound();
            // return newEmptyResult();
            // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"}) ---- redirect with action url parameters

            // return ViewResult();

            // ViewData["Movie"] = movie;

            // ViewBag.Movie = movie;

            return View(movie);
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customers
            };

            return View(viewModel);
            // viewResult.ViewData.Model;

            // if (!pageIndex.HasValue)
            //    pageIndex = 1;
            // if (String.IsNullOrWhiteSpace(sortBy))
            //    sortBy = "Name";

            // return Content(String.Format("pageIndex={0}%sortBy={1}", pageIndex, sortBy)); --- change content by parameters

            // return View(movie);
            // return Content("Hello World");
            // return HttpNotFound();
            // return newEmptyResult();
            // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"}) ---- redirect with action url parameters

            // return ViewResult();

            // ViewData["Movie"] = movie;

            // ViewBag.Movie = movie;

            // return View(movie);
        }

        // [Route("movies/released/{year}/{month:regex(\\d{4):range(1,12)}")]
        // public ActionResult ByReleaseDate(int year, int month)
        // {
        //    return Content(year + "/" + month);
        // }

        // private ActionResult ViewResult()
        // {
        //    throw new NotImplementedException();
        // }

        // GET: movies/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: movies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: movies/Edit/5
        public ActionResult Edit(int id)
        {
            // return Content("id=" + id) either /movies/edit/1 or /movies/edit?id=1
            return View();
        }

        // POST: movies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: movies/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: movies/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}