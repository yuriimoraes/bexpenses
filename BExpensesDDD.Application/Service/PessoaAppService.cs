

using System.Collections.Generic;
using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class PessoaAppService : AppServiceBase<Pessoa>, IPessoaAppService
    {
        private readonly IPessoaService _pessoa;

        public PessoaAppService(IPessoaService pessoa)
            :base(pessoa)
        {
            _pessoa = pessoa;
        }

        public IEnumerable<Pessoa> BuscarNomePessoa(string nome)
        {
            return _pessoa.BuscarNomePessoa(nome);  
        }


        public IEnumerable<Pessoa> BuscarAprovadores()
        {
            return _pessoa.BuscarAprovadores(_pessoa.GetAll());  
        }


        public Pessoa ObterPessoa(Pessoa pessoa)
        {
            return _pessoa.ObterAdministrador(pessoa);
        }
    }
}
