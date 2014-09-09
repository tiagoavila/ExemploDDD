using System.Linq;
using Blog.Dominio;

namespace Blog.Servico.Interface
{
    public interface IComentarioServico : IBaseServico<Comentario>
    {
        IQueryable<Comentario> ConsultarPorPublicacao(int idPublicacao);
    }
}
