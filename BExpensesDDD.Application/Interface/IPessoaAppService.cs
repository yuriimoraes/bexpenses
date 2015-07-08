

using System.Collections.Generic;
using BExpensesDDD.Domain.Entities;

namespace BExpensesDDD.Application.Interface
{
    public interface IPessoaAppService : IAppServiceBase<Pessoa>
    {
        IEnumerable<Pessoa> BuscarNomePessoa(string nome);
    }
}
