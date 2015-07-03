
using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class DespesaTransporteConfiguration : EntityTypeConfiguration<DespesaTransporte>
    {
        public DespesaTransporteConfiguration() 
        {
            HasKey(d => d.DespesaTransporteID);
            Property(d => d.Destino)
                .IsRequired().HasMaxLength(150);
            Property(d => d.Origem)
                .IsRequired().HasMaxLength(150);
            Property(d => d.ValorTransporte)
                .IsRequired();
            HasRequired(d => d.DespesaPrincipal)
                .WithMany()
                .HasForeignKey(d => d.DespesaPrincipalID);
        }
    }
}
