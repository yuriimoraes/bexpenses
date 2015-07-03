using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class DespesaAcomodacaoConfiguration : EntityTypeConfiguration<DespesaAcomodacao>
    {
        public DespesaAcomodacaoConfiguration()
        {
            HasKey(d => d.DespesaAcomodacaoID);
            Property(d => d.DescricaoAcomodacao)
                .IsRequired().HasMaxLength(150);
            HasRequired(d => d.DespesaPrincipal)
                .WithMany()
                .HasForeignKey(d => d.DespesaPrincipalID);
            HasRequired(d => d.TipoAcomodacao)
                .WithMany()
                .HasForeignKey(d => d.TipoAcomodacaoID);
            Property(d => d.ValorDespesaAcomodacao)
                .IsRequired();
        }
       
    }
}
