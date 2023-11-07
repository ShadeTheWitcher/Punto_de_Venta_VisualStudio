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
using CyberGear16.WindowsForms.SeccionBackUp;

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

            // Muestra el cuadro de diálogo de "Cargando"
            var loadingForm = new FormEspera(); // Reemplaza con el nombre de tu formulario de "Cargando"
            loadingForm.Shown += async (senderForm, eForm) =>
            {
                // Este código se ejecutará después de que se muestre el formulario de "Cargando"

                await Task.Run(() =>
                {
                    try
                    {
                        // Tu código de respaldo aquí

                        // Nombre del archivo de respaldo
                        string backupFileName = $"backup_{DateTime.Now:yyyy-MM-dd_HHmmss}.sql";
                        string backupFilePath = Path.Combine(selectedFolderPath, backupFileName);
                        string connectionString = ConfigurationManager.ConnectionStrings["MiConexionMySQL"].ConnectionString;

                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            using (MySqlCommand cmd = conn.CreateCommand())
                            {
                                using (MySqlBackup mb = new MySqlBackup(cmd))
                                {
                                    mb.ExportToFile(backupFilePath);
                                }
                            }
                        }

                        loadingForm.Invoke((Action)(() => loadingForm.Close())); // Cierra el cuadro de diálogo de "Cargando"

                        MessageBox.Show($"Respaldo exitoso en: {backupFilePath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        loadingForm.Invoke((Action)(() => loadingForm.Close())); // Cierra el cuadro de diálogo de "Cargando"

                        MessageBox.Show($"Error durante el respaldo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            };

            loadingForm.ShowDialog();

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
