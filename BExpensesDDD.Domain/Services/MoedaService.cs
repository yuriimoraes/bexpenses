

using System.Collections.Generic;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class MoedaService : ServiceBase<Moeda>, IMoedaService
    {
        private readonly IRepositoryMoeda _repositoryMoeda;

        public MoedaService(IRepositoryMoeda repositoryMoeda)
            : base (repositoryMoeda)
        {
            _repositoryMoeda = repositoryMoeda;
        }

        public IEnumerable<Moeda> BuscarNomeMoeda(string nome)
        {
            return _repositoryMoeda.BuscarNomeMoeda(nome);
        }
    }
}
