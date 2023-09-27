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
    public partial class FormReporte : Form
    {
        public FormReporte()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void CargarDatosEnDGVClientes()
        {
            using (var context = new BdCybergearContext())
            {

                // Vuelve a cargar los datos en el DataGridView para reflejar los cambios.
                var varClientes = context.Clientes
                .Select(p => new
                {
                    p.IdCliente,
                    p.Nombre,
                    p.Apellido,
                    p.Dni,
                    p.Email,
                    p.FechaNacimiento,
                    p.Sexo,
                    p.Telefono,
                })
                .ToList();

                //var usuariosNoDeBaja = context.Clientes.Where(u => u.Baja == "NO").ToList();

                DGVReportes.DataSource = varClientes;

            }
        }

        private void DGVReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVReportesClientes()
        {
            using (var context = new BdCybergearContext()) // se lo engloba en un using para q se cierre la conexion
            {
                // Consulta los productos desde la base de datos
                var clientes = context.Clientes
                    .Select(p => new
                    {
                        p.IdCliente,
                        p.Nombre,
                        p.Apellido,
                        p.Dni,
                        p.Email,
                        p.FechaNacimiento,
                        p.Sexo,
                        p.Telefono,
                    })
                .ToList();

                // Asigna los clientes a la fuente de datos del DataGridView
                DGVReportes.DataSource = clientes;
                CargarDatosEnDGVClientes();
                // Configura el estilo y columnas del DataGridView

                DGVReportes.Columns["IdCliente"].Width = 40;
                DGVReportes.Columns["DNI"].Width = 110;
                DGVReportes.Columns["Nombre"].Width = 120;
                DGVReportes.Columns["Apellido"].Width = 120;
                DGVReportes.Columns["Email"].Width = 230;
                DGVReportes.Columns["FechaNacimiento"].Width = 120;
                DGVReportes.Columns["Telefono"].Width = 130;
                DGVReportes.Columns["Sexo"].Width = 110;


                DataGridViewButtonColumn modificarButtonColumn = new DataGridViewButtonColumn();
                modificarButtonColumn.Name = "Acciones";
                modificarButtonColumn.Text = "Informe";
                modificarButtonColumn.Width = 180;
                modificarButtonColumn.UseColumnTextForButtonValue = true;
                DGVReportes.Columns.Add(modificarButtonColumn);

                // Cambia el color de fuente a negro para todas las celdas del DataGridView
                DGVReportes.DefaultCellStyle.ForeColor = Color.Black;

                // Oculta las columnas no deseadas (en este caso, ocultamos todas las demás)
                foreach (DataGridViewColumn column in DGVReportes.Columns)
                {
                    if (column.Name != "Id" && column.Name != "Dni" && column.Name != "Nombre" && column.Name != "Apellido" && column.Name != "Email" &&
                        column.Name != "FechaNacimiento" && column.Name != "Telefono" && column.Name != "Acciones"
                        )
                    {
                        column.Visible = false;
                    }
                }
            }
        }
        private void FormReporte_Load(object sender, EventArgs e)
        {
            DGVReportesClientes();
        }
    }
}
