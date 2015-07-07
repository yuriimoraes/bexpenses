

using System.Collections.Generic;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        private readonly IRepositoryPessoa _repositoryPessoa;

        public PessoaService(IRepositoryPessoa repositoryPessoa)
            : base(repositoryPessoa)
        {
            _repositoryPessoa = repositoryPessoa;
        }

        public IEnumerable<Pessoa> BuscarNomePessoa(string nome)
        {
            return _repositoryPessoa.BuscarNomePessoa(nome);
        }
    }
}
