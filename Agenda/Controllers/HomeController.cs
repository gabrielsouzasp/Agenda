using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
