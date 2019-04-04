using Agenda.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agenda.EntityConfig
{
    public class CompromissoConfiguration : IEntityTypeConfiguration<Compromisso>
    {
        public void Configure(EntityTypeBuilder<Compromisso> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome).IsRequired().HasMaxLength(250);

            builder.Property(c => c.DataCompromisso).IsRequired();

            builder.HasOne(p => p.Pessoa).WithMany(c => c.Compromissos).HasForeignKey(p => p.PessoaId).IsRequired();
        }
    }
}
