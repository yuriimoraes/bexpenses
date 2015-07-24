using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using BExpensesDDD.Infra.Data.Contexto;

namespace BExpensesDDD.Infra.Data.Repositories
{
    public class RepositoryPessoa : RepositoryBase<Pessoa>, IRepositoryPessoa
    {
       
        public IEnumerable<Pessoa> BuscarNomePessoa(string nome)
        {
            return Db.Pessoas.Where(p => p.Nome == nome);
        }

        public IEnumerable<Pessoa> BuscarAprovadores(IEnumerable<Pessoa> pessoas)
        {
           return pessoas.Where(p => p.PessoaAprovador(p));
        }

        public Pessoa ObterAdministrador(Pessoa pessoa)
        {
            return Db.Pessoas.SingleOrDefault(p => p.Login == pessoa.Login);
        }
    }
}
