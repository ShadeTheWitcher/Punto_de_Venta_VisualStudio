using System;
using System.Collections.Generic;

namespace CyberGear16.Models;

public partial class Domicilio
{
    public int Id { get; set; }

    public string Direccion { get; set; } = null!;

    public int CodPostal { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
