

using System.Collections.Generic;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class PaisService : ServiceBase<Pais>, IPaisService
    {
        private readonly IRepositoryPais _repositoryPais;

        public PaisService(IRepositoryPais repositoryPais)
            : base(repositoryPais)
        {
            _repositoryPais = repositoryPais;
        }

        public IEnumerable<Pais> BuscarNomePais(string nome)
        {
            return _repositoryPais.BuscarNomePais(nome);
        }
    }
}
