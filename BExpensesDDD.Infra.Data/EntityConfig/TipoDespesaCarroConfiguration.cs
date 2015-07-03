using BExpensesDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class TipoDespesaCarroConfiguration : EntityTypeConfiguration<TipoDespesaCarro>
    {
        public TipoDespesaCarroConfiguration() 
        {
            HasKey(t => t.TipoDespesaCarroID);
            Property(t => t.DescricaoDespesaCarro)
                .IsRequired();
        }
    }
}
