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

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact(ContactViewModel model)
        {
            return View(model);
        }

    }
}
