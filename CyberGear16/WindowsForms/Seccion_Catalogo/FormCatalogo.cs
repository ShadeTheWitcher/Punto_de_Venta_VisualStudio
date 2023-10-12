using CyberGear16.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CyberGear16.WindowsForms.Seccion_Catalogo
{
    public partial class FormCatalogo : Form
    {
        private readonly BdCybergearContext _context;
        private readonly List<Product> productos;
        private List<Product> productosEnCarrito;
        int cantidadEnCarrito;
        public FormCatalogo(BdCybergearContext context)
        {
            InitializeComponent();
            productos = ObtenerProductosDesdeBD();
            _context = context;
            //Llena el catálogo con productos
            foreach (var producto in productos)
            {
                var productoControl = new ProductoControl(producto, 1, AgregarAlCarrito);
                flowLayoutPanel1.Controls.Add(productoControl);
            }



            flowLayoutPanel1.Padding = new Padding(20, 0, 0, 0);


            label2.ForeColor = Color.White;

        }


        

        private void AgregarAlCarrito(Product producto, int cant)
        {
            using (var context = new BdCybergearContext())
            {
                // Obtén el producto actualizado desde la base de datos para verificar el stock
                Product productoBD = context.Products.FirstOrDefault(p => p.Id == producto.Id);

                if (productoBD != null && productoBD.Cantidad >= 1 && productoBD.Cantidad - 1 >= productoBD.StockMinimo)
                {
                    // Buscar el producto en el carrito por su Id
                    Product productoExistente = ClassCarritoDatos.ProductosEnCarrito.FirstOrDefault(p => p.Id == producto.Id);

                    if (productoExistente != null)
                    {
                        // Si el producto ya está en el carrito, actualiza la cantidad
                        if (productoExistente.CantEnCart < productoBD.Cantidad)
                        {
                            productoExistente.CantEnCart+= cant;
                        }
                        else
                        {
                            MessageBox.Show("No hay suficiente stock disponible para incrementar la cantidad.");
                        }
                    }
                    else
                    {
                        // Si el producto no está en el carrito, agrégalo
                        ClassCarritoDatos.ProductosEnCarrito.Add(new Product
                        {
                            Id = producto.Id,
                            NombreProducto = producto.NombreProducto,
                            PrecioProducto = producto.PrecioProducto,
                            CantEnCart = cant,
                            CategoriaId = producto.CategoriaId,
                            Imagen = producto.Imagen,
                        });
                    }

                    cantidadEnCarrito = ClassCarritoDatos.ProductosEnCarrito.Sum(p => p.CantEnCart);
                    label2.Text = $"{cantidadEnCarrito}";
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock disponible o no se ha alcanzado el stock mínimo.");
                }
            }
        }


        private List<Product> ObtenerProductosDesdeBD()
        {
            // Aquí asumo que tienes una DbSet<Product> en tu contexto llamada Products.
            // Ajusta esto según la estructura de tu modelo y contexto.
            using (var context = new BdCybergearContext())
            {
                IQueryable<Product> productosQuery = context.Products;

                // Filtrar solo los productos activos
                productosQuery = productosQuery.Where(p => p.Activo == "SI");


                // Obtener los productos
                List<Product> productosDesdeBD = productosQuery.ToList();

                foreach (var productoDesdeBD in productosDesdeBD)
                {
                    // Extraer la información de la base de datos
                    int idProducto = productoDesdeBD.Id;
                    string nombreProducto = productoDesdeBD.NombreProducto ?? "";
                    double precioProducto = productoDesdeBD.PrecioProducto ?? 0;

                    // Cargar y mostrar la imagen si está disponible
                    byte[] imagenBytes = productoDesdeBD.Imagen;
                    if (imagenBytes != null && imagenBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imagenBytes))
                        {
                            System.Drawing.Image originalImage = System.Drawing.Image.FromStream(ms);

                            // Redimensionar la imagen manteniendo la relación de aspecto
                            int nuevoAncho = 80; // Ancho deseado
                            int nuevoAlto = (int)((double)originalImage.Height / originalImage.Width * nuevoAncho);
                            System.Drawing.Image imagenRedimensionada = new Bitmap(originalImage, nuevoAncho, nuevoAlto);

                            // Ahora puedes utilizar 'imagenRedimensionada' donde necesites
                            // Por ejemplo, podrías asignar esta imagen a un control PictureBox en tu formulario
                        }
                    }
                }

                return productosDesdeBD;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCatalogo_Load(object sender, EventArgs e)
        {
            // Obtener la cantidad de elementos en el carrito
            cantidadEnCarrito = ClassCarritoDatos.ProductosEnCarrito.Sum(p => p.CantEnCart);
            label2.ForeColor = Color.White;

            label2.Text = $"{cantidadEnCarrito}";
        }
    }
}


