
using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class SolicitacaoReembolsoConfiguration : EntityTypeConfiguration<SolicitacaoReembolso> 
    {
        public SolicitacaoReembolsoConfiguration()
        {
            HasKey(s => s.SolicitacaoReembolsoID);
            Property(s => s.Status)
                .IsRequired();
            HasRequired(s => s.DespesaPrincipal)
                .WithMany()
                .HasForeignKey(s => s.DespesaPrincipalID);
            
 
 
        }   
    }
}
