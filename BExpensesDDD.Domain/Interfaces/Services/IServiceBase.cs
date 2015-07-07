
using System.Collections.Generic;
namespace BExpensesDDD.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    { 
        void Add(TEntity obj);
        TEntity GetByID(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAllAsNoTracking();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dipose();
    }
}
