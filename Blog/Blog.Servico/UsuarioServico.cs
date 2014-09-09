using Blog.Servico.Interface;
using Blog.Dominio;
using Blog.Dominio.Interface;
using Blog.Infra.Interface;

namespace Blog.Servico
{
    public class UsuarioServico : BaseServico<Usuario>, IUsuarioServico
    {
        private readonly IUsuarioRepositorio usuarioRepositorio;
        private readonly IUnitOfWork unitOfWork;

        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio, IUnitOfWork unitOfWork)
            : base(usuarioRepositorio, unitOfWork)
        {
            this.usuarioRepositorio = usuarioRepositorio;
            this.unitOfWork = unitOfWork;
        }

        public Usuario Consultar(int idUsuario)
        {
            return usuarioRepositorio.Consultar(idUsuario);
        }

        /// <summary>
        /// Consulta o usuário por email e senha, utilizado para logar o usuário
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public Usuario Consultar(string email, string senha)
        {
            return usuarioRepositorio.Consultar(email, senha);
        }
    }
}
