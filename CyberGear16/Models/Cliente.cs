using System;
using System.Collections.Generic;

namespace CyberGear16.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int Dni { get; set; }

    public int DomicilioId { get; set; }

    public string Email { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string Sexo { get; set; } = null!;

    public long Telefono { get; set; }

    public string Baja { get; set; } = null!;

    public virtual Domicilio Domicilio { get; set; } = null!;

    public virtual ICollection<VentasCabecera> VentasCabeceras { get; set; } = new List<VentasCabecera>();
}
