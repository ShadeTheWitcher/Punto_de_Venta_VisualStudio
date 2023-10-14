using CyberGear16.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CyberGear16.WindowsForms.Seccion_Catalogo
{
    public partial class ProductoControl : UserControl
    {
        private readonly Product producto;
        private readonly Action<Product, int> agregarAlCarritoClick;
        // Agrega una variable para almacenar la cantidad seleccionada
        private int cantidadSeleccionada;

        public ProductoControl(Product producto, int cant, Action<Product, int> agregarAlCarrito)
        {
            InitializeComponent();

            this.producto = producto;
            this.agregarAlCarritoClick = agregarAlCarrito;

            cantidadSeleccionada = cant;
            // Inicializa el NumericUpDown y configura sus propiedades

            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = producto.Cantidad - producto.StockMinimo +1; // Establece el máximo según el stock disponible
            numericUpDown1.Value = 1; // Valor predeterminado

            // Configura los controles con la información del producto
            labelNombre.Text = producto.NombreProducto;
            labelPrecio.Text = $"Precio: {producto.PrecioProducto:C}";
            pictureBox1.Image = ByteArrayToImage(producto.Imagen);



        }


        // Método para convertir un array de bytes a Image
        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
            {
                // Puedes manejar el caso cuando el byteArray es nulo o vacío.
                // Por ejemplo, puedes devolver null, lanzar una excepción, o devolver una imagen predeterminada.
                // En este ejemplo, se devuelve null.
                return Properties.Resources.Producto_sin_imagen; // Asegúrate de tener DefaultImage en tus recursos

            }

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Utiliza la cantidad seleccionada al agregar al carrito
            agregarAlCarritoClick(producto, cantidadSeleccionada);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            cantidadSeleccionada = (int)numericUpDown1.Value;
            Debug.WriteLine($"Cantidad seleccionada: {cantidadSeleccionada}");
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            cantidadSeleccionada = (int)numericUpDown1.Value;
            Debug.WriteLine($"Click - Cantidad seleccionada: {cantidadSeleccionada}");
        }
    }
}
