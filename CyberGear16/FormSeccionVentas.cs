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


            textBox2.Text = NombreUserIniciado;

            DataGridViewButtonColumn eliminarButtonColumn = new DataGridViewButtonColumn();
            eliminarButtonColumn.Name = "Acciones";
            eliminarButtonColumn.Text = "Quitar";
            eliminarButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(eliminarButtonColumn);



            // Agregar productos de ejemplo
            dataGridView1.Rows.Add("Producto 1", 10.99, 2, "juego");  // Nombre, Precio, Cantidad
            dataGridView1.Rows.Add("Producto 2", 15.49, 1, "juego");
            dataGridView1.Rows.Add("Producto 3", 5.99, 3, "PC_componentes");


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
    }
}
