using BExpensesDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class TipoViagemConfiguration : EntityTypeConfiguration<TipoViagem>
    {
        public TipoViagemConfiguration() 
        {
            HasKey(t => t.TipoViagemID);
            Property(t => t.Descricao)
                .IsRequired();
        }
    }
}
