using BExpensesDDD.Domain.Entities;
using System.Collections.Generic;

namespace BExpensesDDD.Domain.Interfaces
{
    public interface IRepositoryPais : IRepositoryBase<Pais>
    {
        IEnumerable<Pais> BuscarNomePais(string nome);
    }
}
