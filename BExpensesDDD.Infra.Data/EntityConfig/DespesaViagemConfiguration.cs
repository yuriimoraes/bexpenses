
using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class DespesaViagemConfiguration : EntityTypeConfiguration<DespesaViagem>
    {
        public DespesaViagemConfiguration() 
        {
            HasKey(d => d.DespesaViagemID);
            Property(d => d.Destino)
                .IsRequired().HasMaxLength(150);
            Property(d => d.Origem)
                .IsRequired().HasMaxLength(150);
            HasRequired(d => d.DespesaPrincipal)
                .WithMany()
                .HasForeignKey(d => d.DespesaPrincipalID);
            HasRequired(d => d.ClasseViagem)
               .WithMany()
               .HasForeignKey(d => d.ClasseViagemID);
        }
    }
}
