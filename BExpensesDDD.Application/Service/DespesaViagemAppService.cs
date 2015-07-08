

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class DespesaViagemAppService : AppServiceBase<DespesaViagem>, IDespesaViagemAppService
    {
        private readonly IDespesaViagemService _despesaViagem;

        public DespesaViagemAppService(IDespesaViagemService despesaViagem)
            :base(despesaViagem)
        {
            _despesaViagem = despesaViagem;
        }
    }
}
