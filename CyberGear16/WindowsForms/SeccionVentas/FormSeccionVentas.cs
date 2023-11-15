using CyberGear16.Models;
using CyberGear16.WindowsForms.Seccion_Catalogo;
using CyberGear16.WindowsForms.SeccionProducto.Categoria;
using CyberGear16.WindowsForms.SeccionVentas;
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
        public bool cierreCatalogo = false;
        private Panel panelCatalogo;
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

            //CargarCategorias();





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
                    MessageBox.Show("Vendedor no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del evento si no se encuentra el vendedor
                }

            }


            DataGridViewButtonColumn eliminarButtonColumn = new DataGridViewButtonColumn();
            eliminarButtonColumn.Name = "Acciones";
            eliminarButtonColumn.Text = "Quitar";
            eliminarButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(eliminarButtonColumn);

            dataGridView1.Rows.Clear();
            loadDataGridCarrito();

        }

        private void loadDataGridCarrito()
        {
            // Acceder a los productos en el carrito desde otro formulario o clase
            productosEnCarrito = ClassCarritoDatos.ProductosEnCarrito;

            // Verificar si la lista está vacía antes de realizar operaciones
            if (productosEnCarrito != null && productosEnCarrito.Any())
            {
                // La lista no está vacía, puedes realizar operaciones con ella
                foreach (var producto in productosEnCarrito)
                {
                    string categoriaNombre = asignarCategoria(producto.CategoriaId);




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

                        if (carritoLoad != true) //controla si es una insersion de producto o solo se quiere mostrar datos
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
                    MessageBox.Show("No hay suficiente stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


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
                        MessageBox.Show("Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show("Ingrese un DNI válido (número completo).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Crear un panel para contener el formulario formCrudCategoria
            panelCatalogo = new Panel();

            //DockStyle.Fill llene completamente el espacio disponible del panel
            panelCatalogo.Dock = DockStyle.Fill;

            // Crear una instancia del formulario formCrudCategoria
            FormCatalogo formCatalogo = new FormCatalogo(_context);

            // Configurar el tamaño y la posición del formulario
            formCatalogo.TopLevel = false;
            formCatalogo.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panelCatalogo.Controls.Add(formCatalogo);

            // Agregar el panel al formulario
            Controls.Add(panelCatalogo);

            // Asegurar que el panel esté en la parte superior del z-order
            panelCatalogo.BringToFront();

            // Mostrar el panel (y el formulario dentro de él)
            panelCatalogo.Visible = true;
            formCatalogo.Show();

            // Manejar el evento de cierre de formCrudCategoria
            formCatalogo.FormClosed += (sender, args) =>
            {
                // Restaurar la visibilidad de cualquier contenido que pueda haber quedado oculto
                panelCatalogo.Visible = false;  // O establecer en false si lo prefieres
                carritoLoad = true;
                dataGridView1.Rows.Clear();
                loadDataGridCarrito();



            };
        }

        private void button5_Click(object sender, EventArgs e) //buscar
        {




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
                    if (productoExistente.CantEnCart < productoBD.Cantidad
                        && (productoExistente.CantEnCart + 1) <= (productoBD.Cantidad - productoBD.StockMinimo))
                    {
                        row.Cells[3].Value = cantActual + 1;
                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente stock disponible para incrementar la cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        }



        private void button1_Click(object sender, EventArgs e)
        {

            // Verifica si hay un cliente asignado
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("No hay un cliente asignado. Asigne un cliente antes de guardar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica que haya productos en el carrito antes de intentar guardar la venta
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito. Añada productos antes de guardar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
                else
                {
                    // Manejar el caso en el que el cliente no se encuentra
                    MessageBox.Show("Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Recupera la instancia del usuario (vendedor) por su ID
                Usuario vendedor = context.Usuarios.FirstOrDefault(u => u.Dni == dniUsuario);

                if (vendedor == null)
                {
                    MessageBox.Show("Vendedor no encontrado. No se puede guardar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show($"Producto con ID {productoId} no encontrado. No se puede guardar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


                MessageBox.Show("Venta guardada exitosamente.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpia el carrito después de guardar la venta
                LimpiarCarrito();

                FormFactura facturaForm = new FormFactura();

                // Pasa la información necesaria a la factura
                facturaForm.IdVenta = nuevaVentaCabecera.Id; // Puedes agregar más información según tus necesidades
                facturaForm.FechaVenta = nuevaVentaCabecera.Fecha;
                facturaForm.ClienteNombre = cliente.Nombre; // Suponiendo que cliente tiene una propiedad "Nombre"
                facturaForm.Apellido = cliente.Apellido;
                facturaForm.dniCliente = cliente.Dni;

                // Puedes seguir pasando más información de ser necesario

                // Muestra el formulario de la factura
                facturaForm.Show();



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
            //dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Centra el texto en los encabezados de columna
            //dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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



        private string asignarCategoria(int idCategoria)
        {
            string categoria = "sin-categoria";
            using (var context = new BdCybergearContext())
            {
                // Busca la categoría por su Id
                var categoriaEncontrada = context.Categoria
                    .Where(c => c.IdCategoria == idCategoria && c.Activo == "SI")
                    .FirstOrDefault(); // Puedes usar FirstOrDefault() para obtener la primera coincidencia

                if (categoriaEncontrada != null)
                {
                    categoria = categoriaEncontrada.CategoriaNombre; // Asigna el nombre de la categoría encontrada
                }



                return categoria;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void CargarCategorias()
        //{
        //    // cargar las categorías desde la base de datos y agregarlas al ComboBox

        //    using (var context = new BdCybergearContext())
        //    {
        //        var categorias = context.Categoria.Where(c => c.Activo == "SI").ToList(); //solo se puede añadir las categorias activas a nuevos productos

        //        // Agrega una opción vacía al principio de la lista
        //        categorias.Insert(0, new Categorium { IdCategoria = 0, CategoriaNombre = "Categoría" });

        //        cBoxCategorias.DataSource = categorias;
        //        cBoxCategorias.DisplayMember = "CategoriaNombre"; // Ajusta esto según tu modelo
        //        cBoxCategorias.ValueMember = "IdCategoria"; // Ajusta esto según tu modelo
        //    }
        //}








    }
}
