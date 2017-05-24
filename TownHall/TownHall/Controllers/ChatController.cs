using Microsoft.AspNetCore.Mvc;

namespace TownHall.Controllers
{
    public class ChatController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("InsertUserName");
        }

        [HttpPost]
        public IActionResult Index(string username)
        {
            return View("Index", username);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
