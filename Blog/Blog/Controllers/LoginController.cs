using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Dominio;
using System.Web.Security;
using Blog.Util;

namespace Blog.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            if (Membership.ValidateUser(usuario.Email, usuario.Senha))
                return RedirectToAction("Index", "Home");
            else
                return RedirectToAction("Index").ComMensagem("E-mail e/ou senha inválidos! Tente novamente!");
        }

        //
        //GET: /Login/Sair

        public ActionResult Sair()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }

    }
}
