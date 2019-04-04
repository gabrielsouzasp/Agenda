using System.Collections.Generic;
using Agenda.Interfaces;
using Agenda.Interfaces.Services;
using Agenda.Models;

namespace Agenda.Services
{
    public class CompromissoService : ICompromissoService
    {
        private readonly ICompromissoRepository _compromissoRepository;
        private readonly IPessoaService _pessoaService;

        public CompromissoService(ICompromissoRepository compromissoRepository, IPessoaService pessoaService)
        {
            _compromissoRepository = compromissoRepository;
            _pessoaService = pessoaService;
        }

        public void Add(Compromisso obj)
        {
            _compromissoRepository.Add(obj);
        }

        public IList<Compromisso> Get()
        {
            IList<Compromisso> compromissos = _compromissoRepository.Get();
            IList<Pessoa> pessoas = _pessoaService.Get();

            foreach (Compromisso compromisso in compromissos)
            {
                foreach (Pessoa pessoa in pessoas)
                {

                    //Fix pela falta de DTO
                    pessoa.Compromissos = null;

                    if (compromisso.PessoaId == pessoa.Id)
                    {
                        compromisso.Pessoa = pessoa;
                    }
                };
            };

            return compromissos;
        }

        public Compromisso Get(int id)
        {
            return _compromissoRepository.Get(id);
        }

        public void Update(Compromisso obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Compromisso obj)
        {
            _compromissoRepository.Delete(obj);
        }

    }
}
