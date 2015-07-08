

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class DespesaOutroAppService : AppServiceBase<DespesaOutro>, IDespesaOutroAppService
    {
        private readonly IDespesaOutroService _despesaOutro;

        public DespesaOutroAppService(IDespesaOutroService despesaOutro)
            : base(despesaOutro)
        {
            _despesaOutro = despesaOutro;
        }
    }
}
