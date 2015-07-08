

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class DespesaTransporteAppService : AppServiceBase<DespesaTransporte>, IDespesaTransporteAppService
    {
        private readonly IDespesaTransporteService _despesaTransporte;

        public DespesaTransporteAppService(IDespesaTransporteService despesaTransporte)
            : base(despesaTransporte)
        {
            _despesaTransporte = despesaTransporte;
        }
    }
}
