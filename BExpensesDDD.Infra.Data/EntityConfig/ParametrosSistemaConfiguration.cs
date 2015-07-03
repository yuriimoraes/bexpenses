

using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class ParametrosSistemaConfiguration : EntityTypeConfiguration<ParametrosSistema>
    {
        public ParametrosSistemaConfiguration()
        {
            HasKey(p => p.ParametrosSistemaID);
            Property(p => p.Campo)
                .IsRequired();
            Property(p => p.Valor)
                .IsRequired();
            Property(p => p.DataInicial)
                .IsRequired();
            Property(p => p.DataCadastro)
                .IsRequired();
           

        }
    }
}
