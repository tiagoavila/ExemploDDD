using Blog.Dominio;
using Blog.Dominio.Interface;
using Blog.Infra.Interface;

namespace Blog.Infra.Repositorio
{
    public class PublicacaoRepositorio : BaseRepositorio<Publicacao>, IPublicacaoRepositorio
    {
        public PublicacaoRepositorio(IDataBaseFactory dataBaseFactory)
            : base(dataBaseFactory)
        {

        }

        public Publicacao Consultar(int idPublicacao)
        {
            return base.Get(x => x.Id == idPublicacao);
        }
    }
}
