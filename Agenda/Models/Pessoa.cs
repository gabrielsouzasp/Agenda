using System.Collections.Generic;

namespace Agenda.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual IList<Compromisso> Compromissos { get; set; }
    }
}
