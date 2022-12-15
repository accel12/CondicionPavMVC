namespace CondicionPavMVC.Models
{
	public class LoginUser
	{
		public int Id { get; set; }
		public string Usuario { get; set; } = null!;

		public string Clave { get; set; } = null!;
	}
}
