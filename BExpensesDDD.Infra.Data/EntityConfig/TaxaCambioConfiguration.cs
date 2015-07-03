
using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class TaxaCambioConfiguration : EntityTypeConfiguration<TaxaCambio>
    {
        public TaxaCambioConfiguration() 
        {
            HasKey(t => t.TaxaCambioID);
            Property(t => t.cotPreco)
                .IsRequired();
            Property(t => t.DataInicial)
                .IsRequired();
            Property(t => t.DataFinal)
                .IsRequired();
            Property(t => t.DataInicial)
                .IsRequired();
            HasRequired(t => t.DespesaPrincipal)
                .WithMany()
                .HasForeignKey(t => t.DespesaPrincipalID);
            HasRequired(t => t.De)
                .WithMany()
                .HasForeignKey(t => t.MoedaDeID);
            HasRequired(t => t.Para)
               .WithMany()
               .HasForeignKey(t => t.MoedaParaID);
           
        }
    }
}
