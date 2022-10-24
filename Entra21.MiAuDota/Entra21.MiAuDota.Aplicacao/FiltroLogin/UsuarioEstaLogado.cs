﻿using Entra21.MiAuDota.Repositorio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace Entra21.MiAuDota.Aplicacao.FiltroLogin
{
    public class UsuarioEstaLogado : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var session = context.HttpContext.Session.GetString("userSession");

            if (string.IsNullOrEmpty(session))
                context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "area", "Public" }, { "controller", "Login" }, { "action", "Index" } });
            else
            {
                var user = JsonConvert.DeserializeObject<Usuario>(session);

                if (user == null)
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "area", "Public" }, { "controller", "Login" }, { "action", "Index" } });
            }

            base.OnActionExecuting(context);
        }
    }
}