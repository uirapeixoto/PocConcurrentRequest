using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ConcurrentRequest.Infra.Contrato
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Remove(int id);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}
