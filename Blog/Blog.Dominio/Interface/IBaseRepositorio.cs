using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Blog.Dominio.Interface
{
    public interface IBaseRepositorio<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        T GetById(int id);
        T Get(Expression<Func<T, bool>> where);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Func<T, object> order, int pageSize, int pageIndex, out int totalPages);
        IQueryable<T> GetMany(Expression<Func<T, bool>> where);
        IQueryable<T> GetMany(Expression<Func<T, bool>> where, Func<T, object> order, int pageSize, int pageIndex, out int totalPages);
        int Count(Func<T, bool> where);
    }
}
