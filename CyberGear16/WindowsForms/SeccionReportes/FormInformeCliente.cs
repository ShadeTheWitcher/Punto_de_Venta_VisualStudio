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
    public partial class FormInformeCliente : Form
    {
        private bool filtroFecha = false;
        private readonly BdCybergearContext _context;
        private Cliente usuarioClienteElegido;
        public FormInformeCliente(Cliente usuarioCliente, BdCybergearContext context)
        {
            InitializeComponent();
            //CargarCategorias();

            this.usuarioClienteElegido = usuarioCliente;

            recuperarDatosIndividuo();
        }

        private void FormInformeCliente_Load(object sender, EventArgs e)
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
            CargarProductosSinFiltro("VideoJuegos");

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
            if (usuarioClienteElegido != null)
            {
                LMNombre.Text = usuarioClienteElegido.Nombre;
                LMApellido.Text = usuarioClienteElegido.Apellido;
                LMEmail.Text = usuarioClienteElegido.Email;
                LMDni.Text = usuarioClienteElegido.Dni.ToString();
                LMTelefono.Text = usuarioClienteElegido.Telefono.ToString();
            }
        }


        private void CBCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtiene la categoría seleccionada en el ComboBox
            string categoriaSeleccionada = CBCategorias.SelectedItem.ToString();

            // Llama al método para cargar la información según la categoría seleccionada
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
            int cantTotalCat = 0;
            int cantTotal = 0;
            using (var contexto = new BdCybergearContext())
            {

                //Busqueda Gráfico
                var graficoMasComprados = contexto.VentasCabeceras
                    .Where(ventaCabecera => ventaCabecera.IdCliente == usuarioClienteElegido.IdCliente && // Filtra por el Id del cliente
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
                if (graficoMasComprados.Count == 0)
                {
                    MessageBox.Show("No se han encontrado ventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarProductosSinFiltro(categoriaCombo);
                }
                else
                {
                    // Agrega los datos al gráfico
                    foreach (var producto in graficoMasComprados)
                    {
                        CProducts.Series["Series1"].Points.AddXY(producto.NombreProducto, producto.CantidadVendida);
                    }
                }
                //-----------------------

                //Busqueda TotalCategorias
                var categoriaMasComprados = contexto.VentasCabeceras
                   .Where(ventaCabecera => ventaCabecera.IdCliente == usuarioClienteElegido.IdCliente && // Filtra por el Id del cliente
                    ventaCabecera.Fecha >= p_fechaDesde && ventaCabecera.Fecha <= p_fechaHasta)
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

                foreach (var compradosCat in categoriaMasComprados)
                {
                    cantTotalCat = cantTotalCat + compradosCat.CantidadVendida;
                }

                //-----------------------

                //Busqueda TotalCompras
                var cantProductsComprados = contexto.VentasCabeceras
                    .Where(ventaCabecera => ventaCabecera.IdCliente == usuarioClienteElegido.IdCliente && // Filtra por el Id del cliente
                    ventaCabecera.Fecha >= p_fechaDesde && ventaCabecera.Fecha <= p_fechaHasta)
                    //SelectedMany sirve para traer todos los elementos asociados a venta detalles en este caso
                    .SelectMany(ventaCabecera => ventaCabecera.VentasDetalles)
                    .ToList();

                foreach (var compradosTot in cantProductsComprados)
                {
                    cantTotal = cantTotal + compradosTot.CantidadVenta;

                }
                //-----------------------

                //Asignación a Labels
                LComprasCat.Text = cantTotalCat.ToString();
                LComprasTot.Text = cantTotal.ToString();
            }
        }
        //------------------------------------------


        private void CargarProductosSinFiltro(string categoriaCombo)
        {
            LTop.Text = "Top 5 productos más comprados (General)";
            filtroFecha = false;
            int cantTotalCat = 0;
            int cantTotal = 0;

            using (var contexto = new BdCybergearContext())
            {
                //-----------
                //Busqueda Gráfico
                var graficoMasVendidos = contexto.VentasCabeceras
                    .Where(ventaCabecera => ventaCabecera.IdCliente == usuarioClienteElegido.IdCliente) // Filtra por el Id del cliente
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
                   .Where(ventaCabecera => ventaCabecera.IdCliente == usuarioClienteElegido.IdCliente) // Filtra por el Id del cliente
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

                foreach (var compradosCat in categoriaMasVendidos)
                {
                    cantTotalCat = cantTotalCat + compradosCat.CantidadVendida;
                }

                //-----------------------

                //Busqueda TotalVentas
                var cantProductsVendidos = contexto.VentasCabeceras
                    .Where(ventaCabecera => ventaCabecera.IdCliente == usuarioClienteElegido.IdCliente) // Filtra por el Id del cliente
                                                                                                        //SelectedMany sirve para traer todos los elementos asociados a venta detalles en este caso
                    .SelectMany(ventaCabecera => ventaCabecera.VentasDetalles)
                    .ToList();

                foreach (var compradosTot in cantProductsVendidos)
                {
                    cantTotal = cantTotal + compradosTot.CantidadVenta;

                }
                //-----------------------


                //Asignación a Labels
                LComprasCat.Text = cantTotalCat.ToString();
                LComprasTot.Text = cantTotal.ToString();
            }
        }

        private void BReporte_Click(object sender, EventArgs e)
        {
            DateTime dateTimeFechaDesde = DTPDesde.Value;
            DateTime dateTimeFechaHasta = DTPHasta.Value;

            DTPGDesde.Value = dateTimeFechaDesde;
            DTPGHasta.Value = dateTimeFechaHasta;


            DateOnly dateOnlyFechaDesde = new DateOnly(dateTimeFechaDesde.Year, dateTimeFechaDesde.Month, dateTimeFechaDesde.Day);
            DateOnly dateOnlyFechaHasta = new DateOnly(dateTimeFechaHasta.Year, dateTimeFechaHasta.Month, dateTimeFechaHasta.Day);

            LTop.Text = "Top 5 productos más comprados (Filtrado Por Fecha)";

            cargarFiltroDataGrid(dateOnlyFechaDesde, dateOnlyFechaHasta);

        }

        private void cargarFiltroDataGrid(DateOnly p_fechaDesde, DateOnly p_fechaHasta)
        {
            using (var contexto = new BdCybergearContext())
            {
                var datosFiltrados = from venta in contexto.VentasCabeceras
                                     join cliente in contexto.Clientes on venta.IdCliente equals cliente.IdCliente
                                     join usuario in contexto.Usuarios on venta.IdVendedor equals usuario.Id
                                     where cliente.IdCliente == usuarioClienteElegido.IdCliente
                                     select new
                                     {
                                         IdVenta = venta.Id,
                                         VendedorNombre = usuario.Nombre + " " + usuario.Apellido,
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
                    string categoriaCombo = CBCategorias.SelectedItem.ToString();
                    DGVReportes.DataSource = filtro;
                    CargarProductosConFiltroFecha(categoriaCombo, p_fechaDesde, p_fechaHasta);
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
                             where cliente.IdCliente == usuarioClienteElegido.IdCliente
                             select new
                             {
                                 IdVenta = venta.Id,
                                 VendedorNombre = usuario.Nombre + " " + usuario.Apellido,
                                 FechaVenta = venta.Fecha,
                                 MontoVenta = venta.TotalVenta
                             };

                //// Asigna los productos a la fuente de datos del DataGridView
                DGVReportes.DataSource = ventas.ToList();
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LMEmail_Click(object sender, EventArgs e)
        {

        }

        private void LEmail_Click(object sender, EventArgs e)
        {

        }

        private void LMApellido_Click(object sender, EventArgs e)
        {
        }

        private void LApellido_Click(object sender, EventArgs e)
        {
        }

        private void LNombre_Click(object sender, EventArgs e)
        {
        }

        private void LDni_Click(object sender, EventArgs e)
        {

        }

        private void LMNombre_Click(object sender, EventArgs e)
        {
        }

        private void LMTelefono_Click(object sender, EventArgs e)
        {
        }

        private void LTelefono_Click(object sender, EventArgs e)
        {
        }

        private void LMDni_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LCantProduct_Click(object sender, EventArgs e)
        {

        }


    }
}
