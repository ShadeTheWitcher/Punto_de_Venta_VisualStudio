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
    public partial class FormSeccionVentas : Form
    {
        private readonly BdCybergearContext _context; // DbContext de Entity Framework
        private string NombreUserIniciado;
        public FormSeccionVentas(BdCybergearContext context, string userArgs)
        {
            InitializeComponent();
            NombreUserIniciado = userArgs;
            _context = context;

        }

        private void FormSeccionVentas_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("A");
            comboBox2.Items.Add("B");


            cBoxCategorias.Items.Add("Videjuegos");
            cBoxCategorias.Items.Add("PC-componentes");


            textBox2.Text = NombreUserIniciado;

            DataGridViewButtonColumn eliminarButtonColumn = new DataGridViewButtonColumn();
            eliminarButtonColumn.Name = "Acciones";
            eliminarButtonColumn.Text = "Quitar";
            eliminarButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(eliminarButtonColumn);



            // Agregar productos de ejemplo
            //dataGridView1.Rows.Add("Producto 1", 10.99, 2, "juego");  // Nombre, Precio, Cantidad
            //dataGridView1.Rows.Add("Producto 2", 15.49, 1, "juego");
            //dataGridView1.Rows.Add("Producto 3", 5.99, 3, "PC_componentes");

            //calcularMostrarPrecioTotal();


        }

        private void calcularMostrarPrecioTotal()
        {

            // Calcular el precio total y mostrar el subtotal
            double precioTotal = 0.0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double precio = Convert.ToDouble(row.Cells[1].Value);
                int cantidad = Convert.ToInt32(row.Cells[2].Value);
                double subtotal = precio * cantidad;

                // Actualizar la celda de Subtotal con el valor calculado
                row.Cells[4].Value = subtotal;

                precioTotal += subtotal;
            }





            // Mostrar el precio total
            textBox9.Text = precioTotal.ToString("0.00");
        }


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox4.Text, out int dniCliente))
            {
                using (var context = new BdCybergearContext())
                {
                    // Realiza tus operaciones de base de datos aquí

                    // Buscar el cliente por DNI
                    Cliente clienteDesdeBD = context.Clientes.FirstOrDefault(c => c.Dni == dniCliente);

                    // Verificar si se encontró el cliente
                    if (clienteDesdeBD != null)
                    {
                        // Rellena los campos con los datos del cliente
                        textBox3.Text = clienteDesdeBD.Nombre;
                        //textBoxApellidoCliente.Text = clienteDesdeBD.Apellido;

                        // Cambia el texto en rojo por "Cliente asignado"
                        label17.Text = "Cliente asignado";
                        label17.ForeColor = Color.Green;  // Puedes ajustar el color según tu preferencia
                    }
                    else
                    {
                        // Cliente no encontrado en la base de datos
                        MessageBox.Show("Cliente no encontrado");

                        // Restablece los campos y el estado del cliente
                        textBox4.Text = string.Empty;
                        //textBoxApellidoCliente.Text = string.Empty;
                        label17.Text = "Cliente No asignado";
                        label17.ForeColor = Color.DarkRed;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un DNI válido (número entero).");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Añade los datos al carrito directamente desde los campos
            string nombreProducto = textBox5.Text;
            double precioProducto = Convert.ToDouble(textBox8.Text);
            int cantidad = (int)numericUpDown1.Value;
            string categoria = cBoxCategorias.Text; // Asigna la descripción según sea necesario.

            // Busca el producto en la tabla
            bool productoExistente = false;
            foreach (DataGridViewRow filaExistente in dataGridView1.Rows)
            {
                if (filaExistente.Cells[0].Value != null && filaExistente.Cells[0].Value.ToString() == nombreProducto)
                {
                    // El producto ya está en la tabla, actualiza la cantidad
                    int cantidadExistente = (int)filaExistente.Cells[2].Value;
                    filaExistente.Cells[2].Value = cantidadExistente + cantidad;

                    // Calcula y muestra el precio total
                    calcularMostrarPrecioTotal();

                    productoExistente = true;
                    break;
                }
            }

            if (!productoExistente)
            {
                // Añade la fila al DataGridView
                DataGridViewRow nuevaFila = new DataGridViewRow();
                nuevaFila.CreateCells(dataGridView1);

                nuevaFila.Cells[0].Value = nombreProducto;
                nuevaFila.Cells[1].Value = precioProducto;
                nuevaFila.Cells[2].Value = cantidad;
                nuevaFila.Cells[3].Value = categoria;

                // Calcula y muestra el precio total
                dataGridView1.Rows.Add(nuevaFila);
                calcularMostrarPrecioTotal();
            }
        }

        private void button5_Click(object sender, EventArgs e) //buscar
        {
            // Aquí deberías recuperar los datos del producto desde la base de datos
            // utilizando el valor ingresado en textBox5, que es el nombre del producto.
            // Supongamos que obtienes un objeto de tipo Product con los datos del producto.

            using (var context = new BdCybergearContext())
            {
                // Realiza tus operaciones de base de datos aquí

                // Simulación de datos de producto
                Product productoDesdeBD = context.Products.FirstOrDefault(p => p.NombreProducto == textBox5.Text);

                // Verifica si se encontró el producto
                if (productoDesdeBD != null)
                {
                    // Rellena los campos con los datos del producto
                    textBox6.Text = productoDesdeBD.Descripcion;
                    textBox8.Text = productoDesdeBD.PrecioProducto.ToString();
                    textBox7.Text = productoDesdeBD.Cantidad.ToString();
                    cBoxCategorias.SelectedIndex = productoDesdeBD.CategoriaId - 1;


                    // establecer la cantidad predeterminada
                    numericUpDown1.Value = 1;
                }
                else
                {
                    // Producto no encontrado en la base de datos
                    MessageBox.Show("Producto no encontrado");
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vaciarCliente();
        }

        private void vaciarCliente()
        {
            // Restablece los campos y el estado del cliente
            textBox3.Text = string.Empty;
            //textBoxApellidoCliente.Text = string.Empty;
            label17.Text = "Cliente No asignado";
            label17.ForeColor = Color.DarkRed;

            
        }


        private void vaciarProducto()
        {
            textBox6.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox7.Text = string.Empty;
            cBoxCategorias.SelectedIndex = - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vaciarCliente();
            vaciarProducto();

        }
    }
}
