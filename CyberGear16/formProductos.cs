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

namespace CyberGear16
{
    public partial class formProductos : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=localhost;database=bd_cybergear;Uid=root");
        public formProductos()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);

            comboBoxCategorias.Items.Add("Videjuegos");
            comboBoxCategorias.Items.Add("PC-componentes");
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precio = 0;
            int stock;

            if (int.TryParse(textBox3.Text, out stock) && Double.TryParse(textBox2.Text, out precio))
            {
                // Ahora puedes utilizar valor1 y valor2 como números enteros válidos.
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en los campos.");
            }



            string nombre = textBox1.Text;
            int idCategoria = comboBoxCategorias.SelectedIndex;

            string descripcion = textBox4.Text;
            //int stock = int.Parse(textBox3.Text);



            try
            {
                if (validarCampos())
                {
                    InsertarProducto(nombre, precio, descripcion, idCategoria, stock);
                    MessageBox.Show("Producto agregado correctamente");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
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



        public void InsertarProducto(string nombre, double precio, string descripcion, int categoriaId, int cantidad)
        {
            string connectionString = "server=localhost;database=bd_cybergear;Uid=root ";

            using (MySqlConnection connection = new MySqlConnection(connectionString)) //al estar en un "using" la conexion se cierra automaticamente luego de terminar estas sentencias
            {
                connection.Open();

                string query = "INSERT INTO products (nombre_producto, precio_producto, descripcion, categoria_id, cantidad) " +
                               "VALUES (@nombre, @precio, @descripcion, @categoriaId, @cantidad)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@categoriaId", categoriaId);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    //command.Parameters.AddWithValue("@imagen", imagen);

                    command.ExecuteNonQuery();
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            // Crea una nueva consulta SQL personalizada
            string sql = "SELECT nombre_producto, precio_producto, descripcion, cantidad, categoria_id, activo  FROM products";

            // Crea un adaptador de datos para ejecutar la consulta y llenar un DataTable
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexion);
            DataTable dataTable = new DataTable();



            // Abre la conexión y llena el DataTable
            conexion.Open();
            adapter.Fill(dataTable);

            // Asigna el DataTable como origen de datos para el DataGridView
            dataGridView1.DataSource = dataTable;

            // Asigna el color de texto negro como estilo predeterminado
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            // Establece el ancho de las columnas (ajusta los números según sea necesario)
            dataGridView1.Columns["nombre_producto"].Width = 150;
            dataGridView1.Columns["precio_producto"].Width = 100;
            dataGridView1.Columns["descripcion"].Width = 200;
            dataGridView1.Columns["cantidad"].Width = 100;
            dataGridView1.Columns["categoria_id"].Width = 100;
            dataGridView1.Columns["activo"].Width = 100;
            DataGridViewButtonColumn eliminarButtonColumn = new DataGridViewButtonColumn();
            eliminarButtonColumn.Name = "Acciones";
            eliminarButtonColumn.Text = "Eliminar";
            eliminarButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(eliminarButtonColumn);

            // Oculta las columnas no deseadas (en este caso, ocultamos todas las demás)
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name != "nombre_producto" && column.Name != "precio_producto" && column.Name != "descripcion" && column.Name != "cantidad" && column.Name != "Acciones" && column.Name != "categoria_id" && column.Name != "activo")
                {
                    column.Visible = false;

                }


            }

            conexion.Close();

        }





    }
}
