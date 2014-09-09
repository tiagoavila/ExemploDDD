using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System.Web.Mvc
{
    public static class MVCExtensoes
    {
        public static string HoverController(this HtmlHelper helper, string controller)
        {
            if (helper.ViewContext.RouteData.Values["controller"].Equals(controller))
                return "active";
            return string.Empty;
        }

        public static string HoverAction(this HtmlHelper helper, string action)
        {
            string[] actions = action.Split(',');
            foreach (string item in actions)
            {
                if (helper.ViewContext.RequestContext.RouteData.Values["action"].Equals(item))
                    return "active";
            }
            return string.Empty;
        }

        public static string HoverUrl(this HtmlHelper helper, string url)
        {
            string rotaAtual = helper.ViewContext.RouteData.GetRequiredString("controller").ToString() + "/" +
                               helper.ViewContext.RouteData.GetRequiredString("action").ToString();
            if (url.Equals(rotaAtual))
                return "active";
            return string.Empty;
        }
    }
}