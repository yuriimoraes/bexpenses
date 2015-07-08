

using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class DespesaPrincipalAppService : AppServiceBase<DespesaPrincipal>, IDespesaPrincipalAppService
    {
        private readonly IDespesaPrincipalService _despesaPrincipal;

        public DespesaPrincipalAppService(IDespesaPrincipalService despesaPrincipal)
            : base(despesaPrincipal)
        {
            _despesaPrincipal = despesaPrincipal;
        }
    }
}
