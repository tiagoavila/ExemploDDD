using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Util
{
    public static class ActionResultExtensions
    {
        /// <summary>
        /// Redireciona para uma ActionResult retornando uma mensagem de confirmação para a view
        /// </summary>
        /// <param name="actionResult"></param>
        /// <param name="mensagem">Mensagem que será exibida na view</param>
        /// <returns></returns>
        public static ActionResult ComMensagem(this ActionResult actionResult, string mensagem)
        {
            return new TempDataActionResult(actionResult, mensagem);
        }
    }
}