namespace Blog.Dominio.Interface
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario Consultar(int idUsuario);
        Usuario Consultar(string email, string senha);
    }
}
