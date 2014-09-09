using Blog.Dominio;

namespace Blog.Servico.Interface
{
    public interface IUsuarioServico : IBaseServico<Usuario>
    {
        Usuario Consultar(int idUsuario);
        Usuario Consultar(string email, string senha);
    }
}
