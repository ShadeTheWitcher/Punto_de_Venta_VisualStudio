using CyberGear16.Models;
using MySqlX.XDevAPI;
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
        private int dniUsuario;
        public FormSeccionVentas(BdCybergearContext context, int userArgs)
        {
            InitializeComponent();
            dniUsuario = userArgs;
            _context = context;

        }

        private void FormSeccionVentas_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("A");
            comboBox2.Items.Add("B");


            cBoxCategorias.Items.Add("Videjuegos");
            cBoxCategorias.Items.Add("PC-componentes");

            string nombreVendedor;

            using (var context = new BdCybergearContext())
            {
                Usuario vendedor = context.Usuarios.FirstOrDefault(u => u.Dni == dniUsuario);
                textBox10.Text = dniUsuario.ToString();

                // Verificar si se encontró al vendedor
                if (vendedor != null)
                {
                    // Acceder a la propiedad Nombre del vendedor
                    nombreVendedor = vendedor.Nombre;
                    textBox2.Text = nombreVendedor;
                }
                else
                {
                    // Manejar el caso en el que el vendedor no se encuentra
                    MessageBox.Show("Vendedor no encontrado");
                    return; // Salir del evento si no se encuentra el vendedor
                }

            }


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
                double precio = Convert.ToDouble(row.Cells[2].Value);
                int cantidad = Convert.ToInt32(row.Cells[3].Value);
                double subtotal = precio * cantidad;

                // Actualizar la celda de Subtotal con el valor calculado
                row.Cells[6].Value = subtotal;

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
            // Verifica que los campos requeridos estén llenos
            if (string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox8.Text) ||
                numericUpDown1.Value <= 0 ||
                string.IsNullOrWhiteSpace(cBoxCategorias.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de añadir al carrito.");
                return;
            }


            // Añade los datos al carrito directamente desde los campos
            string nombreProducto = textBox5.Text;
            double precioProducto = Convert.ToDouble(textBox8.Text);
            int cantidad = (int)numericUpDown1.Value;
            string categoria = cBoxCategorias.Text; // Asigna la descripción según sea necesario.
            int id_producto = int.Parse(tbIdProducto.Text); ;

            using (var context = new BdCybergearContext())
            {
                // Recupera el producto desde la base de datos
                Product productoDesdeBD = context.Products.FirstOrDefault(p => p.NombreProducto == nombreProducto);

                byte[] Imagen = productoDesdeBD.Imagen;





                if (productoDesdeBD != null)
                {
                    // Verifica el stock disponible y el stock mínimo
                    if (productoDesdeBD.Cantidad >= cantidad && productoDesdeBD.Cantidad - cantidad >= productoDesdeBD.StockMinimo)
                    {
                        bool productoExistente = false;
                        foreach (DataGridViewRow filaExistente in dataGridView1.Rows)
                        {
                            if (filaExistente.Cells[1].Value != null && filaExistente.Cells[1].Value.ToString() == nombreProducto)
                            {
                                // El producto ya está en la tabla, actualiza la cantidad
                                int cantidadExistente = (int)filaExistente.Cells[3].Value;
                                filaExistente.Cells[3].Value = cantidadExistente + cantidad;

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

                            nuevaFila.Cells[0].Value = id_producto;
                            nuevaFila.Cells[1].Value = nombreProducto;
                            nuevaFila.Cells[2].Value = precioProducto;
                            nuevaFila.Cells[3].Value = cantidad;
                            nuevaFila.Cells[4].Value = categoria;

                            // Asigna la imagen desde el arreglo de bytes
                            if (Imagen != null && Imagen.Length > 0)
                            {
                                dataGridView1.Columns[5].Width = 80; // Ajusta el ancho según sea necesario
                                dataGridView1.Columns[5].DefaultCellStyle.NullValue = null;



                                using (MemoryStream ms = new MemoryStream(Imagen))
                                {
                                    Image originalImage = Image.FromStream(ms);

                                    // Redimensiona la imagen manteniendo la relación de aspecto
                                    int nuevoAncho = 80; // Ancho deseado
                                    int nuevoAlto = (int)((double)originalImage.Height / originalImage.Width * nuevoAncho);
                                    Image imagenRedimensionada = new Bitmap(originalImage, nuevoAncho, nuevoAlto);

                                    nuevaFila.Cells[5].Value = imagenRedimensionada; // Imagen redimensionada
                                }




                            }


                            // Calcula y muestra el precio total
                            dataGridView1.Rows.Add(nuevaFila);
                            calcularMostrarPrecioTotal();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente stock disponible.");
                    }
                }
                else
                {
                    MessageBox.Show("Producto no encontrado en la base de datos");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e) //buscar
        {



            // Verifica que los campos requeridos estén llenos
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de buscar");
                return;
            }




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
                    tbIdProducto.Text = productoDesdeBD.Id.ToString();
                    textBox11.Text = productoDesdeBD.StockMinimo.ToString();
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
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox7.Text = string.Empty;
            cBoxCategorias.SelectedIndex = -1;
        }

        private void LimpiarCarrito()
        {
            // Limpia el contenido del DataGridView
            dataGridView1.Rows.Clear();
            textBox9.Text = string.Empty;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vaciarCliente();
            vaciarProducto();
            LimpiarCarrito();

        }

        //BOTON QUITAR CARRITO
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Acciones"].Index && e.RowIndex >= 0)
            {
                // Obtén la fila actual
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Elimina la fila del DataGridView
                dataGridView1.Rows.Remove(row);

                // Calcula y muestra el precio total
                calcularMostrarPrecioTotal();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Verifica si hay un cliente asignado
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("No hay un cliente asignado. Asigne un cliente antes de guardar la venta.");
                return;
            }

            // Verifica que haya productos en el carrito antes de intentar guardar la venta
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito. Añada productos antes de guardar la venta.");
                return;
            }

            using (var context = new BdCybergearContext())
            {
                // Obtener el DNI desde el TextBox
                int dniCliente = Convert.ToInt32(textBox4.Text);



                // Recupera la instancia del cliente por su ID
                Cliente cliente = context.Clientes.FirstOrDefault(c => c.Dni == dniCliente);
                // Verificar si se encontró al cliente
                if (cliente != null)
                {
                    // Aquí puedes acceder a la propiedad IdCliente de cliente
                    int idCliente = cliente.IdCliente;

                    // Ahora puedes usar idCliente como sea necesario
                }
                else
                {
                    // Manejar el caso en el que el cliente no se encuentra
                    MessageBox.Show("Cliente no encontrado");
                }

                // Recupera la instancia del usuario (vendedor) por su ID
                Usuario vendedor = context.Usuarios.FirstOrDefault(u => u.Dni == dniUsuario);

                if (vendedor == null)
                {
                    MessageBox.Show("Vendedor no encontrado. No se puede guardar la venta.");
                    return;
                }

                // Ahora puedes acceder a la propiedad Id de vendedor
                int idVendedor = vendedor.Id;

                // Crea una nueva instancia de VentasCabecera
                VentasCabecera nuevaVentaCabecera = new VentasCabecera
                {
                    Fecha = DateOnly.FromDateTime(DateTime.Now), // Puedes ajustar la fecha según sea necesario
                    IdCliente = cliente.IdCliente,
                    IdVendedor = vendedor.Id,



                    TotalVenta = double.TryParse(textBox9.Text, out double totalVenta) ? totalVenta : 0.0
                };

                // Añade la nueva venta al contexto
                context.VentasCabeceras.Add(nuevaVentaCabecera);
                context.SaveChanges(); // Guarda los cambios para obtener el ID generado automáticamente

                // Recorre las filas del DataGridView para agregar los detalles de la venta
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    // Recupera la instancia del producto por su ID
                    int productoId = (int)fila.Cells[0].Value;
                    Product producto = context.Products.FirstOrDefault(p => p.Id == productoId);
                    if (producto == null)
                    {
                        MessageBox.Show($"Producto con ID {productoId} no encontrado. No se puede guardar la venta.");
                        return;
                    }

                    // Crea una nueva instancia de VentasDetalle
                    VentasDetalle nuevoDetalle = new VentasDetalle
                    {
                        VentaId = nuevaVentaCabecera.Id,
                        ProductoId = producto.Id,
                        CantidadVenta = Convert.ToInt32(fila.Cells[3].Value),
                        Precio = (double)fila.Cells[2].Value,
                        SubTotal = (double)fila.Cells[2].Value * (int)fila.Cells[3].Value
                    };

                    // Añade el nuevo detalle al contexto
                    context.VentasDetalles.Add(nuevoDetalle);
                }

                // Guarda los cambios en la base de datos
                context.SaveChanges();

                

                // Actualiza la cantidad vendida en la tabla de productos
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    int productoId = (int)fila.Cells[0].Value;
                    int cantidadVendida = Convert.ToInt32(fila.Cells[3].Value);

                    // Recupera la instancia del producto por su ID
                    Product producto = context.Products.FirstOrDefault(p => p.Id == productoId);
                    if (producto != null)
                    {
                        // Resta la cantidad vendida de la cantidad actual del producto
                        producto.Cantidad -= cantidadVendida;

                        // Guarda los cambios en la base de datos
                        context.SaveChanges();
                    }
                }


                MessageBox.Show("Venta guardada exitosamente.");

                // Limpia el carrito después de guardar la venta
                LimpiarCarrito();

            }


        }












    }
}
