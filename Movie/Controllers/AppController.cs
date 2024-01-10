using Microsoft.AspNetCore.Mvc;
using Movie.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Movie.Controllers
{
    public class AppController : Controller
    {
        private static List<MovieViewModel> Movies = new List<MovieViewModel>();

        public IActionResult Index()
        {
            return View(Movies);
        }

        public IActionResult AddOrEdit(Guid id)
        {
            var movie = Movies.FirstOrDefault(x => x.Id == id);
            if (movie == null)
            {
                return View();
            }
            return View(movie);
        }

        [HttpPost]
        public IActionResult AddOrEdit(MovieViewModel movieVM)
        {
            if (ModelState.IsValid)
            {
                var movie = Movies.FirstOrDefault(x => x.Id == movieVM.Id);
                if (movie == null)
                {
                    movieVM.Id = Guid.NewGuid();
                    Movies.Add(movieVM);
                }
                else
                {
                    movie.Name = movieVM.Name;
                    movie.Genre = movieVM.Genre;
                }
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(Guid id)
        {
            var movie = Movies.FirstOrDefault(x => x.Id == id);
            Movies.Remove(movie);
            return RedirectToAction("Index");
        }

        [HttpGet("About-Us")]
        public IActionResult About()
        {
            return View();
        }
    }
}
