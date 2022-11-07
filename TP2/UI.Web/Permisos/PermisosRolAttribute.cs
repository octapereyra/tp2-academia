using Business.Entities;
using Business.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Business.Entities.Persona;

namespace UI.Web.Permisos
{
    public class PermisosRolAttribute : ActionFilterAttribute
    {
        private TiposPersonas _tipoPersona;

        public PermisosRolAttribute(TiposPersonas tipoPersona)
        {
            _tipoPersona = tipoPersona;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Session.GetInt32("userId") != null)
            {
                Usuario user = new UsuarioLogic().GetOne((int)context.HttpContext.Session.GetInt32("userId"));
                Persona persona = new PersonaLogic().GetOne(user.IdPersona);
                if (persona.TipoPersona != this._tipoPersona)
                {
                    context.Result = new RedirectResult("~/Home/Index");
                }
            }

            base.OnActionExecuting(context);
        }
    }
}
