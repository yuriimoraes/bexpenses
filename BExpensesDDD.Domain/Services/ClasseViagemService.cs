

using System.Collections.Generic;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class ClasseViagemService : ServiceBase<ClasseViagem>, IClasseViagemService
    {
        private readonly IRepositoryClasseViagem _repositoryClasseViagem;

        public ClasseViagemService(IRepositoryClasseViagem repositoryClasseViagem)
            : base(repositoryClasseViagem)
        {
            _repositoryClasseViagem = repositoryClasseViagem;
        }

        public IEnumerable<ClasseViagem> BuscarNomeClasseViagem(string nome)
        {
            return _repositoryClasseViagem.BuscarNomeClasseViagem(nome);
        }
    }
}
