using BExpensesDDD.Domain.Entities;
using System.Collections.Generic;

namespace BExpensesDDD.Domain.Interfaces
{
    public interface IRepositoryPessoa : IRepositoryBase<Pessoa>
    {
        IEnumerable<Pessoa> BuscarNomePessoa(string nome);
        IEnumerable<Pessoa> BuscarAprovadores(IEnumerable<Pessoa> pessoas);
        Pessoa ObterAdministrador(Pessoa pessoa);

    }
}
