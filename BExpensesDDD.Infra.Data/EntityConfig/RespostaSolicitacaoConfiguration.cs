
using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class RespostaSolicitacaoConfiguration : EntityTypeConfiguration<RespostaSolicitacao>
    {
        public RespostaSolicitacaoConfiguration() 
        {
            HasKey(r => r.RespostaSolicitacaoID);
            Property(r => r.Status)
                .IsRequired();
            HasRequired(s => s.Aprovador)
                .WithMany()
                .HasForeignKey(s => s.AprovadorID);
        }
    }
}
