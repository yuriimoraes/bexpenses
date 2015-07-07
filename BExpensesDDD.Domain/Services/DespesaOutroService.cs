

using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class DespesaOutroService : ServiceBase<DespesaOutro>, IDespesaOutroService
    {
        private readonly IRepositoryDespesaOutro _repositoryDespesaOutro;

        public DespesaOutroService(IRepositoryDespesaOutro repositoryDespesaOutro)
            : base(repositoryDespesaOutro) 
        {
            _repositoryDespesaOutro = repositoryDespesaOutro;
        }
    }
}
