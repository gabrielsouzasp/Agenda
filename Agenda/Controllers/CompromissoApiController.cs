using Agenda.Interfaces.Services;
using Agenda.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    public class CompromissoApiController : Controller
    {
        private readonly ICompromissoService _compromissoService;

        public CompromissoApiController(ICompromissoService compromissoService)
        {
            _compromissoService = compromissoService;
        }

        [HttpGet, ActionName("List")]
        public JsonResult Get()
        {
            return new JsonResult(_compromissoService.Get());
        }

        [HttpPost, ActionName("Create")]
        public void Create([FromBody]Compromisso p)
        {
            _compromissoService.Add(p);
        }
    }
}