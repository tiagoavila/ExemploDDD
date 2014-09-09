using System;
using System.Web.Mvc;
using Blog.Dominio;
using Blog.Servico.Interface;
using Blog.Util;

namespace Blog.Controllers
{
    public class PostsController : Controller
    {
        private readonly IUsuarioServico usuarioServico;
        private readonly IPublicacaoServico publicacaoServico;

        public PostsController(IUsuarioServico usuarioServico, IPublicacaoServico publicacaoServico)
        {
            this.usuarioServico = usuarioServico;
            this.publicacaoServico = publicacaoServico;
        }

        //
        // GET: /Posts/

        public ActionResult Index()
        {
            return View();
        }

        //
        //GET: /Posts/Cadastrar

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Publicacao publicacao)
        {
            publicacao.Usuario = usuarioServico.Consultar(Convert.ToInt32(User.Identity.Name));

            publicacaoServico.Add(publicacao);

            return RedirectToAction("Cadastrar").ComMensagem("Post Cadastrado com sucesso!!!");
        }
    }
}
