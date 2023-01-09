using CondicionPavMVC.Models;
using CondicionPavMVC.Permisos;
using CondicionPavMVC.Utilidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching;
using Microsoft.Extensions.Caching.Memory;

namespace CondicionPavMVC.Controllers
{
    [ValidarSesionFilter]
	public class ProyectoController : Controller
	{
		private readonly IMemoryCache _memoryCache;
		public ProyectoController(IMemoryCache memoryCache)
		{
			_memoryCache = memoryCache;
		}
		public IActionResult Ver()
		{
			LoginUser user = _memoryCache.Get<LoginUser>("usuario");
			ProyectoFunciones proyectos = new ProyectoFunciones(user);

			List<Proyecto> listaProyectos= proyectos.obtenerProyectos();

			return View(listaProyectos);
		}

		[HttpPost]
		public void Crear(Proyecto oProyecto)
		{
			LoginUser user = _memoryCache.Get<LoginUser>("usuario");
			bool resp = false;
			ProyectoFunciones proyectoFunciones = new ProyectoFunciones(user);
			resp = proyectoFunciones.crearProyecto(oProyecto);
			Response.Redirect(nameof(Ver));
		}
		public IActionResult Editar()
		{
			return View();
		}
	}
}
