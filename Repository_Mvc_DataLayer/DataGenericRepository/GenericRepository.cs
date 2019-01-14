using System;
using System.Collections.Generic;
using System.Linq;
using Repository_Mvc_DataLayer.DataContext;

namespace Repository_Mvc_DataLayer.DataGenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T>, IDisposable  where T : class {

        private DataDbContext _dataDbContext;

        public GenericRepository()
        {
            _dataDbContext = new DataDbContext();
        }
        public void Add(T entity)
        {
            _dataDbContext.Set<T>().Add(entity);
        }

        public void Commit()
        {
            _dataDbContext.SaveChanges();
        }

        public void Delete(Func<T, bool> predicate)
        {
            _dataDbContext.Set<T>().Where(predicate).ToList().ForEach(del => _dataDbContext.Set<T>().Remove(del));
        }

        public void Dispose()
        {
            if(_dataDbContext != null)
            {
                _dataDbContext.Dispose();
            }
            GC.SuppressFinalize(this);
          
        }

        public T Find(params object[] key)
        {
           return _dataDbContext.Set<T>().Find(key);
        }

        public T Fist(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dataDbContext.Set<T>().Where(predicate).FirstOrDefault();
        }

        public IQueryable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dataDbContext.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _dataDbContext.Set<T>();
        }

        public void Update(T entity)
        {
            _dataDbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
 
}
