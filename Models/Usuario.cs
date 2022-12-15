using System;
using System.Collections.Generic;

namespace CondicionPavMVC.Models;

public partial class Usuario
{
    public int UserId { get; set; }

    public string Usuario1 { get; set; } = null!;

    public byte[] Clave { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public virtual ICollection<Proyecto> Proyectos { get; } = new List<Proyecto>();
}
