
using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class DespesaCarroConfiguration : EntityTypeConfiguration<DespesaCarro>
    {
        public DespesaCarroConfiguration() 
        {
            HasKey(d => d.DespesaCarroID);
            Property(d => d.DescricaoDespesa)
                .IsRequired().HasMaxLength(150);
            Property(d => d.ValorDespesaCarro)
                .IsRequired();
            HasRequired(d => d.DespesaPrincipal)
                .WithMany()
                .HasForeignKey(d => d.DespesaPrincipalID);
            HasRequired(d => d.TipoDespesaCarro)
                .WithMany()
                .HasForeignKey(d => d.TipoDespesaCarroID);
        }
    }
}
