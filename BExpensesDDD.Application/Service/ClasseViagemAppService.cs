

using System.Collections.Generic;
using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class ClasseViagemAppService : AppServiceBase<ClasseViagem>, IClasseViagemAppService
    {
        private readonly IClasseViagemService _classeViagem;

        public ClasseViagemAppService(IClasseViagemService classeViagem)
            : base(classeViagem)
        {
            _classeViagem = classeViagem;
        }

        public IEnumerable<ClasseViagem> BuscarNomeClasseViagem(string nome)
        {
            return _classeViagem.BuscarNomeClasseViagem(nome);
        }
    }
}
