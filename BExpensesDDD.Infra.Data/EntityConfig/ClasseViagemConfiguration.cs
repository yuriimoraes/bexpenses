using BExpensesDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace BExpensesDDD.Infra.Data.EntityConfig
{
    public class ClasseViagemConfiguration : EntityTypeConfiguration<ClasseViagem>
    {
        public ClasseViagemConfiguration() 
        {
            HasKey(c => c.ClasseViagemID);
            Property(c => c.DescricaoViagem)
                .IsRequired().HasMaxLength(150);
        }
    }
}
