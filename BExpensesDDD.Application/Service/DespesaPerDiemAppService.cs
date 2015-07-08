

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class DespesaPerDiemAppService : AppServiceBase<DespesaPerDiem>, IDespesaPerDiemAppService
    {
        private readonly IDespesaPerDiemService _despesaPerDiem;

        public DespesaPerDiemAppService(IDespesaPerDiemService despesaPerDiem)
            :base(despesaPerDiem)
        {
            _despesaPerDiem = despesaPerDiem;
        }
    }
}
