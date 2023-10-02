using System;
using System.Collections.Generic;

namespace CyberGear16.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public int Dni { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Usuario1 { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public int PerfilId { get; set; }

    public int? DomicilioId { get; set; }

    public long? Tel { get; set; }

    public DateOnly Fecha { get; set; }

    public string Sexo { get; set; } = null!;

    public string Baja { get; set; } = null!;

    public virtual Domicilio? Domicilio { get; set; }

    public virtual TiposUsuario Perfil { get; set; } = null!;
}
