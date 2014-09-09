using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Servico.Interface
{
    public interface IBaseServico<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int Id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Func<T, object> order, int pageSize, int pageIndex, out int totalPages);
    }
}
