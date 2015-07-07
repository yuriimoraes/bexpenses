
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class TipoViagemService : ServiceBase<TipoViagem>, ITipoViagemService
    {
        private readonly IRepositoryTipoViagem _repositoryTipoViagem;

        public TipoViagemService(IRepositoryTipoViagem repositoryTipoViagem)
            : base(repositoryTipoViagem)
        {
            _repositoryTipoViagem = repositoryTipoViagem;
        }
    }
}
