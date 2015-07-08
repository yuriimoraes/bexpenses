

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class TipoViagemAppService : AppServiceBase<TipoViagem>, ITipoViagemAppService
    {
        private readonly ITipoViagemService _tipoViagem;

        public TipoViagemAppService(ITipoViagemService tipoViagem)
            :base(tipoViagem)
        {
            _tipoViagem = tipoViagem;
        }
    }
}
