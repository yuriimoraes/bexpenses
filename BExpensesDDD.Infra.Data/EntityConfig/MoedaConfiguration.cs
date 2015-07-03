
using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class MoedaConfiguration : EntityTypeConfiguration<Moeda>
    {
        public MoedaConfiguration() 
        {
            HasKey(m => m.MoedaID);
            Property(m => m.NomeMoeda)
                .IsRequired().HasMaxLength(150);
            Property(m => m.CodigoInternacional)
                .IsRequired().HasMaxLength(150);
        }
    }
}
