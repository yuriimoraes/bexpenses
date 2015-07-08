

using System.Collections.Generic;
using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application.Service
{
    public class MoedaAppService : AppServiceBase<Moeda>, IMoedaAppService
    {
        private readonly IMoedaService _moeda;

        public MoedaAppService(IMoedaService moeda)
            :base(moeda)
        {
            _moeda = moeda;
        }

        public IEnumerable<Moeda> BuscarNomeMoeda(string nome)
        {
            return _moeda.BuscarNomeMoeda(nome);
        }
    }
}
