using Blog.Dominio;
using Blog.Dominio.Interface;
using Blog.Infra.Interface;
using Blog.Servico.Interface;

namespace Blog.Servico
{
    public class PublicacaoServico : BaseServico<Publicacao>, IPublicacaoServico
    {
        private readonly IPublicacaoRepositorio publicacaoRepositorio;
        private readonly IUnitOfWork unitOfWork;

        public PublicacaoServico(IPublicacaoRepositorio publicacaoRepositorio, IUnitOfWork unitOfWork)
            : base(publicacaoRepositorio, unitOfWork)
        {
            this.publicacaoRepositorio = publicacaoRepositorio;
            this.unitOfWork = unitOfWork;
        }

        public Publicacao Consultar(int idPublicacao)
        {
            return publicacaoRepositorio.Consultar(idPublicacao);
        }
    }
}
