using System;
using System.Collections.Generic;
using System.Linq;
using Blog.Servico.Interface;
using Blog.Dominio.Interface;
using Blog.Infra.Interface;

namespace Blog.Servico
{
    public class BaseServico<T>: IBaseServico<T> where T : class
    {
        private readonly IBaseRepositorio<T> baseRepositorio;
        private readonly IUnitOfWork unitOfWork;

        public BaseServico(IBaseRepositorio<T> baseRepositorio, IUnitOfWork unitOfWork)
        {
            this.baseRepositorio = baseRepositorio;
            this.unitOfWork = unitOfWork;
        }

        public void Add(T entity)
        {
            baseRepositorio.Add(entity);
            unitOfWork.Commit();
        }

        public void Update(T entity)
        {
            baseRepositorio.Update(entity);
            unitOfWork.Commit();
        }

        public void Delete(T entity)
        {
            baseRepositorio.Delete(entity);
            unitOfWork.Commit();
        }

        public T GetById(int Id)
        {
            return baseRepositorio.GetById(Id);
        }

        public IEnumerable<T> GetAll()
        {
            return baseRepositorio.GetAll().ToList();
        }

        public IEnumerable<T> GetAll(Func<T, object> order, int pageSize, int pageIndex, out int totalPages)
        {
            return baseRepositorio.GetAll(order, pageSize, pageIndex, out totalPages).ToList();
        }
    }
}
