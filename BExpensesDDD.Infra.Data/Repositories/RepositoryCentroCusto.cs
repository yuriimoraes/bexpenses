using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
namespace BExpensesDDD.Infra.Data.Repositories
{
    public class RepositoryCentroCusto : RepositoryBase<CentroCusto>, IRepositoryCentroCusto
    {
        public IEnumerable<CentroCusto> BuscarNomeCentroCusto(string nome)
        {
            return Db.CentroCustos.Where(c => c.Descricao == nome);
        }
        
    }
}
