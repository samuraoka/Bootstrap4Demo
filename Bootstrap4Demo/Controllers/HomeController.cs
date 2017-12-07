using Bootstrap4Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bootstrap4Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About(int id)
        {
            ViewData["pg-number"] = id < 1 || 3 < id ? 1 : id;
            ViewData["pg-previsou-enabled"] = ((int)ViewData["pg-number"]) == 1 ? "disabled" : "";
            ViewData["pg-next-enabled"] = ((int)ViewData["pg-number"]) == 3 ? "disabled" : "";
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new ContactViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactViewModel model)
        {
            return View(model);
        }

    }
}
