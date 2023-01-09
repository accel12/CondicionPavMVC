namespace CondicionPavMVC.Models.CrearModels
{
	public class ProyectoRegister
	{
		public int ProyectoId { get; set; }

		public string Nombre { get; set; } = null!;

		public string Tramo { get; set; } = null!;

		public int CarrilId { get; set; }

		public int UsuarioId { get; set; }

		public virtual Usuario Usuario { get; set; } = null!;
	}
}
