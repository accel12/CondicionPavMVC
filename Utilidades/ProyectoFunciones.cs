using CondicionPavMVC.Models;
using CondicionPavMVC.Consultas;
namespace CondicionPavMVC.Utilidades
{
	public class ProyectoFunciones
	{
		private int usuarioID;
		
		public ProyectoFunciones(LoginUser oLoginUser) {
			this.usuarioID = oLoginUser.Id;
		}
		// CRUD PROYECTOS
		public bool crearProyecto(Proyecto oProyecto)
		{
			bool resultado=false;
			if(Consulta.crearProyecto(oProyecto) == true)
			{
				resultado=true;
			}
			return resultado;
		}
		public void editarProyecto()
		{

		}
		public void eliminarProyecto()
		{

		}
		public List<Proyecto> obtenerProyectos() {
			List<Proyecto> proyectos = Consulta.obtenerProyectos(this.usuarioID);
			return proyectos;
		}

		// CRUD CarrilesPROYECTO
	}
}
