using BExpensesDDD.Domain.Entities;
using System.Collections.Generic;

namespace BExpensesDDD.Domain.Interfaces
{
    public interface IRepositoryClasseViagem : IRepositoryBase<ClasseViagem> 
    {
        IEnumerable<ClasseViagem> BuscarNomeClasseViagem(string nome);
    }
}
