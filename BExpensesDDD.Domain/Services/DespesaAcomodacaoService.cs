
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class DespesaAcomodacaoService : ServiceBase<DespesaAcomodacao>, IDespesaAcomodacaoService
    {
        private readonly IRepositoryDespesaAcomodacao _repositoryDespesaAcomodacao;

        public DespesaAcomodacaoService(IRepositoryDespesaAcomodacao repositoryDespesaAcomodacao)
            : base(repositoryDespesaAcomodacao)
        {
            _repositoryDespesaAcomodacao = repositoryDespesaAcomodacao;
        }
    }
}
