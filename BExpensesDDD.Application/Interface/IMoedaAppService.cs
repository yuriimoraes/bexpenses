

using System.Collections.Generic;
using BExpensesDDD.Domain.Entities;

namespace BExpensesDDD.Application.Interface
{
    public interface IMoedaAppService : IAppServiceBase<Moeda>
    {
        IEnumerable<Moeda> BuscarNomeMoeda(string nome);
    }
}
