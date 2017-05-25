using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace TownHall.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Chart()
        {
            ViewData["Message"] = "Your application chart page.";

            return View();
        }

        public IActionResult Chat()
        {
            ViewData["Message"] = "Your application chat page.";

            return View();
        }
        [Authorize]
        public IActionResult Documents()
        {
            ViewData["Message"] = "Your application documents page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
