using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TownHall.Controllers
{
    public class OrganisationalChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}