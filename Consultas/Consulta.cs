using CondicionPavMVC.Models;
using CondicionPavMVC.Utilidades;
using System.Collections;
using System.Text;

namespace CondicionPavMVC.Consultas
{
    public class Consulta
	{

		public static Usuario validarCredenciales(LoginUser oLoginUser)
		{
			using (var context = new CondicionPavDbContext())
			{
				var user = context.Usuarios.Where(us => us.Usuario1 == oLoginUser.Usuario).ToList();
				
				if (user.Count() > 0)
				{
					string claveDesencriptada = System.Text.Encoding.UTF8.GetString(user[0].Clave);
					if(oLoginUser.Clave == claveDesencriptada)
					{
						return user[0];
					}
				}
				return null;
			}
			
		}

		// PROYECTO CRUD
		public static bool crearProyecto(Proyecto oProyecto)
		{
			try
			{
				using (var context = new CondicionPavDbContext())
				{
					Proyecto proyecto= new Proyecto();
					proyecto.Tramo = oProyecto.Tramo;
					proyecto.Nombre = oProyecto.Nombre;
					proyecto.UsuarioId = us
					context.Proyectos.Add(oProyecto);
					context.SaveChanges();
				}
				return true;
			}
			catch(Exception ex)
			{
				return false;
			}
			
		}

		public static void editarProyecto(int usuarioID)
		{

		}
		public static void eliminarProyecto(int usuarioID)
		{

		}

		public static List<Proyecto> obtenerProyectos(int usuarioID)
		{
			List<Proyecto> listaProyectos=new List<Proyecto>();
			using (var context = new CondicionPavDbContext())
			{
				var proyectos = context.Proyectos.Where(us => us.UsuarioId == usuarioID).ToList();
				
				
			}
			return listaProyectos;
		}

		// PROYECTO Carril CRUD
		public static void crearCarrilProyecto(int usuarioID)
		{

		}
		public static void editarCarrilProyecto(int usuarioID)
		{

		}
		public static void eliminarCarrilProyecto(int usuarioID)
		{

		}
	}
}
