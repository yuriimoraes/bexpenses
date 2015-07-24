
using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class RespostaSolicitacaoReembolsoConfiguration : EntityTypeConfiguration<RespostaSolicitacaoReembolso>
    {
        public RespostaSolicitacaoReembolsoConfiguration() 
        {
            HasKey(r => r.RespostaSolicitacaoID);
            Property(r => r.Status)
                .IsRequired();
            HasRequired(s => s.Aprovador)
                .WithMany()
                .HasForeignKey(s => s.AprovadorID);
            HasRequired(s => s.SolicitacaoReembolso)
                .WithMany()
                .HasForeignKey(s => s.SolicitacaoReembolsoID);
        }
    }
}
