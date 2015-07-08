

using System.Collections.Generic;
using BExpensesDDD.Domain.Entities;
namespace BExpensesDDD.Application.Interface
{
    public interface ICentroCustoAppService : IAppServiceBase<CentroCusto>
    {
        IEnumerable<CentroCusto> BuscarNomeCentroCusto(string nome);
    }
}
