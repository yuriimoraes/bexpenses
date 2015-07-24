

using System.Data.Entity.ModelConfiguration;
using BExpensesDDD.Domain.Entities;

namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class RespostaSolicitacaoViagemConfiguration: EntityTypeConfiguration<RespostaSolicitacaoViagem>
    {
        public RespostaSolicitacaoViagemConfiguration() 
        {
            HasKey(r => r.RespostaSolicitacaoViagemID);
            Property(r => r.Status)
                .IsRequired();
            HasRequired(s => s.Aprovador)
                .WithMany()
                .HasForeignKey(s => s.AprovadorID);
            HasRequired(s => s.SolicitacaoViagem)
                .WithMany()
                .HasForeignKey(s => s.SolicitacaoViagemID);
        }
    }
}
