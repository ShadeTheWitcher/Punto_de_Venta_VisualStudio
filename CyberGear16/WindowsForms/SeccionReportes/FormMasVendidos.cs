using CyberGear16.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CyberGear16
{
    public partial class FormMasVendidos : Form
    {
        private readonly BdCybergearContext _context;
        public FormMasVendidos()
        {
            InitializeComponent();
            CBCategorias.Items.Add("Juegos");
            CBCategorias.Items.Add("Componentes");
        }

        private void CProducts_Click(object sender, EventArgs e)
        {

        }

        private void CargarProductosMasVendidos()
        {
            using (var contexto = new BdCybergearContext())
            {
                int categoriaSeleccionada = CBCategorias.SelectedIndex + 2;

                if (categoriaSeleccionada >= 2 && categoriaSeleccionada <= 4)
                {
                    var productosMasVendidos = contexto.VentasDetalles
                        .Where(detalle => detalle.Producto.CategoriaId == categoriaSeleccionada) // Filtra por la categoría seleccionada
                        .GroupBy(detalle => detalle.ProductoId)
                        .OrderByDescending(g => g.Count())
                        .Take(5) // Puedes ajustar este número según la cantidad de productos que deseas mostrar
                        .Select(g => new
                        {
                            //Key: Clave del grupo de consulta (GroupBy)
                            NombreProducto = contexto.Products.FirstOrDefault(p => p.Id == g.Key).NombreProducto,
                            CantidadVendida = g.Count()
                        })
                        .ToList();

                    // Limpia los puntos de datos existentes en el gráfico
                    CProducts.Series["Series1"].Points.Clear();

                    // Agrega los datos al gráfico
                    foreach (var producto in productosMasVendidos)
                    {
                        CProducts.Series["Series1"].Points.AddXY(producto.NombreProducto, producto.CantidadVendida);

                        // Agrega el punto de datos al gráfico
                        //var point = CProducts.Series["Series1"].Points.AddY(producto.CantidadVendida);

                        // Establece la etiqueta personalizada para el punto de datos
                        //point.Label = producto.NombreProducto;
                    }

                }
                else
                {
                    MessageBox.Show("Categoría Inexistente. Seleccione una Categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void FormMasVendidos_Load(object sender, EventArgs e)
        {
            CBCategorias.SelectedItem = "Juegos";
            CargarProductosMasVendidos();
        }
    }
}
