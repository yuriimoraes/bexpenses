
using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class PessoaConfiguration: EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguration() 
        {
            HasKey(p =>p.PessoaID);
            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);
            Property(p => p.Login)
                .IsRequired();
            Property(p => p.Senha)
                .IsRequired();
            Property(p => p.Email)
                .IsRequired();
            Property(p => p.CodigoFornecedorSAP)
                .IsRequired();
            Property(p => p.Telefone1)
                .IsRequired();
            HasRequired(p => p.CentroCusto)
               .WithMany()
               .HasForeignKey(p => p.CentroCustoID);
            
            /*asOptional(p => p.Aprovador1)
              .WithMany()
              .HasForeignKey(p => p.Aprovador1ID);
            HasOptional(p => p.Aprovador2)
             .WithMany()
             .HasForeignKey(p => p.Aprovador2ID);*/

        }
    }
}
