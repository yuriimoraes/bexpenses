using BExpensesDDD.Domain.Entities;
using System.Collections.Generic;

namespace BExpensesDDD.Domain.Interfaces
{
    public interface IRepositoryPessoa : IRepositoryBase<Pessoa>
    {
        IEnumerable<Pessoa> BuscarNomePessoa(string nome);
    }
}
