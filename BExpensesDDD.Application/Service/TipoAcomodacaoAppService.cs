

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class TipoAcomodacaoAppService : AppServiceBase<TipoAcomodacao>, ITipoAcomodacaoAppService
    {
        private readonly ITipoAcomodacaoService _tipoAcomodacao;

        public TipoAcomodacaoAppService(ITipoAcomodacaoService tipoAcomodacao)
            : base(tipoAcomodacao)
        {
            _tipoAcomodacao = tipoAcomodacao;
        }
    }
}
