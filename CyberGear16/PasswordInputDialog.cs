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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CyberGear16
{
    public partial class PasswordInputDialog : Form
    {
        private readonly BdCybergearContext _context; // DbContext de Entity Framework
        private string userIniciado;
        public PasswordInputDialog(BdCybergearContext context, string usuario)
        {
            userIniciado = usuario;
            _context = context;
            InitializeComponent();
        }





        private async Task IniciarSesionAsync(string usuario, string contraseña)
        {
            BdCybergearContext context = null;

            try
            {
                context = new BdCybergearContext();
                var usuarioEncontrado = await context.Usuarios
                    .FirstOrDefaultAsync(u => u.Usuario1 == usuario && u.Pass == contraseña);

                if (usuarioEncontrado != null)
                {
                    int perfilId = usuarioEncontrado.PerfilId;
                    string nombreUser = usuarioEncontrado.Nombre;



                    string mensajeInicio = "¡Datos correctos!";

                    // Las credenciales son válidas, el usuario ha iniciado sesión
                    MessageBox.Show(mensajeInicio, "Inicio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Oculta el formulario actual (formLogin)
                    this.Hide();
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    // Las credenciales son incorrectas
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                context?.Dispose(); // Asegúrate de liberar los recursos del contexto
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string contraseña = textBoxPassword.Text;
            await IniciarSesionAsync(userIniciado, contraseña);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
