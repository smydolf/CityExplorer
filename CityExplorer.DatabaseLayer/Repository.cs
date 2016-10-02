using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Linq.Expressions;

namespace CityExplorer.DatabaseLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private CityExplorerContext Context { get; set; } = new CityExplorerContext();
        protected DbSet DbSet { get; set; }
        public Repository()
        {
            DbSet = Context.Set<T>();
        }
        public T AddEntity(T entity)
        {
            return DbSet.Add(entity) as T;
        }
        public T DeleteEntity(T entity)
        {
            return (T)DbSet.Remove(entity);
        }
        public IEnumerable<T> GetList()
        {
            IEnumerable<T> query = Context.Set<T>();
            return query;
        }
        public IQueryable<T> GetList(Expression<Func<T, bool>> query)
        {
            throw new NotImplementedException();//TODO
        }
        public T GetEntityById(int primaryKey)
        {
            return (T)DbSet.Find(primaryKey);
        }
        public void EditEntity(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }
        public void SaveChange()
        {
            Context.SaveChanges();
        }
    }
}

