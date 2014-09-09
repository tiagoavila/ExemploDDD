using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blog.Infra.Interface;
using System.Data.Entity;

namespace Blog.Infra.InfraEstrutura
{
    public class DataBaseFactory : IDataBaseFactory
    {
        public BlogContexto _contexto { get; set; }

        public DbContext Get()
        {
            return _contexto ?? (_contexto = new BlogContexto());
        }
    }
}
