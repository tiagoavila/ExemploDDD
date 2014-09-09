using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blog.Infra.Interface;

namespace Blog.Infra.InfraEstrutura
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDataBaseFactory databaseFactory;
        private BlogContexto dataContext;

        public UnitOfWork(IDataBaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        protected BlogContexto DataContext
        {
            get { return dataContext ?? (dataContext = (BlogContexto)databaseFactory.Get()); }
        }

        public void Commit()
        {
            DataContext.Commit();
        }
    }
}
