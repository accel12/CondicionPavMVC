using CondicionPavMVC.Models;
using CondicionPavMVC.Utilidades;
using CondicionPavMVC.Permisos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Web;
using Microsoft.Extensions.Caching.Memory;

namespace CondicionPavMVC.Controllers
{
    public class LoginController : Controller
    {
		private readonly IMemoryCache _memoryCache;

        public LoginController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
		public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginUser oLoginUser)
        {
            
		    LoginFunciones login = new LoginFunciones(oLoginUser);
            Usuario usuarioCompleto = login.VerificarUsuario();
            LoginUser usuarioGuardar = new LoginUser();

			if (usuarioCompleto != null)
            {
                usuarioGuardar.Id = usuarioCompleto.UserId;
                usuarioGuardar.Nombres = usuarioCompleto.Nombres;
                usuarioGuardar.Apellidos = usuarioCompleto.Apellidos;
                usuarioGuardar.Proyectos = usuarioCompleto.Proyectos;
    //            CookieOptions cookies = new CookieOptions();
    //            string usuarioSerializado = JsonConvert.SerializeObject(usuarioGuardar);
                
				//Response.Cookies.Append("usuario", JsonConvert.SerializeObject(usuarioGuardar),cookies);

                _memoryCache.Set<LoginUser>("usuario", usuarioGuardar);

                return RedirectToAction("Ver", "Proyecto");

			}
            else
            {
                ViewData["Mensaje"]= "Usuario o contraseña invalida";
				return View(oLoginUser);
			}
            
        }
    }
}
