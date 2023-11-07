using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

using MySqlConnector;
using Microsoft.EntityFrameworkCore;
using CyberGear16.Models;
using System.Diagnostics;
using PdfiumViewer;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CyberGear16
{
    public partial class formLogin : Form
    {

        //private GUI_Principal form2 = new GUI_Principal();

        public formLogin()
        {
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
                    int dniUsuario = usuarioEncontrado.Dni;
                    int idUsuario = usuarioEncontrado.Id;


                    // Crea una instancia del formulario GUI_Principal
                    GUI_Principal form2 = new GUI_Principal(idUsuario, perfilId, nombreUser, usuario, dniUsuario, context);

                    string mensajeInicio = "¡Inicio de sesión exitoso!" + Environment.NewLine + "  Bienvenido: " + nombreUser;

                    // Las credenciales son válidas, el usuario ha iniciado sesión
                    MessageBox.Show(mensajeInicio, "Inicio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Oculta el formulario actual (formLogin)
                    this.Hide();

                    // Muestra el formulario GUI_Principal
                    form2.Show();
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



        private async void button1_Click_1(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, completa ambos campos.");
                return;
            }


            await IniciarSesionAsync(usuario, contraseña);
        }

        private void BOcultar_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                BOcultar.Image = Properties.Resources.visibilidad;
                // Mostrar la contraseña en texto plano
                textBox2.PasswordChar = '\0'; // Carácter nulo para mostrar el texto
            }
            else
            {
                BOcultar.Image = Properties.Resources.cerrado;
                // Ocultar la contraseña
                textBox2.PasswordChar = '*'; // Carácter de contraseña
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }





        private PdfViewer pdfViewer;






        private void MostrarManualPDF()
        {

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int numeroPagina = 3;
            CerrarManual.Visible = true;
            panelManual.Visible = true;
            // Nombre del archivo del manual PDF
            string nombreManualPDF = "manual.pdf";

            // Obtiene la ruta del directorio de inicio de la aplicación
            string directorioBase = AppDomain.CurrentDomain.BaseDirectory;

            // Combina la ruta base con el nombre del manual PDF
            string rutaManualPDF = Path.Combine(directorioBase, nombreManualPDF);

            // Verifica si el archivo existe
            if (File.Exists(rutaManualPDF))
            {
                // Crea la URL del archivo local
                string urlArchivoLocal = new Uri(rutaManualPDF).AbsoluteUri;

                // Agrega el número de página como fragmento a la URL
                string urlConPagina = urlArchivoLocal + "#page=" + numeroPagina;

                // Crea una instancia de WebBrowser
                WebBrowser webBrowser = new WebBrowser();
                webBrowser.Dock = DockStyle.Fill;

                // Agrega el control WebBrowser al panel
                panelManual.Controls.Add(webBrowser);

                // Carga la URL con el fragmento de la página en el control WebBrowser
                webBrowser.Navigate(urlConPagina);
            }
            else
            {
                // El archivo no existe, muestra un mensaje de error
                MessageBox.Show("El manual no se encuentra en la ubicación especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            panelManual.Visible = false;
            //panelManual.Enabled = false;
            CerrarManual.Visible = false;
        }
    }
}
