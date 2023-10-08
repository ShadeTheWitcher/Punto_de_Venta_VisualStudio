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

        private byte[] imagenBytes; // Variable para almacenar los bytes de la imagen


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
                            CategoriaId = idCategoria + 1,
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
            comboBoxCategorias.SelectedIndex = -1;
            txtFoto.Clear();
            pictureBox1.Image =  null;

            // Restablecer el PictureBox a su estado original
            if (pictureBox1.Image == null)
            {
                // Si no hay una imagen seleccionada, establecer la imagen inicial
                pictureBox1.Image = pictureBox1.InitialImage;
            }
            

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
                ocultarColumnasExtra();
                dataGridView1.Columns["Id"].Width = 40;
            }
        }


        private void ocultarColumnasExtra()
        {
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
                var productosFiltrados = context.Products.Where(p => p.Activo == "Si").ToList();

                // Enlazar los resultados al DataGridView.
                dataGridView1.DataSource = productosFiltrados;
                ocultarColumnasExtra();
            }
        }

        private void BInactivo_Click(object sender, EventArgs e)
        {
            using (var context = new BdCybergearContext())
            {
                var productosFiltrados = context.Products.Where(p => p.Activo == "NO").ToList();

                // Enlazar los resultados al DataGridView.
                dataGridView1.DataSource = productosFiltrados;
                ocultarColumnasExtra();

            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        private void BuscarEnBaseDeDatosYActualizarDataGridView(string buscar)
        {
            using (var context = new BdCybergearContext())
            {

                var resultados = context.Products.Where(e => e.NombreProducto.Contains(buscar)).ToList();
                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se han encontrado usuarios que coincidan con la busqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dataGridView1.DataSource = resultados;
                    ocultarColumnasExtra();
                }
            }
        }

        private void TBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter))
            {
                if (!string.IsNullOrEmpty(TBuscar.Text))
                {
                    string buscar = TBuscar.Text;
                    // Llama a un método que realiza la búsqueda en la base de datos y actualiza el DataGridView.
                    BuscarEnBaseDeDatosYActualizarDataGridView(buscar);
                }
                else
                {
                    MessageBox.Show("No hay elementos para buscar. Por favor escriba algo y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBuscar.Text))
            {
                string buscar = TBuscar.Text;
                // Llama a un método que realiza la búsqueda en la base de datos y actualiza el DataGridView.
                BuscarEnBaseDeDatosYActualizarDataGridView(buscar);


            }
            else
            {
                MessageBox.Show("No hay elementos para buscar. Por favor escriba algo y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


        
        private void button2_Click_1(object sender, EventArgs e)
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

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }
    }
}
