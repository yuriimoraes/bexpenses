

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class DespesaCarroAluguelAppService : AppServiceBase<DespesaCarroAluguel>, IDespesaCarroAluguelAppService
    {
        private readonly IDespesaCarroAluguelService _despesaCarroAluguel;

        public DespesaCarroAluguelAppService(IDespesaCarroAluguelService despesaCarroAluguel)
            : base(despesaCarroAluguel)
        {
            _despesaCarroAluguel = despesaCarroAluguel;
        }
    }
}
