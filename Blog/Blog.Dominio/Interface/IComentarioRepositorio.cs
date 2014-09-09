using System.Linq;

namespace Blog.Dominio.Interface
{
    public interface IComentarioRepositorio : IBaseRepositorio<Comentario>
    {
        IQueryable<Comentario> ConsultarPorPublicacao(int idPublicacao);
    }
}
