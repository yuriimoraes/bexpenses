using System.Collections.Generic;
using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class CentroCustoAppService : AppServiceBase<CentroCusto>, ICentroCustoAppService
    {
        private readonly ICentroCustoService _centroCusto;

        public CentroCustoAppService(ICentroCustoService centroCusto)
            : base(centroCusto)
        {
            _centroCusto = centroCusto;
        }

        public IEnumerable<CentroCusto> BuscarNomeCentroCusto(string nome)
        {
            return _centroCusto.BuscarNomeCentroCusto(nome);
        }
    }
}
