using System;
using System.Collections.Generic;

namespace CondicionPavMVC.Models;

public partial class Proyecto
{
    public int ProyectoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Tramo { get; set; } = null!;

    public int CarrilId { get; set; }

    public int UsuarioId { get; set; }

    public virtual ICollection<Carrile> Carriles { get; } = new List<Carrile>();

    public virtual Usuario Usuario { get; set; } = null!;
}
