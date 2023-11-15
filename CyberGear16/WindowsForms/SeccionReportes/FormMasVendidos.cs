using CyberGear16.Models;
using iText.Commons.Actions.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
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

            CBCategorias.Items.Add("Todos");

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

            }

            CargarDatosVentas("Todos");
        }

        private void CBCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtiene la categoría seleccionada en el ComboBox
            string categoriaSeleccionada = CBCategorias.SelectedItem.ToString();

            if (filtroFecha == false)
            {
                CargarDatosVentas(categoriaSeleccionada);

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

            LTop.Text = "Cantidad de productos vendidos (Filtrado Por Fecha)";

            CargarDatosVentasFecha(categoriaSeleccionada, dateOnlyFechaDesde, dateOnlyFechaHasta);

        }

        //--------------Productos Con Filtro Fecha --------------
        private void CargarDatosVentasFecha(string categoriaTipoFecha, DateOnly fechaDesde, DateOnly fechaHasta)
        {
            cantTotal = 0;

            using (var contexto = new BdCybergearContext())
            {
                if (categoriaTipoFecha == "Todos")
                {
                    // Consulta para obtener la información necesaria
                    var cantProductsVendidos = from ventaDetalle in contexto.VentasDetalles
                                               join ventaCabecera in contexto.VentasCabeceras on ventaDetalle.VentaId equals ventaCabecera.Id
                                               join producto in contexto.Products on ventaDetalle.ProductoId equals producto.Id
                                               where ventaCabecera.Fecha >= fechaDesde && ventaCabecera.Fecha <= fechaHasta
                                               group ventaDetalle by new { producto.NombreProducto, producto.Cantidad} into g
                                               select new
                                               {
                                                   NombreProducto = g.Key.NombreProducto,
                                                   Stock = g.Key.Cantidad,
                                                   TotalVentas = g.Sum(x => x.CantidadVenta)
                                               };

                    // Verifica si la variable cantProductsVendidos no tiene elementos
                    if (!cantProductsVendidos.Any())
                    {
                        MessageBox.Show("No se han encontrado ventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CargarDatosVentas("Todos");
                    }


                    var productosOrdenados = cantProductsVendidos.OrderByDescending(p => p.TotalVentas).ToList();
                    DGVProductos.DataSource = productosOrdenados;



                    // Convierte la consulta en una lista y carga los datos en el DataGridView
                    //DGVProductos.DataSource = cantProductsVendidos.ToList();

                }
                else
                {
                    // Consulta para obtener la información necesaria
                    var cantProductsVendidos = from ventaDetalle in contexto.VentasDetalles
                                               join ventaCabecera in contexto.VentasCabeceras on ventaDetalle.VentaId equals ventaCabecera.Id
                                               join producto in contexto.Products on ventaDetalle.ProductoId equals producto.Id
                                               where ventaDetalle.Producto.Categoria.CategoriaNombre == categoriaTipoFecha &&
                                               ventaCabecera.Fecha >= fechaDesde && ventaCabecera.Fecha <= fechaHasta
                                               group ventaDetalle by new { producto.NombreProducto, producto.Cantidad} into g
                                               select new
                                               {
                                                   NombreProducto = g.Key.NombreProducto,
                                                   Stock = g.Key.Cantidad,
                                                   TotalVentas = g.Sum(x => x.CantidadVenta)
                                               };

                    // Verifica si la variable cantProductsVendidos no tiene elementos
                    if (!cantProductsVendidos.Any())
                    {
                        MessageBox.Show("No se han encontrado ventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CargarDatosVentas("Todos");
                    }

                    var productosOrdenados = cantProductsVendidos.OrderByDescending(p => p.TotalVentas).ToList();
                    DGVProductos.DataSource = productosOrdenados;

                    // Convierte la consulta en una lista y carga los datos en el DataGridView
                    //DGVProductos.DataSource = cantProductsVendidos.ToList();
                }

                //Busqueda TotalVentas
                var cantProductsComprados = contexto.VentasCabeceras
                    .Where(ventaCabecera => ventaCabecera.Fecha >= fechaDesde && ventaCabecera.Fecha <= fechaHasta)
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


        //-----------------------------------------------------




        //--------------Productos Sin Filtro--------------
        private void CargarDatosVentas(string categoriaTipo)
        {
            cantTotal = 0;
            filtroFecha = false;
            LTop.Text = "Cantidad de productos vendidos (Sin Filtro)";

            using (var contexto = new BdCybergearContext())
            {

                if (categoriaTipo == "Todos")
                {
                    // Consulta para obtener la información necesaria
                    var cantProductsVendidos = from ventaDetalle in contexto.VentasDetalles
                                               join ventaCabecera in contexto.VentasCabeceras on ventaDetalle.VentaId equals ventaCabecera.Id
                                               join producto in contexto.Products on ventaDetalle.ProductoId equals producto.Id
                                               group ventaDetalle by new { producto.NombreProducto, producto.Cantidad} into g
                                               select new
                                               {
                                                   NombreProducto = g.Key.NombreProducto,
                                                   Stock = g.Key.Cantidad,
                                                   TotalVentas = g.Sum(x => x.CantidadVenta)
                                               };

                    var productosOrdenados = cantProductsVendidos.OrderByDescending(p => p.TotalVentas).ToList();
                    DGVProductos.DataSource = productosOrdenados;

                    // Convierte la consulta en una lista y carga los datos en el DataGridView
                    //DGVProductos.DataSource = cantProductsVendidos.ToList();
                }
                else
                {
                    // Consulta para obtener la información necesaria
                    var cantProductsVendidos = from ventaDetalle in contexto.VentasDetalles
                                               join ventaCabecera in contexto.VentasCabeceras on ventaDetalle.VentaId equals ventaCabecera.Id
                                               join producto in contexto.Products on ventaDetalle.ProductoId equals producto.Id
                                               where ventaDetalle.Producto.Categoria.CategoriaNombre == categoriaTipo
                                               group ventaDetalle by new { producto.NombreProducto, producto.Cantidad} into g
                                               select new
                                               {
                                                   NombreProducto = g.Key.NombreProducto,
                                                   Stock = g.Key.Cantidad,
                                                   TotalVentas = g.Sum(x => x.CantidadVenta)
                                               };
                    // Verifica si la variable cantProductsVendidos no tiene elementos
                    if (!cantProductsVendidos.Any())
                    {
                        MessageBox.Show("No se han encontrado ventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CargarDatosVentas("Todos");
                    }

                    var productosOrdenados = cantProductsVendidos.OrderByDescending(p => p.TotalVentas).ToList();
                    DGVProductos.DataSource = productosOrdenados;


                    // Convierte la consulta en una lista y carga los datos en el DataGridView
                    //DGVProductos.DataSource = cantProductsVendidos.ToList();
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


        //------------------------------------------------


        private void BGeneral_Click(object sender, EventArgs e)
        {
            string contenidoCombo = CBCategorias.SelectedItem.ToString();
            CargarDatosVentas(contenidoCombo);
        }

    }
}
