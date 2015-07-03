using BExpensesDDD.Domain.Entities;
using System.Collections.Generic;

namespace BExpensesDDD.Domain.Interfaces
{
    public interface IRepositoryCentroCusto : IRepositoryBase<CentroCusto> 
    {
        IEnumerable<CentroCusto> BuscarNomeCentroCusto (string nome);
    }
}
