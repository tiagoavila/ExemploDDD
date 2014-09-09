using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Blog.Dominio;
using Blog.Servico.Interface;
using System.Web.Mvc;
using System.Net;

namespace Blog.Provider
{
    public class RoleBlogProvider : RoleProvider
    {
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            IUsuarioServico usuarioServico = DependencyResolver.Current.GetService<IUsuarioServico>();
            List<string> roles = new List<string>();
            Usuario usuario = usuarioServico.Consultar(Convert.ToInt32(username));
            roles.Add("Administrador");
            //Cookie.SetCookie("pref", "Nome", (usuario.Id.ToString()));

            return roles.ToArray();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}