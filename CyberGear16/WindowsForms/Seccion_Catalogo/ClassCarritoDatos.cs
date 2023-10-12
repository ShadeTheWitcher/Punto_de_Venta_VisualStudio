using CyberGear16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberGear16.WindowsForms.Seccion_Catalogo
{
    public static class ClassCarritoDatos
    {
        // Puedes definir aquí las variables que quieras compartir entre formularios
        public static List<Product> ProductosEnCarrito { get; set; } = new List<Product>();

        // Agrega otras variables según sea necesario


        public static void AgregarProducto(Product producto)
        {
            ProductosEnCarrito.Add(producto);
        }
    }
}
