using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CyberGear16.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? NombreProducto { get; set; }

    public double? PrecioProducto { get; set; }

    public string? Descripcion { get; set; }

    public int CategoriaId { get; set; }

    public int Cantidad { get; set; }

    public int StockMinimo { get; set; }

    public byte[]? Imagen { get; set; }

    public string Activo { get; set; } = null!;





    public virtual ICollection<VentasDetalle> VentasDetalles { get; set; } = new List<VentasDetalle>();

    // Nueva propiedad para almacenar la cantidad que se quiere comprar
    [NotMapped] //no afecta a la base de datos
    public int CantEnCart { get; set; }


}
