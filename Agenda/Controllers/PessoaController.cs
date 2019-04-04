using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
