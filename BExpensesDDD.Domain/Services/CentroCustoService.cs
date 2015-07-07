
using System.Collections.Generic;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class CentroCustoService : ServiceBase<CentroCusto>, ICentroCustoService
    {
        private readonly IRepositoryCentroCusto _repositoryCentroCusto;

        public CentroCustoService(IRepositoryCentroCusto repositoryCentroCusto)
            : base(repositoryCentroCusto)
        {
            _repositoryCentroCusto = repositoryCentroCusto;
        }

        public IEnumerable<CentroCusto> BuscarNomeCentroCusto(string nome)
        {
            return _repositoryCentroCusto.BuscarNomeCentroCusto(nome);
        }
    }
}
