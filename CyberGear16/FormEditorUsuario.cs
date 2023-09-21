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
    public partial class FormEditorUsuario : Form
    {
        private BdCybergearContext context;
        private int id_usuario;

        public FormEditorUsuario(int id_usuarioElegido, BdCybergearContext context)
        {
            InitializeComponent();
            id_usuario = id_usuarioElegido;
            CBPerfil.Items.Add("Admin");
            CBPerfil.Items.Add("Supervisor");
            CBPerfil.Items.Add("Vendedor");


            this.id_usuario = id_usuarioElegido;
            this.context = context;

            recuperarDatosUsuario();

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
                    MessageBox.Show("Se ha dado de alta al usuario correctamente!");

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
                MessageBox.Show("Campos incompletos! Por favor rellénelos y vuelva a intentar.");
                return false;
            }
            return true;
        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {


                try
                {
                    using (var context = new BdCybergearContext())
                    {
                        // Obtener el objeto existente que deseas actualizar
                        var usuario = context.Usuarios.Find(this.id_usuario);

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
                        usuario.Tel = int.Parse(TTelefono.Text);

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
                        MessageBox.Show("Usuario Actualizado Correctamente");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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
                    MessageBox.Show("Se ha dado de baja el usuario exitosamente!");
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
    }
}
