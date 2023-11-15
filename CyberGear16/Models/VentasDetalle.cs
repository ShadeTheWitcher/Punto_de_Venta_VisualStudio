using System;
using System.Collections.Generic;

namespace CyberGear16.Models;

public partial class VentasDetalle
{
    public int Id { get; set; }

    public int VentaId { get; set; }

    public int ProductoId { get; set; }

    public int CantidadVenta { get; set; }

    public double Precio { get; set; }

    public double SubTotal { get; set; }

    public virtual Product Producto { get; set; } = null!;

    public virtual VentasCabecera Venta { get; set; } = null!;
}
