
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class DespesaTransporteService : ServiceBase<DespesaTransporte>, IDespesaTransporteService
    {
        private readonly IRepositoryDespesaTransporte _repositoryDespesaTransporte;

        public DespesaTransporteService(IRepositoryDespesaTransporte repositoryDespesaTransporte)
            : base (repositoryDespesaTransporte)
        {
            _repositoryDespesaTransporte = repositoryDespesaTransporte;
        }
    }
}
