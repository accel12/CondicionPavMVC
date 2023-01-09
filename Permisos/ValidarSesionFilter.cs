using CondicionPavMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Web;
namespace CondicionPavMVC.Permisos
{
    public class ValidarSesionFilter: ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			//var rspta = filterContext.HttpContext.Request.Cookies["usuario"];
			//if (rspta == null)
			//{
			//	filterContext.Result = new RedirectResult("~/");
			//}
			//user = _memoryCache.Get<LoginUser>("usuario");
			//if (user == null)
			//{
			//	filterContext.Result = new RedirectResult("~/");
			//}
			LoginUser user;
			var service =filterContext.HttpContext.RequestServices.GetService<IMemoryCache>();
			user = (LoginUser)service.Get("usuario");
			if (user == null)
			{
				filterContext.Result = new RedirectResult("~/");
			}
	}

		public override void OnActionExecuted(ActionExecutedContext filterContext)
		{
			
		}
	}
}
