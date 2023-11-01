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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CyberGear16
{
    public partial class FormInformeVendedor : Form
    {
        private readonly BdCybergearContext _context;
        private Usuario usuarioVendedorElegido;
        int idPerfil;
        public FormInformeVendedor(int perfil_id, Usuario usuarioVendedor, BdCybergearContext context)
        {
            InitializeComponent();

            this.usuarioVendedorElegido = usuarioVendedor;
            this.idPerfil = perfil_id;
            //this.dniIndividuo = dniIndividuoElegido;
            if(idPerfil == 3)
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
            recuperarDatosIndividuo();
        }

        private void FormInformeVendedor_Load(object sender, EventArgs e)
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
        private void recuperarDatosIndividuo()
        {
            if (usuarioVendedorElegido != null)
            {
                // Asigna los valores del producto a los controles
                LMNombre.Text = usuarioVendedorElegido.Nombre;
                LMApellido.Text = usuarioVendedorElegido.Apellido;
                LMEmail.Text = usuarioVendedorElegido.Email;
                LMDni.Text = usuarioVendedorElegido.Dni.ToString();
                DateTime fechaConHora = new DateTime(usuarioVendedorElegido.Fecha.Year, usuarioVendedorElegido.Fecha.Month, usuarioVendedorElegido.Fecha.Day); ;
                DTPFecha.Value = fechaConHora;
                LMTelefono.Text = usuarioVendedorElegido.Tel.ToString();
            }
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
    }
}
