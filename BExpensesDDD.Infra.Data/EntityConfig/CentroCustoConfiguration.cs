
using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class CentroCustoConfiguration: EntityTypeConfiguration<CentroCusto>
    {
        public CentroCustoConfiguration() 
        {
            HasKey(c => c.CentroCustoID);

            Property(c => c.Descricao)
                .IsRequired();
        }
    }
}
