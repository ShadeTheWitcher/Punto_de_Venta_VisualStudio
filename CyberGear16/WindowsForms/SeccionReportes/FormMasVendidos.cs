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
        }

        private void CProducts_Click(object sender, EventArgs e)
        {

        }

        

        private void FormMasVendidos_Load(object sender, EventArgs e)
        {
            // Suscribe el evento SelectedIndexChanged del ComboBox
            CBCategorias.SelectedIndexChanged += CBCategorias_SelectedIndexChanged;

            // Llena el ComboBox con categorías (puedes adaptar esto a tu propio código)
            CBCategorias.Items.Add("VideoJuegos");
            CBCategorias.Items.Add("PC-Componentes");
            CBCategorias.Items.Add("Netbooks");

            // Establece una categoría predeterminada
            CBCategorias.SelectedIndex = 0;

            // Llama al manejador de eventos para cargar la información inicial
            CargarProductosMasVendidos("VideoJuegos");
            
        }

        private void CBCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtiene la categoría seleccionada en el ComboBox
            string categoriaSeleccionada = CBCategorias.SelectedItem.ToString();

            // Llama al método para cargar la información según la categoría seleccionada
            CargarProductosMasVendidos(categoriaSeleccionada);
        }
        private void CargarProductosMasVendidos(string categoriaCombo)
        {
            using (var contexto = new BdCybergearContext())
            {
                    var productosMasVendidos = contexto.VentasDetalles
                        .Where(detalle => detalle.Producto.Categoria.CategoriaNombre == categoriaCombo) // Filtra por la categoría seleccionada
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


                //if (categoriaSeleccionada >= 2 && categoriaSeleccionada <= 4)
                //{

                //}
                //else
                //{
                //    MessageBox.Show("Categoría Inexistente. Seleccione una Categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

            }
        }
    }

}
