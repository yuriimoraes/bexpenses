
using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class DespesaOutroConfiguration : EntityTypeConfiguration<DespesaOutro>
    {
        public DespesaOutroConfiguration() 
        {
            HasKey(d => d.DespesaOutroID);
            Property(d => d.DescricaoGeral)
                .IsRequired().HasMaxLength(150);
            Property(d => d.ValorDespesaOutro)
                .IsRequired();
            HasRequired(d => d.DespesaPrincipal)
                .WithMany()
                .HasForeignKey(d => d.DespesaPrincipalID);
        }

    }
}
