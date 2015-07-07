

using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class ParametrosSistemaService : ServiceBase<ParametrosSistema>, IParametrosSistemaService
    {
        private readonly IRepositoryParametrosSistema _repositoryParametrosSistema;

        public ParametrosSistemaService(IRepositoryParametrosSistema repositoryParametrosSistema)
            : base(repositoryParametrosSistema)
        {
            _repositoryParametrosSistema = repositoryParametrosSistema;
        }
    }
}
