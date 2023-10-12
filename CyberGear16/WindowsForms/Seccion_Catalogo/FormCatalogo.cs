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
            CargarCategorias();

            // Agrega un evento para manejar cambios en el TextBox (puedes hacer esto en el diseñador también)
            textBoxBusqueda.TextChanged += textBoxBusqueda_TextChanged;
            cbFiltroCategorias.SelectedIndexChanged += cbFiltroCategorias_SelectedIndexChanged;

            // Carga todos los productos al iniciar el formulario
            CargarProductosConFiltro(string.Empty, ObtenerCategoriaSeleccionada());

            // Carga todos los productos al iniciar el formulario
            CargarProductosConFiltro(string.Empty, ObtenerCategoriaSeleccionada());

            _context = context;
            


            flowLayoutPanel1.Padding = new Padding(20, 0, 0, 0);


            label2.ForeColor = Color.White;

        }



        //BOTON AGREGAR AL CARRITO 
        private void AgregarAlCarrito(Product producto, int cant)
        {
            using (var context = new BdCybergearContext())
            {
                // Obtén el producto actualizado desde la base de datos para verificar el stock
                Product productoBD = context.Products.FirstOrDefault(p => p.Id == producto.Id);

                if (productoBD != null && productoBD.Cantidad >= cant && productoBD.Cantidad - cant >= productoBD.StockMinimo)
                {
                    // Buscar el producto en el carrito por su Id
                    Product productoExistente = ClassCarritoDatos.ProductosEnCarrito.FirstOrDefault(p => p.Id == producto.Id);

                    if (productoExistente != null)
                    {
                        // Si el producto ya está en el carrito, actualiza la cantidad
                        if (productoExistente.CantEnCart < productoBD.Cantidad && productoBD.CantEnCart + cant >= productoBD.StockMinimo)
                        {
                            productoExistente.CantEnCart += cant;
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



        private List<Product> ObtenerProductosDesdeBD(string filtro, int categoriaId)
        {
            using (var context = new BdCybergearContext())
            {
                IQueryable<Product> productosQuery = context.Products;

                // Filtra por nombre de producto si hay un filtro
                if (!string.IsNullOrEmpty(filtro))
                {
                    productosQuery = productosQuery.Where(p => p.NombreProducto.Contains(filtro));
                }

                // Filtra por categoría
                if (categoriaId != 0) // 0 podría ser el valor por defecto para "Todas las categorías"
                {
                    productosQuery = productosQuery.Where(p => p.CategoriaId == categoriaId);
                }

                // Filtra solo los productos activos
                productosQuery = productosQuery.Where(p => p.Activo == "SI");

                // Obtén los productos
                List<Product> productosDesdeBD = productosQuery.ToList();

                

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

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarProductosConFiltro(textBoxBusqueda.Text, ObtenerCategoriaSeleccionada());
        }



        private void CargarCategorias()
        {
            // cargar las categorías desde la base de datos y agregarlas al ComboBox
            
            using (var context = new BdCybergearContext())
            {
                var categorias = context.Categoria.ToList();

                // Agrega una opción vacía al principio de la lista
                categorias.Insert(0, new Categorium { IdCategoria = 0, CategoriaNombre = "Seleccionar Categoría" });

                cbFiltroCategorias.DataSource = categorias;
                cbFiltroCategorias.DisplayMember = "CategoriaNombre"; // Ajusta esto según tu modelo
                cbFiltroCategorias.ValueMember = "IdCategoria"; // Ajusta esto según tu modelo
            }
        }
        private int ObtenerCategoriaSeleccionada()
        {
            // Retorna el valor de la categoría seleccionada en el ComboBox
            return (int)cbFiltroCategorias.SelectedValue;
        }

        private void cbFiltroCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vuelve a cargar los productos desde la base de datos con el nuevo filtro de categoría
            CargarProductosConFiltro(textBoxBusqueda.Text, ObtenerCategoriaSeleccionada());
        }


        private void CargarProductosConFiltro(string filtro, int categoriaId)
        {
            // Obtén los productos desde la base de datos con el filtro de búsqueda y categoría
            List<Product> productosFiltrados = ObtenerProductosDesdeBD(filtro, categoriaId);

            // Limpia el catálogo actual
            flowLayoutPanel1.Controls.Clear();

            // Llena el catálogo con los productos filtrados
            foreach (var producto in productosFiltrados)
            {
                var productoControl = new ProductoControl(producto, 1, AgregarAlCarrito);
                flowLayoutPanel1.Controls.Add(productoControl);
            }
        }








    }
}


