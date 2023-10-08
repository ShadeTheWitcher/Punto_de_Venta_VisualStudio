using CyberGear16.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace CyberGear16
{
    public partial class FormBackUp : Form
    {
        private readonly BdCybergearContext _context; // DbContext de Entity Framework
        private string userIniciado;
        
        public FormBackUp(BdCybergearContext context, string user)
        {
            InitializeComponent();
            userIniciado = user;
            _context = context;
            
    }


        private string selectedFolderPath; // Variable para almacenar la carpeta seleccionada
        private void button1_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFolderPath = folderDialog.SelectedPath;
                    textBox1.Text = selectedFolderPath;
                }
            }


        }

        private void btnRespaldar_Click(object sender, EventArgs e)
        {
            try
            {





                // Verificar si se ha seleccionado una carpeta
                if (string.IsNullOrEmpty(selectedFolderPath))
                {
                    MessageBox.Show("Por favor, selecciona una carpeta antes de respaldar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;  // Salir del método si no hay una carpeta seleccionada
                }

                // Nombre del archivo de respaldo
                string backupFileName = $"backup_{DateTime.Now:yyyy-MM-dd_HHmmss}.sql";

                // Ruta completa al archivo de respaldo
                string backupFilePath = Path.Combine(selectedFolderPath, backupFileName);

                // Cadena de conexión para el respaldo
                string connectionString = ConfigurationManager.ConnectionStrings["MiConexionMySQL"].ConnectionString; // Reemplaza con tu propia cadena de conexión

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open(); // Abre la conexión aquí

                    // Ahora creamos un comando y le asignamos la conexión
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            // No se necesita abrir la conexión aquí, ya que se abre arriba

                            mb.ExportToFile(backupFilePath);
                        }
                    }

                    MessageBox.Show($"Respaldo exitoso en: {backupFilePath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }


                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private async void btnRestaurarBase_Click(object sender, EventArgs e)
        {
            PasswordInputDialog passwordDialog = new PasswordInputDialog(_context, userIniciado);
            if (passwordDialog.ShowDialog() == DialogResult.OK)
            {
                // Contraseña correcta, proceder con la restauración
                SubFormBackUp subFormBackUp = new SubFormBackUp(_context);
                subFormBackUp.Show();
            }
            else
            {
                MessageBox.Show("No se ha podido acceder ", "Error de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      





    }
}
