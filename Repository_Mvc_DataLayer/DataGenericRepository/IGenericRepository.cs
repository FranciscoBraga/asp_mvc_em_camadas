using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Repository_Mvc_DataLayer.DataGenericRepository
{
    public interface IGenericRepository<T> where T: class
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        T Find(params object[] key);
        T Fist(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(Func<T, bool> predicate);
        void Commit();
        void Dispose();

    }
}
