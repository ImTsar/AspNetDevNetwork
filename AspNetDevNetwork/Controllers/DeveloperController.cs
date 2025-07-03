using AspNetDevNetwork.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetDevNetwork.Controllers
{
    public class DeveloperController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BecomeDeveloper(Developer dev)
        {
            return ModelState.IsValid
                ? RedirectToAction(nameof(Confirmation), new { name = dev.Name, email = dev.Email })
                : View(nameof(Index), dev);
        }

        [HttpGet]
        public IActionResult Confirmation(string name, string email)
        {
            var dev = new Developer { Name = name, Email = email };

            return View(dev);
        }
    }
}
