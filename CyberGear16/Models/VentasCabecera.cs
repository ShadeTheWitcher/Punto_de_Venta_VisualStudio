using System;
using System.Collections.Generic;

namespace CyberGear16.Models;

public partial class VentasCabecera
{
    public int Id { get; set; }

    public DateOnly Fecha { get; set; }

    public int IdCliente { get; set; }

    public double TotalVenta { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual ICollection<VentasDetalle> VentasDetalles { get; set; } = new List<VentasDetalle>();
}
