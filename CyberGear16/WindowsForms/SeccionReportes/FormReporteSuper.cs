using CyberGear16.Models;
using CyberGear16.WindowsForms.SeccionVentas;
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

        private void FormReporteSuper_Load(object sender, EventArgs e)
        {
            CargarDatosEnDataGridView();
            //Agregamos Columna de Acciones en el Data Grid View
            DataGridViewButtonColumn modificarButtonColumn = new DataGridViewButtonColumn();
            modificarButtonColumn.Name = "Acciones";
            modificarButtonColumn.Text = "Factura";
            modificarButtonColumn.Width = 150;
            modificarButtonColumn.UseColumnTextForButtonValue = true;
            DGVReportes.Columns.Add(modificarButtonColumn);
        }

        private void DGVReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DGVReportes.Columns["Acciones"].Index)
            {
                using (var contexto = new BdCybergearContext())
                {
                    // Obtén la venta seleccionada
                    DataGridViewRow row = DGVReportes.Rows[e.RowIndex];
                    int ventaId = Convert.ToInt32(row.Cells["IdVenta"].Value);

                    VentasCabecera ventaSeleccionada = contexto.VentasCabeceras.FirstOrDefault(p => p.Id == ventaId);

                    Cliente clienteVenta = contexto.Clientes.FirstOrDefault(p => p.IdCliente == ventaSeleccionada.IdCliente);



                    FormFactura facturaForm = new FormFactura();

                    facturaForm.IdVenta = ventaSeleccionada.Id; // Puedes agregar más información según tus necesidades
                    facturaForm.FechaVenta = ventaSeleccionada.Fecha;
                    facturaForm.ClienteNombre = clienteVenta.Nombre; // Suponiendo que cliente tiene una propiedad "Nombre"
                    facturaForm.Apellido = clienteVenta.Apellido;
                    facturaForm.dniCliente = clienteVenta.Dni;

                    // Muestra el formulario de la factura
                    facturaForm.Show();


                }
            }
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
                                         IdVenta = venta.Id,
                                         ClientenNom = cliente.Nombre + " " + cliente.Apellido,
                                         VendedorNombre = usuario.Nombre + " " + usuario.Apellido,
                                         //Campos de VentaCabecera
                                         FechaVenta = venta.Fecha,
                                         MontoVenta = venta.TotalVenta
                                     };

                
                // Asigna los productos a la fuente de datos del DataGridView
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

            // Busca la columna por nombre y ocúltala
            var idVentaColumna = DGVReportes.Columns["IdVenta"];
            if (idVentaColumna != null)
            {
                idVentaColumna.Visible = false;
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
                                 IdVenta = venta.Id,
                                 ClientenNom = cliente.Nombre + " " + cliente.Apellido,
                                 VendedorNombre = usuario.Nombre + " " + usuario.Apellido,
                                 //Campos de VentaCabecera
                                 FechaVenta = venta.Fecha,
                                 MontoVenta = venta.TotalVenta,

                             };


                //// Asigna los productos a la fuente de datos del DataGridView
                DGVReportes.DataSource = ventas.ToList();
            }

            // Busca la columna por nombre y ocúltala
            var idVentaColumna = DGVReportes.Columns["IdVenta"];
            if (idVentaColumna != null)
            {
                idVentaColumna.Visible = false;
            }
        }

        private void BRVendedores_Click(object sender, EventArgs e)
        {
            FormMasVendidos masVendidos = new FormMasVendidos(/*_context*/);
            masVendidos.ShowDialog();
        }

        
    }
}
