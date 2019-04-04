using Agenda.EntityConfig;
using Agenda.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Contexts
{
    public class AgendaContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Compromisso> Compromissos { get; set; }

        public AgendaContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PessoaConfiguration());
            builder.ApplyConfiguration(new CompromissoConfiguration());
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
