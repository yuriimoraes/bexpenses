
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class DespesaPrincipalService : ServiceBase<DespesaPrincipal>, IDespesaPrincipalService
    {
        private readonly IRepositoryDespesaPrincipal _repositoryDespesaPrincipal;
        public DespesaPrincipalService(IRepositoryDespesaPrincipal repositoryDespesaPrincipal)
            : base(repositoryDespesaPrincipal)
        {
            _repositoryDespesaPrincipal = repositoryDespesaPrincipal;
        }
    }
}
