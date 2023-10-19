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
            DateTime dateTimeFechaDesde = DTPDesde.Value;
            DateTime dateTimeFechaHasta = DTPHasta.Value;

            DTPGDesde.Value = dateTimeFechaDesde;
            DTPGHasta.Value = dateTimeFechaHasta;


            DateOnly dateOnlyFechaDesde = new DateOnly(dateTimeFechaDesde.Year, dateTimeFechaDesde.Month, dateTimeFechaDesde.Day); //new (DTPDesde.Value.Year, DTPDesde.Value.Month, DTPDesde.Value.Day);
            DateOnly dateOnlyFechaHasta = new DateOnly(dateTimeFechaHasta.Year, dateTimeFechaHasta.Month, dateTimeFechaHasta.Day);

            cargarFiltroDataGrid(dateOnlyFechaDesde, dateOnlyFechaHasta);

        }

        private void cargarFiltroDataGrid(DateOnly p_fechaDesde, DateOnly p_fechaHasta)
        {
            using (var contexto = new BdCybergearContext())
            {
                var datosFiltrados = from venta in contexto.VentasCabeceras
                                     join cliente in contexto.Clientes on venta.IdCliente equals cliente.IdCliente
                                     join usuario in contexto.Usuarios on venta.IdVendedor equals usuario.Id
                                     select new
                                     {
                                         ClienteDNI = cliente.Dni,
                                         VendedorDNI = usuario.Dni,
                                         //Campos de VentaCabecera
                                         FechaVenta = venta.Fecha,
                                         MontoVenta = venta.TotalVenta
                                     };

                //// Asigna los productos a la fuente de datos del DataGridView
                var filtro = datosFiltrados.Where(e => e.FechaVenta >= p_fechaDesde && e.FechaVenta <= p_fechaHasta).ToList();

                if (filtro.Count == 0)
                {
                    MessageBox.Show("No se han encontrado ventas en las fechas ingresadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarDatosEnDataGridView();
                    DTPDesde.Value = DateTime.Now;
                    DTPHasta.Value = DateTime.Now;
                    DTPGDesde.Value = DateTime.Now;
                    DTPGHasta.Value = DateTime.Now;
                }
                else
                {
                    DGVReportes.DataSource = filtro;

                }

            }
        }

        private void CargarDatosEnDataGridView()
        {
            using (var context = new BdCybergearContext()) // se lo engloba en un using para q se cierre la conexion
            {
                var ventas = from venta in context.VentasCabeceras
                             join cliente in context.Clientes on venta.IdCliente equals cliente.IdCliente
                             join usuario in context.Usuarios on venta.IdVendedor equals usuario.Id
                             select new
                             {
                                 ClienteDNI = cliente.Dni,
                                 VendedorDNI = usuario.Dni,
                                 //Campos de VentaCabecera
                                 FechaVenta = venta.Fecha,
                                 MontoVenta = venta.TotalVenta
                             };

                //// Asigna los productos a la fuente de datos del DataGridView
                DGVReportes.DataSource = ventas.ToList();


                //// Configura el estilo y columnas del DataGridView
                //// (asegúrate de que las propiedades de Product se correspondan con las columnas)

                ////DGVReportes.Columns["Id"].Width = 40;
                ////DGVReportes.Columns["NombreProducto"].Width = 150;
                ////DGVReportes.Columns["PrecioProducto"].Width = 100;
                ////DGVReportes.Columns["Descripcion"].Width = 200;
                ////DGVReportes.Columns["Cantidad"].Width = 100;
                ////DGVReportes.Columns["CategoriaId"].Width = 100;
                ////DGVReportes.Columns["Activo"].Width = 100;



                //// Cambia el color de fuente a negro para todas las celdas del DataGridView
                //DGVReportes.DefaultCellStyle.ForeColor = Color.Black;

                //// Oculta las columnas no deseadas (en este caso, ocultamos todas las demás)
                //foreach (DataGridViewColumn column in DGVReportes.Columns)
                //{
                //    if (column.Name != "ClienteDNI" && column.Name != "VendedorDNI" && column.Name != "FechaVenta" && column.Name != "MontoVenta")
                //    //column.Name != "Cantidad" && column.Name != "Acciones" && column.Name != "CategoriaId" &&
                //    //column.Name != "Activo")
                //    {
                //        column.Visible = false;
                //    }
                //}
            }
        }


        private void FormReporteSuper_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGridView();
        }
         
        private void BRVendedores_Click(object sender, EventArgs e)
        {
            FormMasVendidos masVendidos = new FormMasVendidos(/*_context*/);
            masVendidos.ShowDialog();
        }


    }
}
