using System.Linq;
using Blog.Dominio;
using Blog.Dominio.Interface;
using Blog.Infra.Interface;
using Blog.Servico.Interface;

namespace Blog.Servico
{
    public class ComentarioServico : BaseServico<Comentario>, IComentarioServico
    {
        private readonly IComentarioRepositorio comentarioRepositorio;
        private readonly IUnitOfWork unitOfWork;

        public ComentarioServico(IComentarioRepositorio comentarioRepositorio, IUnitOfWork unitOfWork)
            : base(comentarioRepositorio, unitOfWork)
        {
            this.comentarioRepositorio = comentarioRepositorio;
            this.unitOfWork = unitOfWork;
        }

        public IQueryable<Comentario> ConsultarPorPublicacao(int idPublicacao)
        {
            return comentarioRepositorio.ConsultarPorPublicacao(idPublicacao);
        }
    }
}
