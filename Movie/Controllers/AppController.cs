using Microsoft.AspNetCore.Mvc;
using Movie.Models.ViewModels;

namespace Movie.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(MovieViewModel movieVM)
        {
            return View();
        }

        [HttpGet("About-Us")]
        public IActionResult About()
        {
            return View();
        }
    }
}
