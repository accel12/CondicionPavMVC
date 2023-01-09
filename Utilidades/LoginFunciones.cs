using CondicionPavMVC.Consultas;
using CondicionPavMVC.Models;

namespace CondicionPavMVC.Utilidades
{
    public class LoginFunciones
	{
		private string usuario;
		private string clave;

		public LoginFunciones(LoginUser oLoginUser)
		{
			this.usuario = oLoginUser.Usuario;
			this.clave = oLoginUser.Clave;
		}

		public Usuario VerificarUsuario()
		{
			LoginUser loginUser = new LoginUser();
			loginUser.Usuario=this.usuario;
			loginUser.Clave=this.clave;
			Usuario resultado = Consultas.Consulta.validarCredenciales(loginUser) ;
			return resultado;
		}
	}
}
