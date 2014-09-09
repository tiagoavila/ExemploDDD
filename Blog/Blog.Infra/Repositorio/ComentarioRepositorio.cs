using System.Linq;
using Blog.Dominio;
using Blog.Dominio.Interface;
using Blog.Infra.Interface;

namespace Blog.Infra.Repositorio
{
    public class ComentarioRepositorio : BaseRepositorio<Comentario>, IComentarioRepositorio
    {
        public ComentarioRepositorio(IDataBaseFactory dataBaseFactory)
            : base(dataBaseFactory)
        {

        }

        public IQueryable<Comentario> ConsultarPorPublicacao(int idPublicacao)
        {
            return base.GetMany(x => x.Publicacao.Id == idPublicacao);
        }
    }
}
