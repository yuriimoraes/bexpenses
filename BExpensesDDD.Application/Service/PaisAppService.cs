

using System.Collections.Generic;
using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class PaisAppService : AppServiceBase<Pais>, IPaisAppService
    {
        private readonly IPaisService _pais;

        public PaisAppService(IPaisService pais)
            : base(pais)
        {
            _pais = pais;
        }

        public IEnumerable<Pais> BuscarNomePais(string nome)
        {
            return _pais.BuscarNomePais(nome);
        }
    }
}
