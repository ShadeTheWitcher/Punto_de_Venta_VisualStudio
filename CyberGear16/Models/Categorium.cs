using System;
using System.Collections.Generic;

namespace CyberGear16.Models;

public partial class Categorium
{
    public int IdCategoria { get; set; }

    public string CategoriaNombre { get; set; } = null!;

    public string Activo { get; set; } = null!;
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
