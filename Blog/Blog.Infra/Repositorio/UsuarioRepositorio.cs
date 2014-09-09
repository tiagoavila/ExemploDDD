using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blog.Dominio;
using Blog.Dominio.Interface;
using Blog.Infra.Interface;

namespace Blog.Infra.Repositorio
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(IDataBaseFactory dataBaseFactory)
            : base(dataBaseFactory)
        {

        }

        public Usuario Consultar(int idUsuario)
        {
            return base.Get(x => x.Id == idUsuario);
        }


        public Usuario Consultar(string email, string senha)
        {
            return base.Get(x => x.Email == email && x.Senha == senha);
        }
    }
}
