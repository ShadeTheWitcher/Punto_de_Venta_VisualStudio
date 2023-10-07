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
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace CyberGear16
{
    public partial class FormClientes : Form
    {
        private readonly BdCybergearContext _context;

        public FormClientes(BdCybergearContext context)
        {
            InitializeComponent();
            _context = context;

        }

        private void CargarDatosEnDGVActivos()
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

                DGVClientes.DataSource = varClientes;
            }
        }

        private void LDireccion_Click(object sender, EventArgs e)
        {

        }

        private void FormClientes_Load(object sender, EventArgs e)
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
                DGVClientes.DataSource = clientes;
                CargarDatosEnDGVActivos();
                // Configura el estilo y columnas del DataGridView

                DGVClientes.Columns["IdCliente"].Width = 40;
                DGVClientes.Columns["DNI"].Width = 110;
                DGVClientes.Columns["Nombre"].Width = 120;
                DGVClientes.Columns["Apellido"].Width = 120;
                DGVClientes.Columns["Email"].Width = 230;
                DGVClientes.Columns["FechaNacimiento"].Width = 120;
                DGVClientes.Columns["Telefono"].Width = 130;
                DGVClientes.Columns["Sexo"].Width = 110;


                //DataGridViewButtonColumn modificarButtonColumn = new DataGridViewButtonColumn();
                //modificarButtonColumn.Name = "Acciones";
                //modificarButtonColumn.Text = "Modificar/Baja-Alta";
                //modificarButtonColumn.Width = 150;
                //modificarButtonColumn.UseColumnTextForButtonValue = true;
                //DGVUsuarios.Columns.Add(modificarButtonColumn);

                // Cambia el color de fuente a negro para todas las celdas del DataGridView
                DGVClientes.DefaultCellStyle.ForeColor = Color.Black;

                // Oculta las columnas no deseadas (en este caso, ocultamos todas las demás)
                foreach (DataGridViewColumn column in DGVClientes.Columns)
                {
                    if (column.Name != "Id" && column.Name != "Dni" && column.Name != "Nombre" && column.Name != "Apellido" && column.Name != "Email" &&
                        column.Name != "FechaNacimiento" && column.Name != "Telefono"/*&& column.Name != "Acciones"*/ && column.Name != "Sexo"
                        /*column.Name != "Baja"*/)
                    {
                        column.Visible = false;
                    }
                }
            }
        }
    }


}
