using CondicionPavMVC.Models;
using CondicionPavMVC.Utilidades;
using Microsoft.AspNetCore.Mvc;

namespace CondicionPavMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginUser oLoginUser)
        {
            LoginFunciones login = new LoginFunciones(oLoginUser);
            Usuario usuarioCompleto = login.VerificarUsuario();
            if(usuarioCompleto != null)
            {

                //Session["usuario"]=
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
