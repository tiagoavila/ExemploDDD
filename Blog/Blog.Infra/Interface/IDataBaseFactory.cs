using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Blog.Infra.Interface
{
    public interface IDataBaseFactory
    {
        DbContext Get();
    }
}
