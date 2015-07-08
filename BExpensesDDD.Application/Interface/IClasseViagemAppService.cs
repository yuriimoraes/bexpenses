

using System.Collections.Generic;
using BExpensesDDD.Domain.Entities;

namespace BExpensesDDD.Application.Interface
{
    public interface IClasseViagemAppService : IAppServiceBase<ClasseViagem>
    {
        IEnumerable<ClasseViagem> BuscarNomeClasseViagem(string nome);
    }
}
