using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BExpensesDDD.Infra.Data.Repositories
{
    public class RepositoryPessoa : RepositoryBase<Pessoa>, IRepositoryPessoa
    {
        public IEnumerable<Pessoa> BuscarNomePessoa(string nome)
        {
            return Db.Pessoas.Where(p => p.Nome == nome);
        }
    }
}
