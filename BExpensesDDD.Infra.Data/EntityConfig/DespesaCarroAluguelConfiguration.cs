

using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class DespesaCarroAluguelConfiguration : EntityTypeConfiguration<DespesaCarroAluguel>
    {
        public DespesaCarroAluguelConfiguration()
        {
            HasKey(d => d.DespesaCarroAluguelID);
            Property(d => d.Descricao)
                .IsRequired().HasMaxLength(150);
            Property(d => d.AgenciaAluguel)
                .IsRequired();
            Property(d => d.DataInicial)
                .IsRequired();
            Property(d => d.DataFinal)
                .IsRequired();
            Property(d => d.ValorDespesaCarroAluguel)
                .IsRequired();
            HasRequired(d => d.DespesaPrincipal)
                .WithMany()
                .HasForeignKey(d => d.DespesaPrincipalID);
            
        }
    }
}
