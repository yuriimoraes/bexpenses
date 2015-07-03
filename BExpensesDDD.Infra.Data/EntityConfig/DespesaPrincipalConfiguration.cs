using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class DespesaPrincipalConfiguration : EntityTypeConfiguration<DespesaPrincipal>
    {
        public DespesaPrincipalConfiguration() 
        {
            HasKey(d => d.DespesaPrincipalID);
            HasRequired(d => d.MoedaPadrao)
                .WithMany()
                .HasForeignKey(d => d.MoedaPadraoID);
            HasRequired(d => d.SolicitacaoViagem)
                .WithMany()
                .HasForeignKey(d => d.SolicitacaoViagemID);
        }
    }
}
