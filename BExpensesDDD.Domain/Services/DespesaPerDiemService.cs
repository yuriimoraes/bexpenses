

using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Domain.Interfaces;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Domain.Services
{
    public class DespesaPerDiemService : ServiceBase<DespesaPerDiem>, IDespesaPerDiemService
    {
        private readonly IRepositoryDespesaPerDiem _repositoryDespesaPerDiem;

        public DespesaPerDiemService(IRepositoryDespesaPerDiem repositoryDespesaPerDiem)
            : base(repositoryDespesaPerDiem)
        {
            _repositoryDespesaPerDiem = repositoryDespesaPerDiem;
        }
    }
}
