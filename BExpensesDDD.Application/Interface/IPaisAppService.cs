

using System.Collections.Generic;
using BExpensesDDD.Domain.Entities;

namespace BExpensesDDD.Application.Interface
{
    public interface IPaisAppService : IAppServiceBase<Pais>
    {
        IEnumerable<Pais> BuscarNomePais(string nome);
    }
}
