using System;
using System.Collections.Generic;

namespace CyberGear16.Models;

public partial class TiposUsuario
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
