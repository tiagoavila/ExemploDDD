using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blog.Dominio.Interface;
using System.Data.Entity;
using Blog.Infra.Interface;
using System.Linq.Expressions;
using System.Data;

namespace Blog.Infra.Repositorio
{
    public class BaseRepositorio<T> : IDisposable, IBaseRepositorio<T> where T : class
    {
        private DbContext _contexto;
        protected readonly DbSet<T> dbset;

        public BaseRepositorio(IDataBaseFactory dataBaseFactory)
        {
            DatabaseFactory = dataBaseFactory;
            dbset = getContexto.Set<T>();
        }

        protected IDataBaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        protected DbContext getContexto
        {
            get { return _contexto ?? (_contexto = DatabaseFactory.Get()); }
        }

        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }

        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            _contexto.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
        }

        public virtual T GetById(int id)
        {
            return dbset.Find(id);
        }

        public virtual IQueryable<T> GetAll()
        {
            return dbset;
        }

        public virtual IQueryable<T> GetAll(Func<T, object> order, int pageSize, int pageIndex, out int totalPages)
        {
            totalPages = dbset.Count();
            return dbset.OrderBy(order).Skip((pageIndex - 1) * pageSize).Take(pageSize).AsQueryable();
        }

        public virtual IQueryable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where);
        }

        public virtual IQueryable<T> GetMany(Expression<Func<T, bool>> where, Func<T, object> order, int pageSize, int pageIndex, out int totalPages)
        {
            totalPages = dbset.Where(where).Count();
            return dbset.Where(where).OrderBy(order).Skip((pageIndex - 1) * pageSize).Take(pageSize).AsQueryable();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }

        public int Count(Func<T, bool> where)
        {
            return dbset.Count(where);
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
