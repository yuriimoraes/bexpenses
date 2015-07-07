using BExpensesDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BExpensesDDD.Domain.Interfaces.Services
{
    public interface IClasseViagemService : IServiceBase<ClasseViagem> 
    {
        IEnumerable<ClasseViagem> BuscarNomeClasseViagem(string nome);
    }
}
