

using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class TaxaCambioService : ServiceBase<TaxaCambio>, ITaxaCambioService
    {
        private readonly IRepositoryTaxaCambio _repositoryTaxaCambio;

        public TaxaCambioService(IRepositoryTaxaCambio repositoryTaxaCambio)
            : base(repositoryTaxaCambio)
        {
            _repositoryTaxaCambio = repositoryTaxaCambio;
        }
    }
}
