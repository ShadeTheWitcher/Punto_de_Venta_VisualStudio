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
    public partial class FormInformeCliente : Form
    {
        private readonly BdCybergearContext _context;
        private Cliente usuarioClienteElegido;
        public FormInformeCliente(Cliente usuarioCliente, BdCybergearContext context)
        {
            InitializeComponent();
            //CargarCategorias();

            this.usuarioClienteElegido = usuarioCliente;

            recuperarDatosIndividuo();
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

        //private void CargarCategorias()
        //{
        //    // cargar las categorías desde la base de datos y agregarlas al ComboBox

        //    using (var context = new BdCybergearContext())
        //    {
        //        var categorias = context.Categoria.ToList();

        //        // Agrega una opción vacía al principio de la lista
        //        categorias.Insert(0, new Categorium { IdCategoria = 0, CategoriaNombre = "Seleccionar Categoría" });

        //        CBCategorias.DataSource = categorias;
        //        CBCategorias.DisplayMember = "CategoriaNombre"; // Ajusta esto según tu modelo
        //        CBCategorias.ValueMember = "IdCategoria"; // Ajusta esto según tu modelo
        //    }
        //}
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
                //var productosMasVendidos = contexto.VentasDetalles
                //    .Where(detalle => detalle.Producto.Categoria.CategoriaNombre == categoriaCombo)// Filtra por la categoría seleccionada
                //    .GroupBy(detalle => detalle.ProductoId)
                //    .OrderByDescending(g => g.Count())
                //    .Take(5) // Puedes ajustar este número según la cantidad de productos que deseas mostrar
                //    .Select(g => new
                //    {
                //        //Key: Clave del grupo de consulta (GroupBy)
                //        NombreProducto = contexto.Products.FirstOrDefault(p => p.Id == g.Key).NombreProducto,
                //        CantidadVendida = g.Count()
                //    })
                //    .ToList();

                var productosMasVendidos = contexto.VentasCabeceras
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
                foreach (var producto in productosMasVendidos)
                {
                    CProducts.Series["Series1"].Points.AddXY(producto.NombreProducto, producto.CantidadVendida);
                }
            }
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
            CargarProductosMasVendidos("VideoJuegos");


        }
    }
}
