using CyberGear16.Models;
using CyberGear16.WindowsForms.SeccionVentas;
using iText.Commons.Actions;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CyberGear16
{
    public partial class FormInformeVendedor : Form
    {
        private bool filtroFecha = false;
        private readonly BdCybergearContext _context;
        private Usuario usuarioVendedorElegido;
        int idPerfil;
        public FormInformeVendedor(int perfil_id, Usuario usuarioVendedor, BdCybergearContext context)
        {
            InitializeComponent();

            this.usuarioVendedorElegido = usuarioVendedor;
            this.idPerfil = perfil_id;
            //this.dniIndividuo = dniIndividuoElegido;
            if (idPerfil == 3)
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
            recuperarDatosIndividuo();
        }

        private void FormInformeVendedor_Load(object sender, EventArgs e)
        {
            // Suscribe el evento SelectedIndexChanged del ComboBox
            CBCategorias.SelectedIndexChanged += CBCategorias_SelectedIndexChanged;

            using (var context = new BdCybergearContext())
            {
                // Obtén todas las categorías desde la base de datos que no tengan la IdCategoria igual a 1
                var categorias = context.Categoria
                    .Where(c => c.IdCategoria != 1)
                    .Select(c => c.CategoriaNombre)
                    .ToList();

                // Llena el ComboBox con las categorías
                foreach (var categoria in categorias)
                {
                    CBCategorias.Items.Add(categoria);
                }

                // Establece una categoría predeterminada
                CBCategorias.SelectedIndex = 0;

                // Llama al manejador de eventos para cargar la información inicial
                CargarProductosSinFiltro(CBCategorias.SelectedItem.ToString());
            }

            CargarDatosEnDataGridView();

            //Agregamos Columna de Acciones en el Data Grid View
            DataGridViewButtonColumn modificarButtonColumn = new DataGridViewButtonColumn();
            modificarButtonColumn.Name = "Acciones";
            modificarButtonColumn.Text = "Factura";
            modificarButtonColumn.Width = 150;
            modificarButtonColumn.UseColumnTextForButtonValue = true;
            DGVReportes.Columns.Add(modificarButtonColumn);
        }
        private void recuperarDatosIndividuo()
        {
            if (usuarioVendedorElegido != null)
            {
                // Asigna los valores del producto a los controles
                LMNombre.Text = usuarioVendedorElegido.Nombre;
                LMApellido.Text = usuarioVendedorElegido.Apellido;
                LMEmail.Text = usuarioVendedorElegido.Email;
                LMDni.Text = usuarioVendedorElegido.Dni.ToString();
                LMTelefono.Text = usuarioVendedorElegido.Tel.ToString();
            }
        }

        private void CBCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtiene la categoría seleccionada en el ComboBox
            string categoriaSeleccionada = CBCategorias.SelectedItem.ToString();

            if (filtroFecha == false)
            {
                CargarProductosSinFiltro(categoriaSeleccionada);

            }
            else
            {
                BReporte_Click(this, EventArgs.Empty);
            }
        }

        //--------------Productos Con Filtro--------------

        private void CargarProductosConFiltroFecha(string categoriaCombo, DateOnly p_fechaDesde, DateOnly p_fechaHasta)
        {
            filtroFecha = true;

            int cantTotalCat = 0;
            int cantTotal = 0;
            using (var contexto = new BdCybergearContext())
            {

                //Busqueda Gráfico
                var graficoMasVendidos = contexto.VentasCabeceras
                    .Where(ventaCabecera => ventaCabecera.IdVendedor == usuarioVendedorElegido.Id &&
                    ventaCabecera.Fecha >= p_fechaDesde && ventaCabecera.Fecha <= p_fechaHasta) // Filtra por el Id del cliente
                                                                                                //SelectedMany sirve para traer todos los elementos asociados a venta detalles en este caso
                    .SelectMany(ventaCabecera => ventaCabecera.VentasDetalles)
                    .Where(detalle => detalle.Producto.Categoria.CategoriaNombre == categoriaCombo)
                    .GroupBy(detalle => detalle.ProductoId)
                    .OrderByDescending(g => g.Count())
                    .Take(5)
                    .Select(g => new
                    {
                        NombreProducto = contexto.Products.FirstOrDefault(p => p.Id == g.Key).NombreProducto,
                        CantidadVendida = g.Sum(detalle => detalle.CantidadVenta)
                    })
                    .ToList();

                // Limpia los puntos de datos existentes en el gráfico
                CProducts.Series["Series1"].Points.Clear();

                // Agrega los datos al gráfico
                if (graficoMasVendidos.Count == 0)
                {
                    MessageBox.Show("No se han encontrado ventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarProductosSinFiltro(categoriaCombo);
                }
                else
                {
                    // Agrega los datos al gráfico
                    foreach (var producto in graficoMasVendidos)
                    {
                        CProducts.Series["Series1"].Points.AddXY(producto.NombreProducto, producto.CantidadVendida);
                    }
                }
                //-----------------------

                //Busqueda TotalCategorias
                var categoriaMasVendidos = contexto.VentasCabeceras
                   .Where(ventaCabecera => ventaCabecera.IdVendedor == usuarioVendedorElegido.Id &&
                    ventaCabecera.Fecha >= p_fechaDesde && ventaCabecera.Fecha <= p_fechaHasta) // Filtra por el Id del cliente
                                                                                                //SelectedMany sirve para traer todos los elementos asociados a venta detalles en este caso
                   .SelectMany(ventaCabecera => ventaCabecera.VentasDetalles)
                   .Where(detalle => detalle.Producto.Categoria.CategoriaNombre == categoriaCombo)
                   .GroupBy(detalle => detalle.ProductoId)
                   .Select(g => new
                   {
                       NombreProducto = contexto.Products.FirstOrDefault(p => p.Id == g.Key).NombreProducto,
                       CantidadVendida = g.Sum(detalle => detalle.CantidadVenta)
                   })
                   .ToList();

                foreach (var vendidosCat in categoriaMasVendidos)
                {
                    cantTotalCat = cantTotalCat + vendidosCat.CantidadVendida;
                }

                //-----------------------

                //Busqueda TotalVentas
                var cantProductsVendidos = contexto.VentasCabeceras
                    .Where(ventaCabecera => ventaCabecera.IdVendedor == usuarioVendedorElegido.Id &&
                    ventaCabecera.Fecha >= p_fechaDesde && ventaCabecera.Fecha <= p_fechaHasta) // Filtra por el Id del cliente
                                                                                                //SelectedMany sirve para traer todos los elementos asociados a venta detalles en este caso
                    .SelectMany(ventaCabecera => ventaCabecera.VentasDetalles)
                    .ToList();

                foreach (var vendidosTot in cantProductsVendidos)
                {
                    cantTotal = cantTotal + vendidosTot.CantidadVenta;

                }
                //-----------------------

                //Asignación a Labels
                LValorVentasCat.Text = cantTotalCat.ToString();
                LValorVentasTot.Text = cantTotal.ToString();
            }
        }
        //------------------------------------------


        //--------------Productos Sin Filtro--------------
        private void CargarProductosSinFiltro(string categoriaCombo)
        {
            LTop.Text = "Top 5 productos más vendidos (General)";
            filtroFecha = false;
            int cantTotalCat = 0;
            int cantTotal = 0;
            using (var contexto = new BdCybergearContext())
            {

                //Busqueda Gráfico
                var graficoMasVendidos = contexto.VentasCabeceras
                    .Where(ventaCabecera => ventaCabecera.IdVendedor == usuarioVendedorElegido.Id) // Filtra por el Id del cliente
                                                                                                   //SelectedMany sirve para traer todos los elementos asociados a venta detalles en este caso
                    .SelectMany(ventaCabecera => ventaCabecera.VentasDetalles)
                    .Where(detalle => detalle.Producto.Categoria.CategoriaNombre == categoriaCombo)
                    .GroupBy(detalle => detalle.ProductoId)
                    .OrderByDescending(g => g.Count())
                    .Take(5)
                    .Select(g => new
                    {
                        NombreProducto = contexto.Products.FirstOrDefault(p => p.Id == g.Key).NombreProducto,
                        CantidadVendida = g.Sum(detalle => detalle.CantidadVenta)
                    })
                    .ToList();

                // Limpia los puntos de datos existentes en el gráfico
                CProducts.Series["Series1"].Points.Clear();

                // Agrega los datos al gráfico
                foreach (var producto in graficoMasVendidos)
                {
                    CProducts.Series["Series1"].Points.AddXY(producto.NombreProducto, producto.CantidadVendida);
                }
                //-----------------------

                //Busqueda TotalCategorias
                var categoriaMasVendidos = contexto.VentasCabeceras
                   .Where(ventaCabecera => ventaCabecera.IdVendedor == usuarioVendedorElegido.Id) // Filtra por el Id del cliente
                                                                                                  //SelectedMany sirve para traer todos los elementos asociados a venta detalles en este caso
                   .SelectMany(ventaCabecera => ventaCabecera.VentasDetalles)
                   .Where(detalle => detalle.Producto.Categoria.CategoriaNombre == categoriaCombo)
                   .GroupBy(detalle => detalle.ProductoId)
                   .Select(g => new
                   {
                       NombreProducto = contexto.Products.FirstOrDefault(p => p.Id == g.Key).NombreProducto,
                       CantidadVendida = g.Sum(detalle => detalle.CantidadVenta)
                   })
                   .ToList();

                foreach (var vendidosCat in categoriaMasVendidos)
                {
                    cantTotalCat = cantTotalCat + vendidosCat.CantidadVendida;
                }

                //-----------------------

                //Busqueda TotalVentas
                var cantProductsVendidos = contexto.VentasCabeceras
                    .Where(ventaCabecera => ventaCabecera.IdVendedor == usuarioVendedorElegido.Id) // Filtra por el Id del cliente
                                                                                                   //SelectedMany sirve para traer todos los elementos asociados a venta detalles en este caso
                    .SelectMany(ventaCabecera => ventaCabecera.VentasDetalles)
                    .ToList();

                foreach (var vendidosTot in cantProductsVendidos)
                {
                    cantTotal = cantTotal + vendidosTot.CantidadVenta;

                }
                //-----------------------


                //Asignación a Labels
                LValorVentasCat.Text = cantTotalCat.ToString();
                LValorVentasTot.Text = cantTotal.ToString();
            }
        }
        //------------------------------------------------

        private void BReporte_Click(object sender, EventArgs e)
        {
            DateTime dateTimeFechaDesde = DTPDesde.Value;
            DateTime dateTimeFechaHasta = DTPHasta.Value;

            DTPGDesde.Value = dateTimeFechaDesde;
            DTPGHasta.Value = dateTimeFechaHasta;


            DateOnly dateOnlyFechaDesde = new DateOnly(dateTimeFechaDesde.Year, dateTimeFechaDesde.Month, dateTimeFechaDesde.Day);
            DateOnly dateOnlyFechaHasta = new DateOnly(dateTimeFechaHasta.Year, dateTimeFechaHasta.Month, dateTimeFechaHasta.Day);

            LTop.Text = "Top 5 productos más vendidos (Filtrado Por Fecha)";

            cargarFiltroDataGrid(dateOnlyFechaDesde, dateOnlyFechaHasta);

        }

        private void cargarFiltroDataGrid(DateOnly p_fechaDesde, DateOnly p_fechaHasta)
        {
            using (var contexto = new BdCybergearContext())
            {
                var datosFiltrados = from venta in contexto.VentasCabeceras
                                     join cliente in contexto.Clientes on venta.IdCliente equals cliente.IdCliente
                                     join usuario in contexto.Usuarios on venta.IdVendedor equals usuario.Id
                                     where usuario.Id == usuarioVendedorElegido.Id
                                     select new
                                     {
                                         IdVenta = venta.Id,
                                         ClientesNombreYApellido = cliente.Nombre + " " + cliente.Apellido,
                                         FechaVenta = venta.Fecha,
                                         MontoVenta = venta.TotalVenta
                                     };

                //// Asigna los productos a la fuente de datos del DataGridView
                var filtro = datosFiltrados.Where(e => e.FechaVenta >= p_fechaDesde && e.FechaVenta <= p_fechaHasta).ToList();

                if (filtro.Count == 0)
                {
                    string categoriaCombo = CBCategorias.SelectedItem.ToString();

                    MessageBox.Show("No se han encontrado ventas en las fechas ingresadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarDatosEnDataGridView();
                    CargarProductosSinFiltro(categoriaCombo);
                    DTPDesde.Value = DateTime.Now;
                    DTPHasta.Value = DateTime.Now;
                    DTPGDesde.Value = DateTime.Now;
                    DTPGHasta.Value = DateTime.Now;
                }
                else
                {
                    DGVReportes.DataSource = filtro;
                    string categoriaCombo = CBCategorias.SelectedItem.ToString();
                    CargarProductosConFiltroFecha(categoriaCombo, p_fechaDesde, p_fechaHasta);
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
                             where usuario.Id == usuarioVendedorElegido.Id
                             select new
                             {
                                 IdVenta = venta.Id,
                                 ClientesNombreYApellido = cliente.Nombre + " " + cliente.Apellido,
                                 FechaVenta = venta.Fecha,
                                 MontoVenta = venta.TotalVenta
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

        private void DGVReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DGVReportes.Columns["Acciones"].Index)
            {
                using (var contexto = new BdCybergearContext())
                {
                    // Obtén la venta seleccionada
                    DataGridViewRow row = DGVReportes.Rows[e.RowIndex];
                    int ventaId = Convert.ToInt32(row.Cells["IdVenta"].Value); // Asegúrate de tener una columna "IdProducto" para identificar el producto

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

        private void BGeneral_Click(object sender, EventArgs e)
        {
            string contenidoCombo = CBCategorias.SelectedItem.ToString();
            CargarDatosEnDataGridView();
            CargarProductosSinFiltro(contenidoCombo);
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void LFecha_Click(object sender, EventArgs e)
        {

        }

        private void DTPFecha_ValueChanged(object sender, EventArgs e)
        {
        }

        private void LCliente_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LCantVentas_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CProducts_Click(object sender, EventArgs e)
        {

        }

        private void DTPHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DTPDesde_ValueChanged(object sender, EventArgs e)
        {
        }


    }
}
