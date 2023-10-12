using CyberGear16.Models;
using CyberGear16.WindowsForms.Seccion_Catalogo;
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

        private List<Product> productosEnCarrito; // Declarar como un campo de clase

        private readonly BdCybergearContext _context; // DbContext de Entity Framework
        private int dniUsuario;
        private bool carritoLoad;
        public FormSeccionVentas(BdCybergearContext context, int userArgs)
        {
            InitializeComponent();
            dniUsuario = userArgs;
            _context = context;
            CustomizeDataGridView();
        }

        private void FormSeccionVentas_Load(object sender, EventArgs e)
        {
            carritoLoad = true;
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


            // Acceder a los productos en el carrito desde otro formulario o clase
            productosEnCarrito = ClassCarritoDatos.ProductosEnCarrito;

            // Verificar si la lista está vacía antes de realizar operaciones
            if (productosEnCarrito != null && productosEnCarrito.Any())
            {
                // La lista no está vacía, puedes realizar operaciones con ella
                foreach (var producto in productosEnCarrito)
                {
                    string categoriaNombre;

                    // Verifica el valor de CategoriaId y asigna la cadena correspondiente
                    if (producto.CategoriaId == 1)
                    {
                        categoriaNombre = "Videojuegos";
                    }
                    else if (producto.CategoriaId == 2)
                    {
                        categoriaNombre = "PC-Componente";
                    }
                    else
                    {
                        // Trata otros valores según sea necesario
                        categoriaNombre = "Otra categoría";
                    }


                    AgregarProductoAlCarrito(producto.Id, producto.NombreProducto, Convert.ToDouble(producto.PrecioProducto), producto.CantEnCart, categoriaNombre, producto.Imagen);

                }
            }
            else
            {
                // La lista está vacía, realiza alguna acción o muestra un mensaje según tus necesidades
                Console.WriteLine("El carrito está vacío.");
            }

            carritoLoad = false;

        }


        private void AgregarProductoAlCarrito(int id, string nombre, double precio, int cantidad, string categoria, byte[] imagen)
        {


            using (var context = new BdCybergearContext())
            {
                // Verifica el stock disponible y el stock mínimo
                if (context.Products.Any(p => p.Id == id && p.Cantidad >= cantidad && p.Cantidad - cantidad >= p.StockMinimo))
                {
                    bool productoExistente = false;

                    foreach (DataGridViewRow filaExistente in dataGridView1.Rows)
                    {
                        if (filaExistente.Cells[0].Value != null && Convert.ToInt32(filaExistente.Cells[0].Value) == id)
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

                        nuevaFila.Cells[0].Value = id;
                        nuevaFila.Cells[1].Value = nombre;
                        nuevaFila.Cells[2].Value = precio;
                        nuevaFila.Cells[3].Value = cantidad;
                        nuevaFila.Cells[4].Value = categoria;

                        // Asigna la imagen desde el arreglo de bytes
                        if (imagen != null && imagen.Length > 0)
                        {
                            dataGridView1.Columns[5].Width = 80; // Ajusta el ancho según sea necesario
                            dataGridView1.Columns[5].DefaultCellStyle.NullValue = null;

                            using (MemoryStream ms = new MemoryStream(imagen))
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

                        if (carritoLoad != true)
                        {
                            // Buscar el producto en el carrito por su Id
                            Product productoExistenteGlobal = ClassCarritoDatos.ProductosEnCarrito.FirstOrDefault(p => p.Id == id);

                            if (productoExistenteGlobal != null)
                            {
                                // Si el producto ya está en el carrito, actualiza la cantidad
                                productoExistenteGlobal.CantEnCart += cantidad;
                            }
                            else
                            {
                                Product producto = context.Products.FirstOrDefault(p => p.Id == id);

                                // Si el producto no está en el carrito, agrégalo
                                ClassCarritoDatos.ProductosEnCarrito.Add(new Product
                                {
                                    Id = id,
                                    NombreProducto = nombre,
                                    PrecioProducto = precio,
                                    CantEnCart = cantidad,
                                    CategoriaId = producto.CategoriaId,
                                    Imagen = imagen,
                                });
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock disponible.");
                }
            }


        }

        //private void AgregarProductoAlCarrito(int id, string nombre, double precio, int cantidad, string categoria, byte[] imagen)
        //{


        //    using (var context = new BdCybergearContext())
        //    {
        //        // Verifica el stock disponible y el stock mínimo
        //        if (context.Products.Any(p => p.Id == id && p.Cantidad >= cantidad && p.Cantidad - cantidad >= p.StockMinimo))
        //        {
        //            // Guardar en la clase global

        //            bool productoExistente = false;
        //            foreach (DataGridViewRow filaExistente in dataGridView1.Rows)
        //            {
        //                if (filaExistente.Cells[0].Value != null && Convert.ToInt32(filaExistente.Cells[0].Value) == id)
        //                {
        //                    // El producto ya está en la tabla, actualiza la cantidad
        //                    int cantidadExistente = (int)filaExistente.Cells[3].Value;
        //                    filaExistente.Cells[3].Value = cantidadExistente + cantidad;

        //                    // Calcula y muestra el precio total
        //                    calcularMostrarPrecioTotal();

        //                    productoExistente = true;
        //                    break;
        //                }
        //            }

        //            if (!productoExistente)
        //            {
        //                // Añade la fila al DataGridView
        //                DataGridViewRow nuevaFila = new DataGridViewRow();
        //                nuevaFila.CreateCells(dataGridView1);

        //                nuevaFila.Cells[0].Value = id;
        //                nuevaFila.Cells[1].Value = nombre;
        //                nuevaFila.Cells[2].Value = precio;
        //                nuevaFila.Cells[3].Value = cantidad;
        //                nuevaFila.Cells[4].Value = categoria;

        //                // Asigna la imagen desde el arreglo de bytes
        //                if (imagen != null && imagen.Length > 0)
        //                {
        //                    dataGridView1.Columns[5].Width = 80; // Ajusta el ancho según sea necesario
        //                    dataGridView1.Columns[5].DefaultCellStyle.NullValue = null;

        //                    using (MemoryStream ms = new MemoryStream(imagen))
        //                    {
        //                        Image originalImage = Image.FromStream(ms);

        //                        // Redimensiona la imagen manteniendo la relación de aspecto
        //                        int nuevoAncho = 80; // Ancho deseado
        //                        int nuevoAlto = (int)((double)originalImage.Height / originalImage.Width * nuevoAncho);
        //                        Image imagenRedimensionada = new Bitmap(originalImage, nuevoAncho, nuevoAlto);

        //                        nuevaFila.Cells[5].Value = imagenRedimensionada; // Imagen redimensionada
        //                    }
        //                }


        //                // Calcula y muestra el precio total
        //                dataGridView1.Rows.Add(nuevaFila);
        //                calcularMostrarPrecioTotal();

        //                if (carritoLoad != true)
        //                {
        //                    // Buscar el producto en el carrito por su Id
        //                    Product productoExistenteGlobal = ClassCarritoDatos.ProductosEnCarrito.FirstOrDefault(p => p.Id == id);

        //                    if (productoExistenteGlobal != null)
        //                    {
        //                        // Si el producto ya está en el carrito, actualiza la cantidad
        //                        productoExistenteGlobal.CantEnCart++;
        //                    }
        //                    else
        //                    {


        //                        ClassCarritoDatos.ProductosEnCarrito.Add(new Product
        //                        {
        //                            Id = id,
        //                            NombreProducto = nombre,
        //                            PrecioProducto = precio,
        //                            CantEnCart = cantidad,
        //                            CategoriaId = productoExistenteGlobal.CategoriaId,
        //                            Imagen = imagen,

        //                        });

        //                    }
        //                }

        //            }
        //        }

        //        else
        //        {
        //            MessageBox.Show("No hay suficiente stock disponible.");
        //        }
        //    }


        //}

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
            //carritoLoad = false;
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


                AgregarProductoAlCarrito(id_producto, nombreProducto, precioProducto, cantidad, categoria, Imagen);



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
            textBox4.Text = string.Empty;
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

            ClassCarritoDatos.ProductosEnCarrito.Clear();


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


                // Obtén el nombre del producto en la fila
                int id_producto = Convert.ToInt32(row.Cells[0].Value);

                EliminarProductoDeCarrito(id_producto); //elimina el producto de la lista globalmente


                // Elimina la fila del DataGridView
                dataGridView1.Rows.Remove(row);

                // Calcula y muestra el precio total
                calcularMostrarPrecioTotal();
            }

            if (e.ColumnIndex == dataGridView1.Columns[7].Index && e.RowIndex >= 0) //sumar producto
            {

                // Obtén la fila actual
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                // Obtén el nombre del producto en la fila
                int id_producto = Convert.ToInt32(row.Cells[0].Value);

                int cantActual = Convert.ToInt32(row.Cells[3].Value);

                Product productoExistente = ClassCarritoDatos.ProductosEnCarrito.FirstOrDefault(p => p.Id == id_producto);


                using (var context = new BdCybergearContext())
                {
                    // Obtén el producto actualizado desde la base de datos para verificar el stock
                    Product productoBD = context.Products.FirstOrDefault(p => p.Id == id_producto);

                    // valida si hay stock
                    if (productoExistente.CantEnCart < productoBD.Cantidad && productoBD.CantEnCart + 1 >= productoBD.StockMinimo)
                    {
                        row.Cells[3].Value = cantActual + 1;
                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente stock disponible para incrementar la cantidad.");
                        return;
                    }
                }
                


                sumarProductoDeCarrito(id_producto); //incrementa globa


                // Calcula y muestra el precio total
                calcularMostrarPrecioTotal();
            }

            if (e.ColumnIndex == dataGridView1.Columns[8].Index && e.RowIndex >= 0) //restar producto
            {
                // Obtén la fila actual
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Obtén el nombre del producto en la fila
                int id_producto = Convert.ToInt32(row.Cells[0].Value);

                int cant = Convert.ToInt32(row.Cells[3].Value);
                if (cant == 1)
                {
                    // Elimina la fila del DataGridView
                    dataGridView1.Rows.Remove(row);
                    EliminarProductoDeCarrito(id_producto);
                    calcularMostrarPrecioTotal();
                    return;
                }

                int cantActual = Convert.ToInt32(row.Cells[3].Value);

                row.Cells[3].Value = cantActual - 1;


                restarProductoDeCarrito(id_producto); //descrementa el producto de la lista globalmente

                // Calcula y muestra el precio total
                calcularMostrarPrecioTotal();
            }

        }

        private void EliminarProductoDeCarrito(int id_prod)
        {
            // Busca el producto en la lista global carritoProductos por el nombre
            var productoAEliminar = ClassCarritoDatos.ProductosEnCarrito
                .FirstOrDefault(p => p.Id == id_prod);

            // Si se encuentra el producto, elimínalo de la lista
            if (productoAEliminar != null)
            {
                ClassCarritoDatos.ProductosEnCarrito.Remove(productoAEliminar);
            }
        }

        private void sumarProductoDeCarrito(int id_producto)
        {
            // Busca el producto en la lista global carritoProductos por el nombre
            var productoAEliminar = ClassCarritoDatos.ProductosEnCarrito
                .FirstOrDefault(p => p.Id == id_producto);

            // Si se encuentra el producto, suma 1
            if (productoAEliminar != null)
            {
                productoAEliminar.CantEnCart++;
            }
        }


        private void restarProductoDeCarrito(int id_producto)
        {
            // Busca el producto en la lista global carritoProductos por el nombre
            var productoAEliminar = ClassCarritoDatos.ProductosEnCarrito
                .FirstOrDefault(p => p.Id == id_producto);

            // Si se encuentra el producto, resta 1
            if (productoAEliminar != null)
            {
                productoAEliminar.CantEnCart--;
            }
        }


        private Product ObtenerProductoDesdeBD(string nombreProducto)
        {
            using (var context = new BdCybergearContext())
            {
                return context.Products.FirstOrDefault(p => p.NombreProducto == nombreProducto);
            }
        }

        public void AgregarAlCarritoDesdeCatalogo(Product producto = null)
        {
            // Aquí puedes agregar el producto al carrito o realizar cualquier otra acción.

            // Si el parámetro producto no es nulo, significa que se proporcionó un producto.
            // Puedes realizar acciones específicas en consecuencia.
            if (producto != null)
            {
                using (var context = new BdCybergearContext())
                {

                    // Añade los datos al carrito directamente desde los campos
                    string nombreProducto = producto.NombreProducto;


                    // Recupera el producto desde la base de datos
                    Product productoDesdeBD = context.Products.FirstOrDefault(p => p.NombreProducto == nombreProducto);

                    double precioProducto = Convert.ToDouble(productoDesdeBD.PrecioProducto);
                    int cantidad = (int)numericUpDown1.Value;
                    string categoria = cBoxCategorias.Text; // Asigna la descripción según sea necesario.
                    int id_producto = productoDesdeBD.Id; ;

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


        private void CustomizeDataGridView()
        {
            // Deshabilita las líneas que separan las celdas
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Deshabilita las líneas que separan las columnas
            dataGridView1.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;

            // Puedes cambiar otros estilos y propiedades según tus necesidades
            dataGridView1.EnableHeadersVisualStyles = false;

            // Maneja el evento CellPainting para personalizar la apariencia
            dataGridView1.CellPainting += dataGridView1_CellPainting;

            // Centra el texto en las celdas
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Centra el texto en los encabezados de columna
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Personaliza la apariencia de las celdas según sea necesario
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                // Dibuja un fondo personalizado para el encabezado de la columna
                e.PaintBackground(e.CellBounds, true);
                e.Graphics.DrawString(dataGridView1.Columns[e.ColumnIndex].HeaderText,
                    e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5);
                e.Handled = true;
            }
        }
    }
}
