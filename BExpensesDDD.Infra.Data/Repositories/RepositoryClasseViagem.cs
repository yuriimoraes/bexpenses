using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BExpensesDDD.Infra.Data.Repositories
{
    public class RepositoryClasseViagem : RepositoryBase<ClasseViagem>, IRepositoryClasseViagem
    {
        public IEnumerable<ClasseViagem> BuscarNomeClasseViagem(string nome)
        {
            return Db.ClasseViagens.Where(c => c.DescricaoViagem == nome);
        }
    }
}
