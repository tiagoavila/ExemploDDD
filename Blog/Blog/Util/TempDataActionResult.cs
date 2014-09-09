using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Util
{
    public class TempDataActionResult : ActionResult
    {
        private readonly ActionResult _actionResult;
        private readonly string _mensagem;

        public TempDataActionResult(ActionResult actionResult, string mensagem)
        {
            _actionResult = actionResult;
            _mensagem = mensagem;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            context.Controller.TempData["Mensagem"] = _mensagem;
            _actionResult.ExecuteResult(context);
        }
    }
}