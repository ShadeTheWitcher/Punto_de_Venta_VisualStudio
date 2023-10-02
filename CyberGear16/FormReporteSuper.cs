using CyberGear16.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberGear16
{
    public partial class FormReporteSuper : Form
    {
        private readonly BdCybergearContext _context; // DbContext de Entity Framework
        public FormReporteSuper()
        {
            InitializeComponent();
        }

        private void BReporte_Click(object sender, EventArgs e)
        {
            DTPGDesde.Value = DTPDesde.Value;
            DTPGHasta.Value = DTPHasta.Value;
        }

        //private void CargarDatosEnDataGridView()
        //{
        //    using (var context = new BdCybergearContext())
        //    {
        //        // Vuelve a cargar los datos en el DataGridView para reflejar los cambios.
        //        var productos = context.Products
        //        .Select(p => new
        //        {
        //            p.Id,
        //            p.NombreProducto,
        //            p.PrecioProducto,
        //            p.Descripcion,
        //            p.Cantidad,
        //            p.CategoriaId,
        //            p.Activo
        //        })
        //        .ToList();

        //        DGVReportes.DataSource = productos;
        //    }
        //}

        private void FormReporteSuper_Load(object sender, EventArgs e)
        {
            using (var context = new BdCybergearContext()) // se lo engloba en un using para q se cierre la conexion
            {
                // Consulta los productos desde la base de datos
                var products = context.Products
                    .Select(p => new
                    {
                        p.Id,
                        p.NombreProducto,
                        p.PrecioProducto,
                        p.Descripcion,
                        p.Cantidad,
                        p.CategoriaId,
                        p.Activo
                    })
                    .ToList();

                // Asigna los productos a la fuente de datos del DataGridView
                DGVReportes.DataSource = products;

                // Configura el estilo y columnas del DataGridView
                // (asegúrate de que las propiedades de Product se correspondan con las columnas)

                DGVReportes.Columns["Id"].Width = 40;
                DGVReportes.Columns["NombreProducto"].Width = 150;
                DGVReportes.Columns["PrecioProducto"].Width = 100;
                DGVReportes.Columns["Descripcion"].Width = 200;
                DGVReportes.Columns["Cantidad"].Width = 100;
                DGVReportes.Columns["CategoriaId"].Width = 100;
                DGVReportes.Columns["Activo"].Width = 100;



                // Cambia el color de fuente a negro para todas las celdas del DataGridView
                DGVReportes.DefaultCellStyle.ForeColor = Color.Black;

                // Oculta las columnas no deseadas (en este caso, ocultamos todas las demás)
                foreach (DataGridViewColumn column in DGVReportes.Columns)
                {
                    if (column.Name != "Id" && column.Name != "NombreProducto" && column.Name != "PrecioProducto" && column.Name != "Descripcion" &&
                        column.Name != "Cantidad" && column.Name != "Acciones" && column.Name != "CategoriaId" &&
                        column.Name != "Activo")
                    {
                        column.Visible = false;
                    }
                }
            }
        }

        private void BRVendedores_Click(object sender, EventArgs e)
        {
            FormMasVendidos masVendidos = new FormMasVendidos(/*_context*/);
            masVendidos.ShowDialog();
        }
    }
}
