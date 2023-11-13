using CyberGear16.Models;
using iText.Commons.Actions.Contexts;
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
        int cantTotal = 0;

        private bool filtroFecha = false;

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

                CargarDatosEnDataGridView();

                // Establece una categoría predeterminada
                CBCategorias.SelectedIndex = 0;

                // Llama al manejador de eventos para cargar la información inicial

                //CargarProductosSinFiltro(CBCategorias.SelectedItem.ToString());
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
            // Llama al método para cargar la información según la categoría seleccionada
        }

        private void BReporte_Click(object sender, EventArgs e)
        {
            filtroFecha = true;
            DateTime dateTimeFechaDesde = DTPDesde.Value;
            DateTime dateTimeFechaHasta = DTPHasta.Value;

            DateOnly dateOnlyFechaDesde = new DateOnly(dateTimeFechaDesde.Year, dateTimeFechaDesde.Month, dateTimeFechaDesde.Day);
            DateOnly dateOnlyFechaHasta = new DateOnly(dateTimeFechaHasta.Year, dateTimeFechaHasta.Month, dateTimeFechaHasta.Day);


            string categoriaSeleccionada = CBCategorias.SelectedItem.ToString();

            LTop.Text = "Top 5 productos más vendidos en la empresa (Filtrado Por Fecha)";

            CargarProductosConFiltroFecha(categoriaSeleccionada, dateOnlyFechaDesde, dateOnlyFechaHasta);

        }

        //--------------Productos Con Filtro--------------

        private void CargarProductosConFiltroFecha(string categoriaCombo, DateOnly p_fechaDesde, DateOnly p_fechaHasta)
        {
            cantTotal = 0;
            using (var contexto = new BdCybergearContext())
            {

                //Busqueda Gráfico
                var graficoMasVendidos = contexto.VentasCabeceras
                    .Where(ventaCabecera => ventaCabecera.Fecha >= p_fechaDesde && ventaCabecera.Fecha <= p_fechaHasta) // Filtra por el Id del cliente
                                                                                                                        //SelectedMany sirve para traer todos los elementos asociados a venta detalles en este caso
                    .SelectMany(ventaCabecera => ventaCabecera.VentasDetalles)
                    .Where(detalle => detalle.Producto.Categoria.CategoriaNombre == categoriaCombo) // Filtra por la categoría seleccionada
                    .GroupBy(detalle => detalle.ProductoId)
                    .OrderByDescending(g => g.Count())
                    .Take(5) // Puedes ajustar este número según la cantidad de productos que deseas mostrar
                    .Select(g => new
                    {
                        //Key: Clave del grupo de consulta (GroupBy)
                        NombreProducto = contexto.Products.FirstOrDefault(p => p.Id == g.Key).NombreProducto,
                        CantidadVendida = g.Sum(detalle => detalle.CantidadVenta)
                    })
                    .ToList();

                // Limpia los puntos de datos existentes en el gráfico
                //CProducts.Series["Series1"].Points.Clear();

                if (graficoMasVendidos.Count == 0)
                {
                    MessageBox.Show("No se han encontrado ventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarProductosSinFiltro(categoriaCombo);
                }
                else
                {
                    // Agrega los datos al gráfico
                    //foreach (var producto in graficoMasVendidos)
                    //{
                    //    CProducts.Series["Series1"].Points.AddXY(producto.NombreProducto, producto.CantidadVendida);
                    //}
                }

                //-----------------------

                //Busqueda TotalVentas
                var cantProductsComprados = contexto.VentasCabeceras
                    .Where(ventaCabecera => ventaCabecera.Fecha >= p_fechaDesde && ventaCabecera.Fecha <= p_fechaHasta)
                    //SelectedMany sirve para traer todos los elementos asociados a venta detalles en este caso
                    .SelectMany(ventaCabecera => ventaCabecera.VentasDetalles)
                    .ToList();


                foreach (var compradosTot in cantProductsComprados)
                {
                    cantTotal = cantTotal + compradosTot.CantidadVenta;

                }
                //-----------------------

                //Asignación a Labels
                LValorVentasTot.Text = cantTotal.ToString();
            }
        }
        //------------------------------------------
        private void CargarProductosSinFiltro(string categoriaCombo)
        {
            cantTotal = 0;
            filtroFecha = false;
            LTop.Text = "Top 5 productos más vendidos en la empresa (General)";

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
                        CantidadVendida = g.Sum(detalle => detalle.CantidadVenta)
                    })
                    .ToList();

                // Limpia los puntos de datos existentes en el gráfico
                //CProducts.Series["Series1"].Points.Clear();

                if (productosMasVendidos.Count == 0)
                {
                    MessageBox.Show("No se han encontrado ventas para esta categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Agrega los datos al gráfico
                    //foreach (var producto in productosMasVendidos)
                    //{
                    //    CProducts.Series["Series1"].Points.AddXY(producto.NombreProducto, producto.CantidadVendida);
                    //}
                }

                //Busqueda TotalVentas
                var cantProductsComprados = contexto.VentasDetalles.ToList();

                foreach (var compradosTot in cantProductsComprados)
                {
                    cantTotal = cantTotal + compradosTot.CantidadVenta;

                }
                //-----------------------

                //Asignación a Labels
                LValorVentasTot.Text = cantTotal.ToString();
            }
        }

        private void BGeneral_Click(object sender, EventArgs e)
        {
            string contenidoCombo = CBCategorias.SelectedItem.ToString();
            CargarProductosSinFiltro(contenidoCombo);
        }

        private void CargarDatosEnDataGridView()
        {
            using (var contexto = new BdCybergearContext())
            {

                // Consulta para obtener la información necesaria
                var cantProductsVendidos = from ventaDetalle in contexto.VentasDetalles
                                           join ventaCabecera in contexto.VentasCabeceras on ventaDetalle.VentaId equals ventaCabecera.Id
                                           join producto in contexto.Products on ventaDetalle.ProductoId equals producto.Id
                                           group new { ventaDetalle, producto } by new { producto.Id, producto.NombreProducto } into g
                                           select new
                                           {
                                               IdProducto = g.Key.Id,
                                               NombreProducto = g.Key.NombreProducto,
                                               TotalVentas = g.Sum(x => x.ventaDetalle.CantidadVenta)
                                           };

                //// Convierte la consulta en una lista y carga los datos en el DataGridView
                //List<cantProductsVendidos> listaProductos = cantProductsVendidos.ToList();
                DGVProductos.DataSource = cantProductsVendidos.ToList();
            }
        }
    }

}
