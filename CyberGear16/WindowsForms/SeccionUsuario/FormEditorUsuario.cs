using CyberGear16.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberGear16
{
    public partial class FormEditorUsuario : Form
    {
        private BdCybergearContext context;
        private int id_usuario;
        private Usuario usuarioModificar;

        public FormEditorUsuario(int id_usuarioElegido, BdCybergearContext context)
        {
            InitializeComponent();
            id_usuario = id_usuarioElegido;
            CBPerfil.Items.Add("Admin");
            CBPerfil.Items.Add("Supervisor");
            CBPerfil.Items.Add("Vendedor");


            this.context = context;

            recuperarDatosUsuario();
            usuarioModificar = buscarUsuario(id_usuario);

        }

        private void BAlta_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres dar de alta este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            // Verificar si el usuario hizo clic en "Sí"
            if (result == DialogResult.Yes)
            {
                using (var context = new BdCybergearContext())
                {
                    // Obtener el objeto existente que deseas actualizar
                    var usuario = context.Usuarios.Find(this.id_usuario);

                    usuario.Baja = "NO";

                    context.SaveChanges();
                    MessageBox.Show("Se ha dado de alta al usuario correctamente!", "Alta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void recuperarDatosUsuario()
        {
            // Asigna los valores del usuario a los controles

            using (var newcontext = new BdCybergearContext())
            {  // se lo engloba en un using para q se cierre la conexion

                // Obtén el producto a través del contexto y su ID
                Usuario usuario = newcontext.Usuarios.FirstOrDefault(p => p.Id == this.id_usuario);


                if (usuario != null)
                {
                    // Asigna los valores del producto a los controles
                    TNombre.Text = usuario.Nombre;
                    TApellido.Text = usuario.Apellido;
                    TUsuario.Text = usuario.Usuario1;
                    TContraseña.Text = usuario.Pass;
                    TEmail.Text = usuario.Email;
                    CBPerfil.SelectedIndex = usuario.PerfilId - 1;
                    TDni.Text = usuario.Dni.ToString();

                    Domicilio domiciolioUsuario = newcontext.Domicilios.FirstOrDefault(p => p.Id == usuario.DomicilioId);
                    TDireccion.Text = domiciolioUsuario.Direccion;
                    TCodPostal.Text = domiciolioUsuario.CodPostal.ToString();
                    DateTime fechaConHora = new DateTime(usuario.Fecha.Year, usuario.Fecha.Month, usuario.Fecha.Day); ;
                    DTPicker.Value = fechaConHora;
                    TTelefono.Text = usuario.Tel.ToString();
                    string sexo = usuario.Sexo;

                    if (sexo == "Hombre")
                    {
                        RBHombre.Checked = true;
                    }
                    else
                    {
                        RBMujer.Checked = true;
                    }

                    if (usuario.Baja == "NO")
                    {
                        BBaja.Visible = true;
                        BAlta.Visible = false;

                    }
                    else
                    {
                        BBaja.Visible = false;
                        BAlta.Visible = true;
                    }


                }




            }
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

        private Usuario buscarUsuario(int idUsuario)
        {
            using (var context = new BdCybergearContext())
            {
                Usuario usuario = context.Usuarios.FirstOrDefault(p => p.Id == idUsuario);

                if (usuario != null)
                {
                    return usuario;
                }
                else
                {
                    return null;
                }

            }

        }

        private bool validarTelefono()
        {
            using (var context = new BdCybergearContext())
            {
                if (TTelefono.Text.Length >= 10 && TTelefono.Text.Length < 15)
                {
                    if (usuarioModificar.Tel != long.Parse(TTelefono.Text))
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
                        return true;
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
                    if (usuarioModificar.Dni != int.Parse(TDni.Text))
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
                    else
                    {
                        return true;
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
                    if (usuarioModificar.Usuario1 != TUsuario.Text)
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
                    else
                    {
                        return true;
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
                MessageBox.Show("El mínimo de caracteres aceptados para el código postal es de 2 y el máximo de 5.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (usuarioModificar.Email != TEmail.Text)
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
                        else
                        {
                            return true;
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
                // Restaura la fecha seleccionada a la fecha actual
                return true;
            }
            else
            {
                // Muestra un mensaje de error o realiza alguna acción adecuada
                MessageBox.Show("La fecha no puede ser mayor a 100 años a partir de la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTPicker.Value = fechaActual;
                return false;
            }
        }
        //---------------------Fin de Sección Validaciones----------------------

        private void BModificar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {


                try
                {
                    using (var context = new BdCybergearContext())
                    {
                        // Obtener el objeto existente que deseas actualizar
                        var usuario = context.Usuarios.Find(id_usuario);

                        // Actualizar el objeto con los nuevos datos
                        usuario.Nombre = TNombre.Text;
                        usuario.Apellido = TApellido.Text;
                        usuario.Usuario1 = TUsuario.Text;
                        usuario.Pass = TContraseña.Text;
                        usuario.Email = TEmail.Text;
                        usuario.PerfilId = CBPerfil.SelectedIndex + 1;
                        usuario.Dni = int.Parse(TDni.Text);

                        var direccionUsuario = context.Domicilios.Find(usuario.DomicilioId);
                        direccionUsuario.Direccion = TDireccion.Text;
                        direccionUsuario.CodPostal = int.Parse(TCodPostal.Text);
                        usuario.Fecha = new DateOnly(DTPicker.Value.Year, DTPicker.Value.Month, DTPicker.Value.Day);
                        usuario.Tel = long.Parse(TTelefono.Text);

                        if (RBHombre.Checked)
                        {
                            usuario.Sexo = "Hombre";
                        }
                        else
                        {
                            usuario.Sexo = "Mujer";
                        }



                        // Guardar los cambios en la base de datos
                        context.SaveChanges();
                        MessageBox.Show("¡Usuario Actualizado Correctamente!", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        private void BBaja_Click_1(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres dar de baja este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);



            // Verificar si el usuario hizo clic en "Sí"
            if (result == DialogResult.Yes)
            {
                using (var context = new BdCybergearContext())
                {
                    // Obtener el objeto existente que deseas actualizar
                    var usuario = context.Usuarios.Find(this.id_usuario);

                    usuario.Baja = "SI";

                    context.SaveChanges();
                    MessageBox.Show("Se ha dado de baja el usuario exitosamente!", "Baja Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
