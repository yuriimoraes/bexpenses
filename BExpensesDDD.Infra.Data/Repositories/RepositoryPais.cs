using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BExpensesDDD.Infra.Data.Repositories
{
    public class RepositoryPais : RepositoryBase<Pais>, IRepositoryPais
    {

        public IEnumerable<Pais> BuscarNomePais(string nome)
        {
            return Db.Paises.Where(p => p.NomePais == nome);
        }
    }
}
