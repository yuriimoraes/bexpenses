

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class DespesaCarroAppService : AppServiceBase<DespesaCarro>, IDespesaCarroAppService
    {
        private readonly IDespesaCarroService _despesaCarro;

        public DespesaCarroAppService(IDespesaCarroService despesaCarro)
            : base(despesaCarro)
        {
            _despesaCarro = despesaCarro;
        }
    }
}
