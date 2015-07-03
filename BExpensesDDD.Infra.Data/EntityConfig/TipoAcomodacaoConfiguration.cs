
using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class TipoAcomodacaoConfiguration : EntityTypeConfiguration<TipoAcomodacao>
    {
        public TipoAcomodacaoConfiguration() 
        {
            HasKey(t => t.TipoAcomodacaoID);
            Property(t => t.DescricaoTipoAcomodacao)
                .IsRequired();
        }
    }
}
