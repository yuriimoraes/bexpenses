using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class DespesaPerDiemConfiguration : EntityTypeConfiguration<DespesaPerDiem>
    {
        public DespesaPerDiemConfiguration() 
        {
            HasKey(d => d.DespesaPerID);
            Property(d => d.ValorTotal)
                .IsRequired();
            HasRequired(d => d.DespesaPrincipal)
                .WithMany()
                .HasForeignKey(d => d.DespesaPrincipalID);
            HasRequired(d => d.SolicitacaoViagem)
                .WithMany()
                .HasForeignKey(d => d.SolicitacaoViagemID);

        }
    }
}
