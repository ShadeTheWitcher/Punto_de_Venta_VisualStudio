using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using CyberGear16.Models; // importar el espacio de nombres de tus modelos
using CyberGear16.WindowsForms.SeccionProducto.Categoria;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CyberGear16
{
    public partial class formProductos : Form
    {
        private readonly BdCybergearContext _context; // DbContext de Entity Framework
        private Panel panelCrudCategoria;
        public formProductos(BdCybergearContext context)
        {
            InitializeComponent();



            _context = context;
        }

        private byte[] imagenBytes; // Variable para almacenar los bytes de la imagen


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns[7].Index)
            {
                // Obtén el producto seleccionado
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int productId = Convert.ToInt32(row.Cells[0].Value); // Asegúrate de tener una columna "IdProducto" para identificar el producto

                // Abre el formulario de detalles/editar con el producto seleccionado
                formEditorProducto editorProducto = new formEditorProducto(productId, _context);
                editorProducto.ShowDialog();
                CargarDatosEnDataGridView();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precio = 0;
            int stock = 0;
            int stock_min = 0;

            if (validarCampos() && double.TryParse(textBox2.Text, out precio) && int.TryParse(textBox3.Text, out stock) && int.TryParse(textBox5.Text, out stock_min))
            {
                string nombre = textBox1.Text;
                string descripcion = textBox4.Text;
                int idCategoria = comboBoxCategorias.SelectedIndex;

                try
                {
                    using (var context = new BdCybergearContext()) // Crea un nuevo contexto
                    {
                        // Crea una nueva instancia de Producto y configura sus propiedades.
                        Product nuevoProducto = new Product
                        {
                            NombreProducto = nombre,
                            PrecioProducto = precio,
                            Descripcion = descripcion,
                            StockMinimo = stock_min,
                            CategoriaId = idCategoria,
                            Cantidad = stock,
                            Imagen = imagenBytes // Asigna los bytes de la imagen al producto
                        };

                        // Agrega el producto al contexto.
                        context.Products.Add(nuevoProducto);

                        // Guarda los cambios en la base de datos.
                        context.SaveChanges();

                        MessageBox.Show("Producto agregado correctamente");
                        LimpiarCampos();
                        CargarDatosEnDataGridView();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, comingresa valores numéricos válidos en los campos.");
            }
        }


        public bool validarCampos()
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                comboBoxCategorias.SelectedIndex == -1)
            {
                MessageBox.Show("Campos incompletos");
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBoxCategorias.SelectedIndex = -1;
            txtFoto.Clear();
            pictureBox1.Image = null;

            // Restablecer el PictureBox a su estado original
            if (pictureBox1.Image == null)
            {
                // Si no hay una imagen seleccionada, establecer la imagen inicial
                pictureBox1.Image = pictureBox1.InitialImage;
            }


        }


        private string GetCategoryName(int categoryId)
        {

            using (var context = new BdCybergearContext())
            {
                var categoria = context.Categoria
                               .FirstOrDefault(c => c.IdCategoria == categoryId);

                if (categoria != null)
                {
                    return categoria.CategoriaNombre;
                }
                else
                {
                    // Manejar el caso en el que no se encuentra la categoría con la ID dada
                    return "Categoría no encontrada";
                }

            }



        }



        private void CargarDatosEnDataGridView(string filtro = "")
        {
            using (var context = new BdCybergearContext())
            {
                IQueryable<Product> productosQuery = context.Products;

                // Aplicar filtro si se proporciona
                if (!string.IsNullOrEmpty(filtro))
                {
                    productosQuery = productosQuery.Where(p => p.NombreProducto.Contains(filtro));
                }

                // Obtener los productos
                List<Product> productosDesdeBD = productosQuery.ToList();

                // Limpiar las filas
                dataGridView1.Rows.Clear();

                // Cambiar el color de fuente a negro para todas las celdas del DataGridView
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

                foreach (var productoDesdeBD in productosDesdeBD)
                {
                    // Extraer la información de la base de datos
                    int id_producto = productoDesdeBD.Id;
                    string nombreProducto = productoDesdeBD.NombreProducto ?? "";
                    double precioProducto = productoDesdeBD.PrecioProducto ?? 0;
                    string descripcionProducto = productoDesdeBD.Descripcion;
                    int cantidad = productoDesdeBD.Cantidad;
                    int categoriId = productoDesdeBD.CategoriaId;

                    string categoria = GetCategoryName(categoriId); // Según el id irá una categoría

                    // Crear una nueva fila en la tabla
                    DataGridViewRow nuevaFila = new DataGridViewRow();
                    nuevaFila.CreateCells(dataGridView1);

                    nuevaFila.Cells[0].Value = id_producto;
                    nuevaFila.Cells[1].Value = nombreProducto;
                    nuevaFila.Cells[2].Value = descripcionProducto;
                    nuevaFila.Cells[3].Value = precioProducto;
                    nuevaFila.Cells[4].Value = cantidad;
                    nuevaFila.Cells[5].Value = categoria;

                    // Añadir la fila al DataGridView
                    dataGridView1.Rows.Add(nuevaFila);

                    // Cargar y mostrar la imagen si está disponible
                    byte[] Imagen = productoDesdeBD.Imagen;
                    if (Imagen != null && Imagen.Length > 0)
                    {
                        dataGridView1.Columns[6].Width = 80; // Ajustar el ancho según sea necesario
                        dataGridView1.Columns[6].DefaultCellStyle.NullValue = null;

                        using (MemoryStream ms = new MemoryStream(Imagen))
                        {
                            Image originalImage = Image.FromStream(ms);

                            // Redimensionar la imagen manteniendo la relación de aspecto
                            int nuevoAncho = 80; // Ancho deseado
                            int nuevoAlto = (int)((double)originalImage.Height / originalImage.Width * nuevoAncho);
                            Image imagenRedimensionada = new Bitmap(originalImage, nuevoAncho, nuevoAlto);

                            nuevaFila.Cells[6].Value = imagenRedimensionada; // Imagen redimensionada
                        }
                    }
                }
            }
        }





        //public void InsertarProducto(string nombre, double precio, string descripcion, int categoriaId, int cantidad)
        //{
        //    string connectionString = "server=localhost;database=bd_cybergear;Uid=root ";

        //    using (MySqlConnection connection = new MySqlConnection(connectionString)) //al estar en un "using" la conexion se cierra automaticamente luego de terminar estas sentencias
        //    {
        //        connection.Open();

        //        string query = "INSERT INTO products (nombre_producto, precio_producto, descripcion, categoria_id, cantidad) " +
        //                       "VALUES (@nombre, @precio, @descripcion, @categoriaId, @cantidad)";

        //        using (MySqlCommand command = new MySqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@nombre", nombre);
        //            command.Parameters.AddWithValue("@precio", precio);
        //            command.Parameters.AddWithValue("@descripcion", descripcion);
        //            command.Parameters.AddWithValue("@categoriaId", categoriaId);
        //            command.Parameters.AddWithValue("@cantidad", cantidad);
        //            //command.Parameters.AddWithValue("@imagen", imagen);

        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}








        private void formProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();


            CargarDatosEnDataGridView();



        }


        private void ocultarColumnasExtra()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name != "Id" && column.Name != "NombreProducto" && column.Name != "PrecioProducto" && column.Name != "Descripcion" &&
                    column.Name != "Cantidad" && column.Name != "Acciones" && column.Name != "CategoriaId" && column.Name != "CategoriaId" &&
                    column.Name != "Activo")
                {
                    column.Visible = false;
                }
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BActivos_Click(object sender, EventArgs e)
        {
            using (var context = new BdCybergearContext())
            {
                var productosFiltrados = context.Products.Where(p => p.Activo == "SI").ToList();

                // Limpia las filas existentes en el DataGridView
                dataGridView1.Rows.Clear();

                foreach (var productoFiltrado in productosFiltrados)
                {
                    int id_producto = productoFiltrado.Id;
                    string nombreProducto = productoFiltrado.NombreProducto ?? "";
                    double precioProducto = productoFiltrado.PrecioProducto ?? 0;
                    string descripcionProducto = productoFiltrado.Descripcion;
                    int cantidad = productoFiltrado.Cantidad;
                    int categoriaId = productoFiltrado.CategoriaId;

                    // Usa el método GetCategoryName para obtener el nombre de la categoría
                    string categoria = GetCategoryName(categoriaId);

                    // Crea una nueva fila y asigna los valores
                    DataGridViewRow nuevaFila = new DataGridViewRow();
                    nuevaFila.CreateCells(dataGridView1);

                    nuevaFila.Cells[0].Value = id_producto;
                    nuevaFila.Cells[1].Value = nombreProducto;
                    nuevaFila.Cells[2].Value = descripcionProducto;
                    nuevaFila.Cells[3].Value = precioProducto;
                    nuevaFila.Cells[4].Value = cantidad;
                    nuevaFila.Cells[5].Value = categoria;

                    // Añade la fila al DataGridView
                    dataGridView1.Rows.Add(nuevaFila);

                    // Carga y muestra la imagen si está disponible
                    byte[] Imagen = productoFiltrado.Imagen;
                    if (Imagen != null && Imagen.Length > 0)
                    {
                        dataGridView1.Columns[6].Width = 80; // Ajusta el ancho según sea necesario
                        dataGridView1.Columns[6].DefaultCellStyle.NullValue = null;

                        using (MemoryStream ms = new MemoryStream(Imagen))
                        {
                            Image originalImage = Image.FromStream(ms);

                            // Redimensiona la imagen manteniendo la relación de aspecto
                            int nuevoAncho = 80; // Ancho deseado
                            int nuevoAlto = (int)((double)originalImage.Height / originalImage.Width * nuevoAncho);
                            Image imagenRedimensionada = new Bitmap(originalImage, nuevoAncho, nuevoAlto);

                            nuevaFila.Cells[6].Value = imagenRedimensionada; // Imagen redimensionada
                        }
                    }
                }
            }
        }

        private void BInactivo_Click(object sender, EventArgs e)
        {
            using (var context = new BdCybergearContext())
            {
                var productosFiltrados = context.Products.Where(p => p.Activo == "NO").ToList();

                // Limpia las filas existentes en el DataGridView
                dataGridView1.Rows.Clear();

                foreach (var productoFiltrado in productosFiltrados)
                {
                    int id_producto = productoFiltrado.Id;
                    string nombreProducto = productoFiltrado.NombreProducto ?? "";
                    double precioProducto = productoFiltrado.PrecioProducto ?? 0;
                    string descripcionProducto = productoFiltrado.Descripcion;
                    int cantidad = productoFiltrado.Cantidad;
                    int categoriaId = productoFiltrado.CategoriaId;

                    // Usa el método GetCategoryName para obtener el nombre de la categoría
                    string categoria = GetCategoryName(categoriaId);

                    // Crea una nueva fila y asigna los valores
                    DataGridViewRow nuevaFila = new DataGridViewRow();
                    nuevaFila.CreateCells(dataGridView1);

                    nuevaFila.Cells[0].Value = id_producto;
                    nuevaFila.Cells[1].Value = nombreProducto;
                    nuevaFila.Cells[2].Value = descripcionProducto;
                    nuevaFila.Cells[3].Value = precioProducto;
                    nuevaFila.Cells[4].Value = cantidad;
                    nuevaFila.Cells[5].Value = categoria;

                    // Añade la fila al DataGridView
                    dataGridView1.Rows.Add(nuevaFila);

                    // Carga y muestra la imagen si está disponible
                    byte[] Imagen = productoFiltrado.Imagen;
                    if (Imagen != null && Imagen.Length > 0)
                    {
                        dataGridView1.Columns[6].Width = 80; // Ajusta el ancho según sea necesario
                        dataGridView1.Columns[6].DefaultCellStyle.NullValue = null;

                        using (MemoryStream ms = new MemoryStream(Imagen))
                        {
                            Image originalImage = Image.FromStream(ms);

                            // Redimensiona la imagen manteniendo la relación de aspecto
                            int nuevoAncho = 80; // Ancho deseado
                            int nuevoAlto = (int)((double)originalImage.Height / originalImage.Width * nuevoAncho);
                            Image imagenRedimensionada = new Bitmap(originalImage, nuevoAncho, nuevoAlto);

                            nuevaFila.Cells[6].Value = imagenRedimensionada; // Imagen redimensionada
                        }
                    }
                }
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        private void BuscarEnBaseDeDatosYActualizarDataGridView(string buscar)
        {
            CargarDatosEnDataGridView(buscar);
        }

        private void RealizarBusqueda()
        {
            if (!string.IsNullOrEmpty(TBuscar.Text))
            {
                string buscar = TBuscar.Text;
                // Llama al método que realiza la búsqueda en la base de datos y actualiza el DataGridView.
                BuscarEnBaseDeDatosYActualizarDataGridView(buscar);
            }
            else
            {
                // Si no hay texto, carga todos los datos
                CargarDatosEnDataGridView();
            }
        }


        private void TBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                RealizarBusqueda();
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }




        private void TBuscar_TextChanged(object sender, EventArgs e)
        {

        }


        private void TBuscar_Click(object sender, EventArgs e)
        {
            bool borrarPrimeraVez = true;
            if (borrarPrimeraVez)
            {
                TBuscar.Clear();
                borrarPrimeraVez = false;
            }
        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBuscar.Text))
            {
                TBuscar.Clear();
                CargarDatosEnDataGridView();



            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void OPF1_FileOk(object sender, CancelEventArgs e)
        {

        }





        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //subir foto
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\"; // Establece el directorio inicial
                openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 1;



                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Convertir la imagen a bytes
                        imagenBytes = File.ReadAllBytes(openFileDialog.FileName);

                        // Mostrar la imagen 
                        pictureBox1.Image = Image.FromFile(openFileDialog.FileName);





                        // Ahora asigna la ruta del archivo al TextBox
                        txtFoto.Text = openFileDialog.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al leer la imagen: " + ex.Message);
                    }
                }
            }
        }

        private void CargarCategorias()
        {
            // cargar las categorías desde la base de datos y agregarlas al ComboBox

            using (var context = new BdCybergearContext())
            {
                var categorias = context.Categoria.ToList();

                // Agrega una opción vacía al principio de la lista
                categorias.Insert(0, new Categorium { IdCategoria = 0, CategoriaNombre = "Seleccionar Categoría" });

                comboBoxCategorias.DataSource = categorias;
                comboBoxCategorias.DisplayMember = "CategoriaNombre"; // Ajusta esto según tu modelo
                comboBoxCategorias.ValueMember = "IdCategoria"; // Ajusta esto según tu modelo
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Crear un panel para contener el formulario formCrudCategoria
            panelCrudCategoria = new Panel();
            panelCrudCategoria.Dock = DockStyle.Fill;

            // Crear una instancia del formulario formCrudCategoria
            formCrudCategoria formCategoria = new formCrudCategoria();

            // Configurar el tamaño y la posición del formulario
            formCategoria.TopLevel = false;
            formCategoria.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panelCrudCategoria.Controls.Add(formCategoria);

            // Agregar el panel al formulario
            Controls.Add(panelCrudCategoria);

            // Asegurar que el panel esté en la parte superior del z-order
            panelCrudCategoria.BringToFront();

            // Mostrar el panel (y el formulario dentro de él)
            panelCrudCategoria.Visible = true;
            formCategoria.Show();

            // Manejar el evento de cierre de formCrudCategoria
            formCategoria.FormClosed += (sender, args) =>
            {
                // Restaurar la visibilidad de cualquier contenido que pueda haber quedado oculto
                panelCrudCategoria.Visible = false;  // O establecer en false si lo prefieres
                CargarCategorias();
                CargarDatosEnDataGridView();
            };
        }







    }
}
