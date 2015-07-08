

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class TipoDespesaCarroAppService : AppServiceBase<TipoDespesaCarro>, ITipoDespesaCarroAppService
    {
        private readonly ITipoDespesaCarroService _tipoDespesaCarro;

        public TipoDespesaCarroAppService(ITipoDespesaCarroService tipoDespesaCarro)
            : base(tipoDespesaCarro)
        {
            _tipoDespesaCarro = tipoDespesaCarro;
        }
    }
}
