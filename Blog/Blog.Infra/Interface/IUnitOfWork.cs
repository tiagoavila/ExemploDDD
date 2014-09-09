using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Infra.Interface
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
