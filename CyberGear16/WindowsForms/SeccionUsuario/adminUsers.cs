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

            TNombre.KeyPress += TextBox_KeyPress;
            TApellido.KeyPress += TextBox_KeyPress;
            TDireccion.KeyPress += TextBox_KeyPressDireccion;
            TDni.KeyPress += TextBoxNum_KeyPress;
            TCodPostal.KeyPress += TextBoxNum_KeyPress;
            TTelefono.KeyPress += TextBoxNum_KeyPress;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra (A-Z o a-z) o una tecla de control (como Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra ni una tecla de control, se cancela la entrada
                e.Handled = true;
            }
        }

        private void TextBox_KeyPressDireccion(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra (A-Z o a-z) o una tecla de control (como Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                // Si no es una letra, una tecla de control ni un espacio en blanco, se cancela la entrada
                e.Handled = true;
            }
        }

        private void TextBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un dígito ni una tecla de control, se cancela la entrada
                e.Handled = true;
            }
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
            long telefono;
            int dni;

            if (validarCampos() && long.TryParse(TTelefono.Text, out telefono) && int.TryParse(TDni.Text, out dni))
            {

                string nombre = TNombre.Text;
                string apellido = TApellido.Text;
                string usuario = TUsuario.Text;
                string contraseña = TContraseña.Text;
                string email = TEmail.Text;
                string direc = TDireccion.Text;
                int codPostal = int.Parse(TCodPostal.Text);
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
                            CodPostal = codPostal
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
                        CargarDatosEnDGVActivos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            //else
            //{
            //    MessageBox.Show("Por favor, ingrese valores válidos en los campos.");
            //}
        }

        //-------------------------Sección Validaciones-------------------------
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
                string.IsNullOrEmpty(TCodPostal.Text) ||
                ((!RBHombre.Checked) && (!RBMujer.Checked)) ||
                CBPerfil.SelectedIndex == -1)
            {
                MessageBox.Show("Campos incompletos! Por favor rellénelos y vuelva a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (validarTelefono() && validarDni() && validarNom() && validarApe() && validarUser()
                && validarDirec() && validarNumDirec() && validarContraseña() && validacionCorreo() && validacionFecha())
            {
                return true;
            }

            return false;
        }


        public class Validador
        {
            public static bool EsValorUnico<T>(DbContext context, DbSet<T> dbSet, Func<T, string> propiedadSelector, string valor)
                where T : class
            {
                // Obtén todos los registros de la tabla y luego realiza la comparación en memoria.
                var todosLosRegistros = dbSet.AsEnumerable();

                return !todosLosRegistros.Any(entidad => propiedadSelector(entidad) == valor);
            }
            /*DbSet<T> dbSet: Un conjunto de entidades del tipo genérico T.
            Esto se utiliza para especificar la tabla de la base de datos con la que deseas trabajar.*/
            /*Func<T, string> propiedadSelector: Una función que toma una entidad del tipo T y devuelve una cadena (string). 
            Esta función se utiliza para seleccionar la propiedad que deseas comparar con el valor ingresado.*/
        }


        private bool validarTelefono()
        {
            using (var context = new BdCybergearContext())
            {
                if (TTelefono.Text.Length >= 10 && TTelefono.Text.Length < 15)
                {
                    if (Validador.EsValorUnico(context, context.Usuarios, entidad => entidad.Tel.ToString(), TTelefono.Text))
                    {
                        return true;
                    }
                    else
                    {
                        // Muestra un mensaje de error o realiza alguna acción adecuada
                        MessageBox.Show("El Telefono ya está registrado para otro usuario. Ingresa un valor distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El mínimo de caracteres aceptados para el telefono es de 10 y el máximo de 15.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }



        }

        private bool validarDni()
        {
            if (TDni.Text.Length == 8)
            {
                using (var context = new BdCybergearContext())
                {
                    if (Validador.EsValorUnico(context, context.Usuarios, entidad => entidad.Dni.ToString(), TDni.Text))
                    {
                        return true;
                    }
                    else
                    {
                        // Muestra un mensaje de error o realiza alguna acción adecuada
                        MessageBox.Show("El DNI ya está registrado para otro usuario. Ingresa un valor distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("La cantidad de caracteres del DNI debe ser de 8.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool validacionCharEstandar(string textComprobar)
        {
            if ((textComprobar.Length > 2) && (textComprobar.Length <= 15))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool validarNom()
        {
            if (validacionCharEstandar(TNombre.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El mínimo de caracteres aceptados para el nombre es de 3 y el máximo de 15.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool validarApe()
        {
            if (validacionCharEstandar(TApellido.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El mínimo de caracteres aceptados para el apellido es de 3 y el máximo de 15.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool validarUser()
        {
            if (validacionCharEstandar(TUsuario.Text))
            {
                using (var context = new BdCybergearContext())
                {
                    if (Validador.EsValorUnico(context, context.Usuarios, entidad => entidad.Usuario1, TUsuario.Text))
                    {
                        return true;
                    }
                    else
                    {
                        // Muestra un mensaje de error o realiza alguna acción adecuada
                        MessageBox.Show("El Usuario ingresado ya se encuentra registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("El mínimo de caracteres aceptados para el usuario es de 3 y el máximo de 15.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool validarDirec()
        {
            if (TDireccion.Text.Length > 2 && TDireccion.Text.Length <= 20)
            {
                return true;
            }
            else
            {
                MessageBox.Show("El mínimo de caracteres aceptados para la dirección es de 3 y el máximo de 20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool validarNumDirec()
        {
            if (TCodPostal.Text.Length >= 2 && TCodPostal.Text.Length <= 5)
            {
                return true;
            }
            else
            {
                MessageBox.Show("El mínimo de caracteres aceptados para el número de dirección es de 2 y el máximo de 5.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool validarContraseña()
        {
            if (validacionCharEstandar(TContraseña.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El mínimo de caracteres aceptados para la dirección es de 3 y el máximo de 15.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool validacionCorreo()
        {
            try
            {
                // Utiliza una expresión regular para validar el formato del correo electrónico.
                string patrón = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (Regex.IsMatch(TEmail.Text, patrón))
                {
                    using (var context = new BdCybergearContext())
                    {
                        if (Validador.EsValorUnico(context, context.Usuarios, entidad => entidad.Email, TEmail.Text))
                        {
                            return true;
                        }
                        else
                        {
                            // Muestra un mensaje de error o realiza alguna acción adecuada
                            MessageBox.Show("El Email ya está registrado para otro usuario. Ingresa un valor distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Formato de correo electrónico incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                // La expresión regular tardó demasiado en ejecutarse, lo que podría indicar un patrón inválido.
                MessageBox.Show("Formato de correo electrónico incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool validacionFecha()
        {
            // Obtén la fecha seleccionada en el DateTimePicker
            DateTime fechaDTPicker = DTPicker.Value;

            // Obtén la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Calcula la diferencia en años entre la fecha seleccionada y la fecha actual
            int diferenciaAños = fechaActual.Year - fechaDTPicker.Year;

            // Verifica si la diferencia es mayor que 100 años
            if (diferenciaAños < 100)
            {
                if (diferenciaAños >= 18)
                {
                    return true;
                }
                else
                {
                    DTPicker.Value = fechaActual;
                    MessageBox.Show("El usuario a registrar debe de ser mayor de edad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                // Muestra un mensaje de error o realiza alguna acción adecuada
                MessageBox.Show("La fecha no puede ser mayor a 100 años a partir de la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Restaura la fecha seleccionada a la fecha actual
                DTPicker.Value = fechaActual;
                return false;
            }
        }

        //---------------------Fin de Sección Validaciones----------------------

        private void LimpiarCampos()
        {
            TNombre.Clear();
            TApellido.Clear();
            TUsuario.Clear();
            TContraseña.Clear();
            TEmail.Clear();
            TTelefono.Clear();
            TDireccion.Clear();
            TCodPostal.Clear();
            TDni.Clear();
            DTPicker.Value = DateTime.Now;
            CBPerfil.SelectedIndex = -1;
        }

        private void DGVUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == DGVUsuarios.Columns["Acciones"].Index)
            {
                // Obtén el producto seleccionado
                DataGridViewRow row = DGVUsuarios.Rows[e.RowIndex];
                int usuarioId = Convert.ToInt32(row.Cells["Id"].Value); // Asegúrate de tener una columna "IdProducto" para identificar el producto

                // Abre el formulario de detalles/editar con el Usuario seleccionado
                FormEditorUsuario editorUsuario = new FormEditorUsuario(usuarioId, _context);
                editorUsuario.ShowDialog();
                CargarDatosEnDGVActivos();
            }
        }

        private void PUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CargarDatosEnDGVActivos()
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

                var usuariosNoDeBaja = context.Usuarios.Where(u => u.Baja == "NO").ToList();

                DGVUsuarios.DataSource = usuariosNoDeBaja;
            }
        }

        private void adminUsers_Load(object sender, EventArgs e)
        {
            using (var context = new BdCybergearContext()) // se lo engloba en un using para q se cierre la conexion
            {
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
                CargarDatosEnDGVActivos();
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

                DataGridViewButtonColumn modificarButtonColumn = new DataGridViewButtonColumn();
                modificarButtonColumn.Name = "Acciones";
                modificarButtonColumn.Text = "Modificar/Baja-Alta";
                modificarButtonColumn.Width = 150;
                modificarButtonColumn.UseColumnTextForButtonValue = true;
                DGVUsuarios.Columns.Add(modificarButtonColumn);

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

            using (var context = new BdCybergearContext())
            {
                var usuariosFiltrados = context.Usuarios.Where(u => u.Baja == "SI").ToList();

                // Enlazar los resultados al DataGridView.
                DGVUsuarios.DataSource = usuariosFiltrados;

            }

        }


        private void BActivos_Click(object sender, EventArgs e)
        {
            CargarDatosEnDGVActivos();
        }

        bool borrarPrimeraVez = true;
        private void TBuscar_Click(object sender, EventArgs e)
        {
            if (borrarPrimeraVez)
            {
                TBuscar.Clear();
                borrarPrimeraVez = false;
            }
        }
        private void BuscarEnBaseDeDatosYActualizarDataGridView(string buscar)
        {
            using (var context = new BdCybergearContext())
            {

                var resultados = context.Usuarios.Where(e => e.Nombre.Contains(buscar) || e.Apellido.Contains(buscar)).ToList();
                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se han encontrado usuarios que coincidan con la busqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DGVUsuarios.DataSource = resultados;
                }
            }
        }

        private void TBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter))
            {
                if (!string.IsNullOrEmpty(TBuscar.Text))
                {
                    string buscar = TBuscar.Text;
                    // Llama a un método que realiza la búsqueda en la base de datos y actualiza el DataGridView.
                    BuscarEnBaseDeDatosYActualizarDataGridView(buscar);
                }
                else
                {
                    MessageBox.Show("No hay elementos para buscar. Por favor escriba algo y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBuscar.Text))
            {
                string buscar = TBuscar.Text;
                // Llama a un método que realiza la búsqueda en la base de datos y actualiza el DataGridView.
                BuscarEnBaseDeDatosYActualizarDataGridView(buscar);
            }
            else
            {
                MessageBox.Show("No hay elementos para buscar. Por favor escriba algo y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBuscar.Text))
            {
                TBuscar.Clear();
                CargarDatosEnDGVActivos();
            }

        }

        private void BOcultar_Click(object sender, EventArgs e)
        {
            if (TContraseña.PasswordChar == '*')
            {
                BOcultar.Image = Properties.Resources.visibilidad;
                // Mostrar la contraseña en texto plano
                TContraseña.PasswordChar = '\0'; // Carácter nulo para mostrar el texto
            }
            else
            {
                BOcultar.Image = Properties.Resources.cerrado;
                // Ocultar la contraseña
                TContraseña.PasswordChar = '*'; // Carácter de contraseña
            }
        }

        private void TCodPostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void LCodPostal_Click(object sender, EventArgs e)
        {

        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
