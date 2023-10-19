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
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Metadata;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;


namespace CyberGear16.WindowsForms.SeccionVentas
{
    public partial class FormFactura : Form
    {

        // Agrega propiedades para almacenar la información de la venta
        public int IdVenta { get; set; }
        public string ClienteNombre { get; set; }
        public string Apellido { get; set; }
        public int dniCliente { get; set; }
        public DateOnly FechaVenta { get; set; }

        public FormFactura()
        {
            InitializeComponent();
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {
            CustomizeDataGridView();
            cargarDatos();
        }

        private void cargarDatos()
        {
            lbIdVenta.Text = "Nro: #" + IdVenta.ToString();
            lbNomyApellido.Text = ClienteNombre + " " + Apellido;
            lbFecha.Text = $"{FechaVenta.ToString("yyyy-MM-dd")}";  // Puedes ajustar el formato según tus necesidades ;
            obtenerDireccion();
            cargarDataGrid();

        }

        private void obtenerDireccion()
        {
            using (var context = new BdCybergearContext())
            {
                // Supongamos que tienes el DNI del cliente que estás buscando
                int dniClienteBuscado = dniCliente;

                // Buscar el cliente por DNI y cargar el domicilio asociado
                var cliente = context.Clientes
                    .Include(c => c.Domicilio)  // Incluir el domicilio asociado
                    .FirstOrDefault(c => c.Dni == dniClienteBuscado);

                if (cliente != null)
                {
                    // Acceder a la dirección del domicilio
                    string direccionCliente = cliente.Domicilio.Direccion;
                    int codPostalCliente = cliente.Domicilio.CodPostal;

                    // Ahora puedes usar la dirección y el código postal como sea necesario
                    Console.WriteLine($"Dirección del cliente: {direccionCliente}, Código Postal: {codPostalCliente}");

                    lbDireccion.Text = $"{direccionCliente}, CP: {codPostalCliente}";
                }
                else
                {
                    Console.WriteLine("Cliente no encontrado");
                }
            }
        }

        private void cargarDataGrid()
        {
            using (var context = new BdCybergearContext())
            {
                // Obtén los detalles de la venta para la venta actual (IdVenta)
                var detallesVenta = context.VentasDetalles
                    .Include(d => d.Producto) // Incluir el producto asociado
                    .Where(d => d.VentaId == IdVenta)
                    .ToList();

                foreach (var detalle in detallesVenta)
                {
                    DataGridViewRow nuevaFila = new DataGridViewRow();
                    nuevaFila.CreateCells(dataGridView1);

                    nuevaFila.Cells[0].Value = detalle.Producto.NombreProducto; // Asigna el nombre del producto a la primera columna
                    nuevaFila.Cells[1].Value = detalle.Precio; // Asigna el precio a la segunda columna
                    nuevaFila.Cells[2].Value = detalle.CantidadVenta; // Asigna la cantidad a la tercera columna

                    dataGridView1.Rows.Add(nuevaFila);
                }

                calcularMostrarPrecioTotal();


            }
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
                row.Cells[3].Value = subtotal;

                precioTotal += subtotal;
            }





            // Mostrar el precio total
            label13.Text = precioTotal.ToString("0.00");
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
            //dataGridView1.CellPainting += dataGridView1_CellPainting;

            // Centra el texto en las celdas
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Centra el texto en los encabezados de columna
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén la ruta del directorio del programa y crea una carpeta "Facturas"
            string rutaFacturas = Path.Combine(Application.StartupPath, "Facturas");

            // Si la carpeta no existe, créala
            if (!Directory.Exists(rutaFacturas))
            {
                Directory.CreateDirectory(rutaFacturas);
            }

            // Crea un documento PDF en la carpeta "Facturas"
            string rutaPDF = Path.Combine(rutaFacturas, $"Factura_{IdVenta}.pdf");

            using (var writer = new PdfWriter(rutaPDF))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new iText.Layout.Document(pdf);
                    try
                    {
                        
                        // Agregar contenido al PDF
                        AgregarContenidoPDF(document);

                        MessageBox.Show($"PDF generado exitosamente. Guardado en: {rutaPDF}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        document.Close();
                    }
                    

                   
                }
            }

        }

        private void AgregarContenidoPDF(iText.Layout.Document document )
        {
            // Agregar información del encabezado
            document.Add(new Paragraph($"Factura #{IdVenta} - Fecha: {FechaVenta.ToString("yyyy-MM-dd")}"));

            document.Add(new Paragraph($"Cliente: {ClienteNombre} {Apellido}"));
            document.Add(new Paragraph($"Dirección: {lbDireccion.Text}"));

            // Agregar detalles de la venta desde el DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string descripcion = row.Cells[0].Value.ToString();
                string precio = row.Cells[1].Value.ToString();
                string cantidad = row.Cells[2].Value.ToString();
                string subtotal = row.Cells[3].Value.ToString();

                document.Add(new Paragraph($"{descripcion} - Precio: {precio}, Cantidad: {cantidad}, Subtotal: {subtotal}"));
            }

            // Agregar el total al final del documento
            document.Add(new Paragraph($"Total: {label13.Text}"));
        }









    }
}
