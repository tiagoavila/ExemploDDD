using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Dominio.Interface
{
    public interface IPublicacaoRepositorio : IBaseRepositorio<Publicacao>
    {
        Publicacao Consultar(int idPublicacao);
    }
}
