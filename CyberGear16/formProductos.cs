using System;
using System.Collections.Generic;
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


namespace CyberGear16
{
    public partial class formProductos : Form
    {
        private readonly BdCybergearContext _context; // DbContext de Entity Framework
        public formProductos(BdCybergearContext context)
        {
            InitializeComponent();



            _context = context;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\"; // Cambia la ruta según tu ubicación.
            openFileDialog1.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                txtFoto.Text = openFileDialog1.FileName;


                // Crear una carpeta "Images" dentro de la carpeta del proyecto
                string carpetaDestino = Path.Combine(Application.StartupPath, "Fotos");
                Directory.CreateDirectory(carpetaDestino);

                // Obtener el nombre del archivo
                string nombreArchivo = Path.GetFileName(openFileDialog1.FileName);

                // Combinar la carpeta de destino con el nombre del archivo
                string rutaArchivoDestino = Path.Combine(carpetaDestino, nombreArchivo);

                try
                {
                    // Copiar el archivo a la carpeta de destino
                    File.Copy(openFileDialog1.FileName, rutaArchivoDestino);

                    // Ahora tienes la imagen guardada en 'rutaArchivoDestino'
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Acciones"].Index)
            {
                // Obtén el producto seleccionado
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int productId = Convert.ToInt32(row.Cells["Id"].Value); // Asegúrate de tener una columna "IdProducto" para identificar el producto

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

            if (validarCampos() && double.TryParse(textBox2.Text, out precio) && int.TryParse(textBox3.Text, out stock))
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
                            CategoriaId = idCategoria + 1,
                            Cantidad = stock
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
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en los campos.");
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
            comboBoxCategorias.SelectedIndex = -1;
        }

        private void CargarDatosEnDataGridView()
        {
            using (var context = new BdCybergearContext())
            {
                // Vuelve a cargar los datos en el DataGridView para reflejar los cambios.
                var productos = context.Products
                .Select(p => new
                {
                    p.Id,
                    p.NombreProducto,
                    p.PrecioProducto,
                    p.Descripcion,
                    p.Cantidad,
                    p.CategoriaId,
                    p.Activo
                })
                .ToList();

                dataGridView1.DataSource = productos;
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
            comboBoxCategorias.Items.Add("Videjuegos");
            comboBoxCategorias.Items.Add("PC-componentes");

            using (var context = new BdCybergearContext()) // se lo engloba en un using para q se cierre la conexion
            {
                // Consulta los productos desde la base de datos
                var products = context.Products
                    .Select(p => new
                    {
                        p.Id,
                        p.NombreProducto,
                        p.PrecioProducto,
                        p.Descripcion,
                        p.Cantidad,
                        p.CategoriaId,
                        p.Activo
                    })
                    .ToList();

                // Asigna los productos a la fuente de datos del DataGridView
                dataGridView1.DataSource = products;

                // Configura el estilo y columnas del DataGridView
                // (asegúrate de que las propiedades de Product se correspondan con las columnas)

                dataGridView1.Columns["Id"].Width = 40;
                dataGridView1.Columns["NombreProducto"].Width = 150;
                dataGridView1.Columns["PrecioProducto"].Width = 100;
                dataGridView1.Columns["Descripcion"].Width = 200;
                dataGridView1.Columns["Cantidad"].Width = 100;
                dataGridView1.Columns["CategoriaId"].Width = 100;
                dataGridView1.Columns["Activo"].Width = 100;

                DataGridViewButtonColumn eliminarButtonColumn = new DataGridViewButtonColumn();
                eliminarButtonColumn.Name = "Acciones";
                eliminarButtonColumn.Text = "Editar/Baja";
                eliminarButtonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(eliminarButtonColumn);


                // Cambia el color de fuente a negro para todas las celdas del DataGridView
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

                // Oculta las columnas no deseadas (en este caso, ocultamos todas las demás)
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.Name != "Id" && column.Name != "NombreProducto" && column.Name != "PrecioProducto" && column.Name != "Descripcion" &&
                        column.Name != "Cantidad" && column.Name != "Acciones" && column.Name != "CategoriaId" &&
                        column.Name != "Activo")
                    {
                        column.Visible = false;
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
