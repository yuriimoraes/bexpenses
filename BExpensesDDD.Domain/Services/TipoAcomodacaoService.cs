

using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class TipoAcomodacaoService : ServiceBase<TipoAcomodacao>, ITipoAcomodacaoService
    {
        private readonly IRepositoryTipoAcomodacao _repositoryTipoAcomodacao;

        public TipoAcomodacaoService(IRepositoryTipoAcomodacao repositoryTipoAcomodacao)
            : base(repositoryTipoAcomodacao)
        {
            _repositoryTipoAcomodacao = repositoryTipoAcomodacao;
        }
    }
}
