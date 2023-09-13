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


namespace CyberGear16
{
    public partial class adminUsers : Form
    {
        private readonly BdCybergearContext _context; // DbContext de Entity Framework
        public adminUsers(BdCybergearContext context)
        {
            InitializeComponent();

            CBPerfil.Items.Add("Admin");
            CBPerfil.Items.Add("Supervisor");
            CBPerfil.Items.Add("Vendedor");
            _context = context;
        }

        private void LUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void LApellido_Click(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            int telefono;
            int dni;

            if (validarCampos() && int.TryParse(TTelefono.Text, out telefono) && int.TryParse(TDni.Text, out dni))
            {

                string nombre = TNombre.Text;
                string apellido = TApellido.Text;
                string usuario = TUsuario.Text;
                string contraseña = TContraseña.Text;
                string email = TEmail.Text;
                string direc = TDireccion.Text;
                DateTime fechaHora = DTPicker.Value;
                DateOnly fecha = new DateOnly(fechaHora.Year, fechaHora.Month, fechaHora.Day);
                int indexPerfil = CBPerfil.SelectedIndex;
                string sexo;

                if (RBHombre.Checked)
                {
                    sexo = "Hombre";

                }
                else
                {
                    sexo = "Mujer";
                }

                try
                {
                    using (var context = new BdCybergearContext())
                    {
                        Domicilio nuevoDomicilio = new Domicilio
                        {
                            Direccion = direc,
                            CodPostal = 111
                        };

                        context.Domicilios.Add(nuevoDomicilio);

                        context.SaveChanges();
                        //TiposUsuario nuevoTipo = new TiposUsuario
                        //{
                        //    Id = indexPerfil
                        //};

                        //context.Domicilios.Add(nuevoTipo);



                        Usuario nuevoUsuario = new Usuario
                        {
                            Nombre = nombre,
                            Apellido = apellido,
                            Dni = dni,
                            Email = email,
                            Usuario1 = usuario,
                            Pass = contraseña,
                            PerfilId = (indexPerfil + 1),
                            DomicilioId = nuevoDomicilio.Id,
                            Tel = telefono,
                            Fecha = fecha,
                            Sexo = sexo

                        };

                        context.Usuarios.Add(nuevoUsuario);

                        context.SaveChanges();



                        LimpiarCampos();
                        CargarDatosEnDGV();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el usuario: " + ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos en los campos.");
            }
        }

        public bool validarCampos()
        {
            if (string.IsNullOrEmpty(TNombre.Text) ||
                string.IsNullOrEmpty(TApellido.Text) ||
                string.IsNullOrEmpty(TDni.Text) ||
                string.IsNullOrEmpty(TUsuario.Text) ||
                string.IsNullOrEmpty(TContraseña.Text) ||
                string.IsNullOrEmpty(TEmail.Text) ||
                string.IsNullOrEmpty(TTelefono.Text) ||
                DTPicker.Value > DateTime.Today ||
                string.IsNullOrEmpty(TDireccion.Text) ||
                ((!RBHombre.Checked) && (!RBMujer.Checked)) ||
                CBPerfil.SelectedIndex == -1)
            {
                MessageBox.Show("Campos incompletos");
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            TNombre.Clear();
            TApellido.Clear();
            TUsuario.Clear();
            TContraseña.Clear();
            TEmail.Clear();
            TTelefono.Clear();
            TDireccion.Clear();
            TDni.Clear();
            CBPerfil.SelectedIndex = -1;
        }

        private void DGVUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en la columna de botones y en la fila deseada.
            //if (e.ColumnIndex == DGVUsuarios.Columns["Acciones"].Index && e.RowIndex >= 0)
            //{
            //    // Obtener el valor actual de "Baja" en la fila.
            //    string valorActualBaja = (string)DGVUsuarios.Rows[e.RowIndex].Cells["Baja"].Value;

            //    // Invertir el valor (cambiar de true a false o viceversa).
            //    if (valorActualBaja == "NO")
            //    {
            //        valorActualBaja = "SI";
            //    }
            //    else
            //    {
            //        valorActualBaja = "NO";
            //    }


            //    // Actualizar el valor en el origen de datos (base de datos, lista, etc.).
            //    // Aquí debes agregar código para actualizar el valor en tu origen de datos.

            //    // Actualizar el valor en el DataGridView.
            //    DGVUsuarios.Rows[e.RowIndex].Cells["Baja"].Value = valorActualBaja;
            //}


            //if (e.RowIndex >= 0 && e.ColumnIndex == DGVUsuarios.Columns["Acciones"].Index)
            //{
            //    // Obtén el producto seleccionado
            //    //DataGridViewRow rowIndex = DGVUsuarios.Rows[e.RowIndex];


            //    // Cambiar los valores de las celdas de esa fila.
            //    DGVUsuarios.Rows[e.RowIndex].Cells["Acciones"].Value = "SI";
            //}
        }

        private void PUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CargarDatosEnDGV()
        {
            using (var context = new BdCybergearContext())
            {
                // Vuelve a cargar los datos en el DataGridView para reflejar los cambios.
                var usuarios = context.Usuarios
                .Select(p => new
                {
                    p.Id,
                    p.Dni,
                    p.Nombre,
                    p.Apellido,
                    p.Email,
                    p.Usuario1,
                    p.Tel,
                    p.Fecha,
                    p.Sexo,
                    p.Baja
                })
                .ToList();

                DGVUsuarios.DataSource = usuarios;
            }
        }

        private void adminUsers_Load(object sender, EventArgs e)
        {
            using (var context = new BdCybergearContext()) // se lo engloba en un using para q se cierre la conexion
            {
                // Consulta los productos desde la base de datos
                var usuarios = context.Usuarios
                    .Select(p => new
                    {
                        p.Id,
                        p.Dni,
                        p.Nombre,
                        p.Apellido,
                        p.Email,
                        p.Usuario1,
                        p.Tel,
                        p.Fecha,
                        p.Sexo,
                        p.Baja
                    })
                    .ToList();

                // Asigna los productos a la fuente de datos del DataGridView
                DGVUsuarios.DataSource = usuarios;

                // Configura el estilo y columnas del DataGridView
                // (asegúrate de que las propiedades de Product se correspondan con las columnas)

                DGVUsuarios.Columns["Id"].Width = 40;
                DGVUsuarios.Columns["DNI"].Width = 80;
                DGVUsuarios.Columns["Nombre"].Width = 100;
                DGVUsuarios.Columns["Apellido"].Width = 100;
                DGVUsuarios.Columns["Email"].Width = 200;
                DGVUsuarios.Columns["Usuario1"].Width = 100;
                DGVUsuarios.Columns["Fecha"].Width = 80;
                DGVUsuarios.Columns["Sexo"].Width = 50;
                DGVUsuarios.Columns["Baja"].Width = 50;

                DataGridViewButtonColumn eliminarButtonColumn = new DataGridViewButtonColumn();
                eliminarButtonColumn.Name = "Acciones";
                eliminarButtonColumn.Text = "Eliminar";
                eliminarButtonColumn.Width = 150;
                eliminarButtonColumn.UseColumnTextForButtonValue = true;
                DGVUsuarios.Columns.Add(eliminarButtonColumn);

                //DGVUsuarios.Columns["Usuario1"].Name = "Usuario";

                // Cambia el color de fuente a negro para todas las celdas del DataGridView
                DGVUsuarios.DefaultCellStyle.ForeColor = Color.Black;

                // Oculta las columnas no deseadas (en este caso, ocultamos todas las demás)
                foreach (DataGridViewColumn column in DGVUsuarios.Columns)
                {
                    if (column.Name != "Id" && column.Name != "Dni" && column.Name != "Nombre" && column.Name != "Apellido" && column.Name != "Email" &&
                        column.Name != "Usuario1" && column.Name != "Fecha" && column.Name != "Acciones" && column.Name != "Sexo" &&
                        column.Name != "Baja")
                    {
                        column.Visible = false;
                    }
                }
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BInactivos_Click(object sender, EventArgs e)
        {
            // Filtrar usuarios basados en el valor booleano "Baja".
            string mostrarBaja = "NO";

            using (var context = new BdCybergearContext())
            {
                var usuariosFiltrados = context.Usuarios.Where(u => u.Baja == mostrarBaja).ToList();

                // Enlazar los resultados al DataGridView.
                DGVUsuarios.DataSource = usuariosFiltrados;

            }

            CargarUsuariosInactivos();
        }

        private void CargarUsuariosInactivos()
        {
            using (var context = new BdCybergearContext())
            {
                var usuarios = context.Usuarios.ToList();
                DGVUsuarios.DataSource = usuarios;
            }
        }


    }
}
