using Blog.Dominio;
using Blog.Servico.Interface;
using System;
using System.Web.Mvc;

namespace Blog.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IUsuarioServico usuarioServico;

        public HomeController(IUsuarioServico usuarioServico)
        {
            this.usuarioServico = usuarioServico;
        }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [ActionName("_UsuarioLogado")]
        public ActionResult UsuarioLogado()
        {
            Usuario Usuario = usuarioServico.Consultar(Convert.ToInt32(User.Identity.Name));
            return PartialView(Usuario);
        }

    }
}
