

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class TaxaCambioAppService : AppServiceBase<TaxaCambio>, ITaxaCambioAppService
    {
        private readonly ITaxaCambioService _taxaCambio;

        public TaxaCambioAppService(ITaxaCambioService taxaCambio)
            :base(taxaCambio)
        {
            _taxaCambio = taxaCambio;
        }
    }
}
