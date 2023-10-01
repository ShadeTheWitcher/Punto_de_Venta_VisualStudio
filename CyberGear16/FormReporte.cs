using CyberGear16.Models;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CyberGear16
{
    public partial class FormReporte : Form
    {
        private readonly BdCybergearContext _context;
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
                //var varClientes = context.Clientes
                //.Select(p => new
                //{
                //    p.IdCliente,
                //    p.Nombre,
                //    p.Apellido,
                //    p.Dni,
                //    p.Email,
                //    p.FechaNacimiento,
                //    p.Sexo,
                //    p.Telefono,
                //})
                //.ToList();

                var clientesNoDeBaja = context.Clientes.Where(u => u.Baja == "NO").ToList();

                DGVReportes.DataSource = clientesNoDeBaja;

            }
        }

        private void DGVReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DGVReportes.Columns["Acciones"].Index)
            {
                // Obtén el producto seleccionado
                DataGridViewRow row = DGVReportes.Rows[e.RowIndex];
                int dniIndividuo = Convert.ToInt32(row.Cells["Dni"].Value); // Asegúrate de tener una columna "IdProducto" para identificar el producto

                using (var context = new BdCybergearContext())
                {
                    Usuario usuarioVendedor = context.Usuarios.FirstOrDefault(p => p.Dni == dniIndividuo);
                    Cliente usuarioCliente = context.Clientes.FirstOrDefault(p => p.Dni == dniIndividuo);


                    if (usuarioVendedor != null)
                    {
                        FormInformeVendedor informeIndividuo = new FormInformeVendedor(usuarioVendedor, _context);
                        informeIndividuo.ShowDialog();
                    }
                    else
                    {
                        FormInformeCliente informeIndividuo = new FormInformeCliente(usuarioCliente, _context);
                        informeIndividuo.ShowDialog();
                    }
                }
                // Abre el formulario de detalles/editar con el Usuario seleccionado

                //CargarDatosEnDGVActivos();
            }
        }



        private void DGVReportesClientes()
        {
            using (var context = new BdCybergearContext()) // se lo engloba en un using para q se cierre la conexion
            {
                DGVReportes.DataSource = null;
                DGVReportes.Rows.Clear();
                DGVReportes.Columns.Clear();

                // Consulta los productos desde la base de datos
                //var clientes = context.Clientes
                //    .Select(p => new
                //    {
                //        p.IdCliente,
                //        p.Nombre,
                //        p.Apellido,
                //        p.Dni,
                //        p.Email,
                //        p.FechaNacimiento,
                //        p.Sexo,
                //        p.Telefono,
                //    })
                //.ToList();

                // Asigna los clientes a la fuente de datos del DataGridView
                //DGVReportes.DataSource = clientes;
                CargarDatosEnDGVClientes();
                // Configura el estilo y columnas del DataGridView


                DGVReportes.Columns["DNI"].Width = 120;
                DGVReportes.Columns["Nombre"].Width = 120;
                DGVReportes.Columns["Apellido"].Width = 120;
                DGVReportes.Columns["Email"].Width = 220;
                DGVReportes.Columns["FechaNacimiento"].Width = 120;
                DGVReportes.Columns["Telefono"].Width = 130;
                DGVReportes.Columns["Sexo"].Width = 110;


                DataGridViewButtonColumn modificarButtonColumnClientes = new DataGridViewButtonColumn();
                modificarButtonColumnClientes.Name = "Acciones";
                modificarButtonColumnClientes.Text = "Informe";
                modificarButtonColumnClientes.Width = 180;
                modificarButtonColumnClientes.UseColumnTextForButtonValue = true;
                DGVReportes.Columns.Add(modificarButtonColumnClientes);

                // Cambia el color de fuente a negro para todas las celdas del DataGridView
                DGVReportes.DefaultCellStyle.ForeColor = Color.Black;

                // Oculta las columnas no deseadas (en este caso, ocultamos todas las demás)
                foreach (DataGridViewColumn column in DGVReportes.Columns)
                {
                    if (column.Name != "Dni" && column.Name != "Nombre" && column.Name != "Apellido" && column.Name != "Email" &&
                        column.Name != "FechaNacimiento" && column.Name != "Telefono" && column.Name != "Acciones"
                        )
                    {
                        column.Visible = false;
                    }
                }
            }
        }

        private void CargarDatosEnDGVVendedores()
        {
            using (var context = new BdCybergearContext())
            {

                // Vuelve a cargar los datos en el DataGridView para reflejar los cambios.
                //var usuarios = context.Usuarios;
                //.Select(p => new
                //{
                //    p.Id,
                //    p.Dni,
                //    p.Nombre,
                //    p.Apellido,
                //    p.Email,
                //    p.Usuario1,
                //    p.Tel,
                //    p.Fecha,
                //    p.Sexo,
                //    p.Baja
                //})
                //.ToList();

                var vendedores = context.Usuarios.Where(u => u.PerfilId == 3 && u.Baja == "NO").ToList();

                DGVReportes.DataSource = vendedores;
            }
        }

        private void adminUsers_Load(object sender, EventArgs e)
        {

        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            DGVReportesClientes();
        }

        private void BRClientes_Click(object sender, EventArgs e)
        {
            DGVReportesClientes();
            LRClienteVendedor.Text = "Clientes:";
        }

        private void BRVendedores_Click(object sender, EventArgs e)
        {
            LRClienteVendedor.Text = "Vendedores:";
            using (var context = new BdCybergearContext()) // se lo engloba en un using para q se cierre la conexion
            {
                DGVReportes.DataSource = null;
                DGVReportes.Rows.Clear();
                DGVReportes.Columns.Clear();
                // Consulta los productos desde la base de datos
                //var usuarios = context.Usuarios
                //    .Select(p => new
                //    {
                //        p.Id,
                //        p.Dni,
                //        p.Nombre,
                //        p.Apellido,
                //        p.Email,
                //        p.Usuario1,
                //        p.Tel,
                //        p.Fecha,
                //        p.Sexo,
                //        p.Baja
                //    })
                //    .ToList();

                //// Asigna los productos a la fuente de datos del DataGridView
                //DGVUsuarios.DataSource = usuarios;
                CargarDatosEnDGVVendedores();
                // Configura el estilo y columnas del DataGridView
                // (asegúrate de que las propiedades de Product se correspondan con las columnas)


                DGVReportes.Columns["DNI"].Width = 110;
                DGVReportes.Columns["Nombre"].Width = 130;
                DGVReportes.Columns["Apellido"].Width = 130;
                DGVReportes.Columns["Email"].Width = 230;
                DGVReportes.Columns["Fecha"].Width = 110;
                DGVReportes.Columns["Sexo"].Width = 100;


                DataGridViewButtonColumn modificarButtonColumn = new DataGridViewButtonColumn();
                modificarButtonColumn.Name = "Acciones";
                modificarButtonColumn.Text = "Informe";
                modificarButtonColumn.Width = 200;
                modificarButtonColumn.UseColumnTextForButtonValue = true;
                DGVReportes.Columns.Add(modificarButtonColumn);

                //DGVUsuarios.Columns["Usuario1"].Name = "Usuario";

                // Cambia el color de fuente a negro para todas las celdas del DataGridView
                DGVReportes.DefaultCellStyle.ForeColor = Color.Black;

                // Oculta las columnas no deseadas (en este caso, ocultamos todas las demás)
                foreach (DataGridViewColumn column in DGVReportes.Columns)
                {
                    if (column.Name != "Dni" && column.Name != "Nombre" && column.Name != "Apellido" && column.Name != "Email" &&
                        column.Name != "Fecha" && column.Name != "Acciones" && column.Name != "Sexo")
                    {
                        column.Visible = false;
                    }
                }
            }
        }

        private void LRClienteVendedor_Click(object sender, EventArgs e)
        {

        }
    }
}
