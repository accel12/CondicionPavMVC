using CondicionPavMVC.Models;
using CondicionPavMVC.Utilidades;
using System.Collections;
using System.Text;

namespace CondicionPavMVC.Consultas
{
	public class Consultas
	{
		public Consultas()
		{
			
		}
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
						Session[]
						return user[0];
					}
				}
				return null;
			}
			
		}
	}
}
