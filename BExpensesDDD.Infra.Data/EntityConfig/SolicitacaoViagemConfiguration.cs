

using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class SolicitacaoViagemConfiguration : EntityTypeConfiguration<SolicitacaoViagem>
    {
        public SolicitacaoViagemConfiguration()
        {
            HasKey(s => s.SolicitacaoViagemID);
            Property(s => s.Status)
                .IsRequired();
            HasRequired(s => s.PaisDestino)
                .WithMany()
                .HasForeignKey(s => s.PaisDestinoID);
            HasRequired(s => s.PaisOrigem)
               .WithMany()
               .HasForeignKey(s => s.PaisOrigemID);
            HasRequired(s => s.PessoaRecebe)
               .WithMany()
               .HasForeignKey(s => s.PessoaRecebeID);
            HasRequired(s => s.PessoaSolicitante)
               .WithMany()
               .HasForeignKey(s => s.PessoaSolicitanteID);

        }
    }
}
