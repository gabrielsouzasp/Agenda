using System.Collections.Generic;
using Agenda.Interfaces;
using Agenda.Interfaces.Services;
using Agenda.Models;

namespace Agenda.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public void Add(Pessoa obj)
        {
            _pessoaRepository.Add(obj);
        }

        public IList<Pessoa> Get()
        {
            return _pessoaRepository.Get();
        }

        public Pessoa Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Pessoa obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Pessoa obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
