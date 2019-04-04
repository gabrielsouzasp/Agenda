using System;
using System.Collections.Generic;
using System.Linq;
using Agenda.Contexts;
using Agenda.Interfaces;
using Agenda.Models;

namespace Agenda.Repositories
{
    public class CompromissoRepository : ICompromissoRepository
    {
        private readonly AgendaContext _agendaContext;

        public CompromissoRepository(AgendaContext agendaContext)
        {
            _agendaContext = agendaContext;
        }

        public void Add(Compromisso obj)
        {
            _agendaContext.Compromissos.Add(obj);
            _agendaContext.SaveChanges();
        }

        public IList<Compromisso> Get()
        {
            return _agendaContext.Compromissos.ToList();
        }

        public Compromisso Get(int id)
        {
            return _agendaContext.Compromissos.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Compromisso obj)
        {
            throw new ArgumentException();
        }

        public void Delete(Compromisso obj)
        {
            _agendaContext.Compromissos.Remove(obj);
        }
    }
}
