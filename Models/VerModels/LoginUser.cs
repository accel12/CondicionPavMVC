namespace CondicionPavMVC.Models
{
	public class LoginUser
	{
		public int Id { get; set; }
		public string Nombres { get; set; }
		public string Usuario { get; set; }
		public string Clave { get; set; }
		public string Apellidos { get; set; }

		public virtual ICollection<Proyecto> Proyectos { get; set; } = new List<Proyecto>();
	}
}
