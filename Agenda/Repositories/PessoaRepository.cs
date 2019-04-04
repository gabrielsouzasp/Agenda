using System.Collections.Generic;
using System.Linq;
using Agenda.Contexts;
using Agenda.Interfaces;
using Agenda.Models;

namespace Agenda.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly AgendaContext _agendaContext;

        public PessoaRepository(AgendaContext agendaContext)
        {
            _agendaContext = agendaContext;
        }

        public void Add(Pessoa obj)
        {
            _agendaContext.Add(obj);
            _agendaContext.SaveChanges();
        }

        public IList<Pessoa> Get()
        {
            return _agendaContext.Pessoas.ToList();
        }

        public Pessoa Get(int id)
        {
            return _agendaContext.Pessoas.FirstOrDefault(p => p.Id == id);
        }

        public void Update(Pessoa obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Pessoa obj)
        {
            _agendaContext.Remove(obj);
        }
    }
}
