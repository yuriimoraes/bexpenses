
using System;
using System.Collections.Generic;
using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesDDD.Application
{
    public class AppServiceBase<TEntity> : IDisposable,IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetByID(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public IEnumerable<TEntity> GetAllAsNoTracking()
        {
            return _serviceBase.GetAllAsNoTracking();
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Dipose()
        {
            _serviceBase.Dipose();
        }

        public void Dispose()
        {
            _serviceBase.Dipose();
        }
    }
}
