using System;
using System.Collections.Generic;

namespace CondicionPavMVC.Models;

public partial class Carrile
{
    public int CarrilId { get; set; }

    public string TipoCarril { get; set; } = null!;

    public string Pavimento { get; set; } = null!;

    public int ProyectoId { get; set; }

    public virtual Proyecto Proyecto { get; set; } = null!;
}
