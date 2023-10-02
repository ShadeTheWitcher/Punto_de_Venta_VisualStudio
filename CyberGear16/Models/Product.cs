using System;
using System.Collections.Generic;

namespace CyberGear16.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? NombreProducto { get; set; }

    public double? PrecioProducto { get; set; }

    public string? Descripcion { get; set; }

    public int CategoriaId { get; set; }

    public int Cantidad { get; set; }

    public string Activo { get; set; } = null!;

    public virtual ICollection<VentasDetalle> VentasDetalles { get; set; } = new List<VentasDetalle>();
}
