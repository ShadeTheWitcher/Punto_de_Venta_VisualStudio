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

namespace CyberGear16.WindowsForms.Seccion_Catalogo
{
    public partial class FormCatalogo : Form
    {
        private readonly BdCybergearContext _context;
        private readonly List<Product> productos;
        public FormCatalogo(BdCybergearContext context)
        {
            InitializeComponent();
            productos = ObtenerProductosDesdeBD();
            _context = context;
            //Llena el catálogo con productos
            foreach (var producto in productos)
            {
                var productoControl = new ProductoControl(producto, AgregarAlCarrito);
                flowLayoutPanel1.Controls.Add(productoControl);
            }


            flowLayoutPanel1.Padding = new Padding(20, 0, 0, 0);




        }


        private FormSeccionVentas formSeccionVentas;

        private void AgregarAlCarrito(Product producto)
        {
            // Aquí puedes agregar el producto al carrito o a la lista que desees
            // Puedes almacenar los productos seleccionados en una lista y luego enviarlos al datagrid
            // Puedes tener un evento que se dispare al agregar al carrito y manejarlo en el formulario principal
            // o donde tengas el datagrid
            //formSeccionVentas.AgregarAlCarrito(producto);
        }


        private List<Product> ObtenerProductosDesdeBD()
        {
            // Aquí asumo que tienes una DbSet<Product> en tu contexto llamada Products.
            // Ajusta esto según la estructura de tu modelo y contexto.
            using (var context = new BdCybergearContext())
            {
                IQueryable<Product> productosQuery = context.Products;

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
                            Image originalImage = Image.FromStream(ms);

                            // Redimensionar la imagen manteniendo la relación de aspecto
                            int nuevoAncho = 80; // Ancho deseado
                            int nuevoAlto = (int)((double)originalImage.Height / originalImage.Width * nuevoAncho);
                            Image imagenRedimensionada = new Bitmap(originalImage, nuevoAncho, nuevoAlto);

                            // Ahora puedes utilizar 'imagenRedimensionada' donde necesites
                            // Por ejemplo, podrías asignar esta imagen a un control PictureBox en tu formulario
                        }
                    }
                }

                return productosDesdeBD;
            }
        }


    }
}


