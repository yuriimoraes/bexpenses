using BExpensesDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BExpensesDDD.Domain.Interfaces.Services
{
    public interface IPessoaService : IServiceBase<Pessoa>
    {
        IEnumerable<Pessoa> BuscarNomePessoa(string nome);
        IEnumerable<Pessoa> BuscarAprovadores( IEnumerable<Pessoa> pessoas);
        Pessoa ObterAdministrador(Pessoa pessoa);
    }
}
