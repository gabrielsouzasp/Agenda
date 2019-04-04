using Agenda.Interfaces.Services;
using Agenda.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    public class PessoaApiController : Controller
    {
        private readonly IPessoaService _pessoaService;

        public PessoaApiController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet, ActionName("List")]
        public JsonResult Get()
        {
            return new JsonResult(_pessoaService.Get());
        }

        [HttpPost, ActionName("Create")]
        public void Create([FromBody]Pessoa p)
        {
            _pessoaService.Add(p);
        }
    }
}
