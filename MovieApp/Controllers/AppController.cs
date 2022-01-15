using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit()
        {
            throw new InvalidOperationException();
            return View();
        }

        [HttpGet("acercaDe")]
        public IActionResult About()
        {
            return View();
        }
    }
}
