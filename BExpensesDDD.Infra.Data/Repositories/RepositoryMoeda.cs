using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BExpensesDDD.Infra.Data.Repositories
{
    public class RepositoryMoeda : RepositoryBase<Moeda>, IRepositoryMoeda
    {
        public IEnumerable<Moeda> BuscarNomeMoeda(string nome)
        {
            return Db.Moedas.Where(m => m.NomeMoeda == nome);
        }
    }
}
