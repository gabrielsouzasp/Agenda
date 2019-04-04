using System;

namespace Agenda.Models
{
    public class Compromisso
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataCompromisso { get; set; }

        public virtual int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
