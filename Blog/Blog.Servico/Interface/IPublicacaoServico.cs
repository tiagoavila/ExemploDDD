using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blog.Dominio;

namespace Blog.Servico.Interface
{
    public interface IPublicacaoServico : IBaseServico<Publicacao>
    {
        Publicacao Consultar(int idPublicacao);
    }
}
