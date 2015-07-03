using BExpensesDDD.Domain.Entities;
using System.Collections.Generic;

namespace BExpensesDDD.Domain.Interfaces
{
    public interface IRepositoryMoeda : IRepositoryBase<Moeda>
    {
        IEnumerable<Moeda> BuscarNomeMoeda(string nome);
    }
}
