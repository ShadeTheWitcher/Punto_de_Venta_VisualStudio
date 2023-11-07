using CyberGear16.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using CyberGear16.WindowsForms.SeccionBackUp;

namespace CyberGear16
{
    public partial class SubFormBackUp : Form
    {
        private readonly BdCybergearContext _context; // DbContext de Entity Framework

        public SubFormBackUp(BdCybergearContext context)
        {
            InitializeComponent();
            _context = context;

        }

        private string selectedFilePath; // Variable para almacenar la carpeta seleccionada
        private void button1_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos SQL (*.sql)|*.sql|Todos los archivos (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = openFileDialog.FileName;
                    textBox1.Text = selectedFilePath;
                }
            }
        }

        private void btnRestaurarBase_Click(object sender, EventArgs e)
        {
            // Confirmar con el usuario antes de proceder con la restauración
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas restaurar la base de datos? Esto sobrescribirá los datos actuales.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Muestra el cuadro de diálogo de "Cargando"
                var loadingForm = new FormEspera(); // Reemplaza con el nombre de tu formulario de "Cargando"
                loadingForm.Shown += async (senderForm, eForm) =>
                {
                    await Task.Run(() =>
                    {
                        try
                        {
                            // Verificar si se ha seleccionado un archivo
                            if (string.IsNullOrEmpty(selectedFilePath))
                            {
                                loadingForm.Invoke((Action)(() => loadingForm.Close())); // Cierra el cuadro de diálogo de "Cargando"
                                MessageBox.Show("Por favor, selecciona un archivo de respaldo antes de restaurar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            string connectionString = ConfigurationManager.ConnectionStrings["MiConexionMySQL"].ConnectionString;

                            using (MySqlConnection conn = new MySqlConnection(connectionString))
                            {
                                conn.Open();

                                using (MySqlCommand cmd = new MySqlCommand())
                                {
                                    cmd.Connection = conn;

                                    using (MySqlBackup mb = new MySqlBackup(cmd))
                                    {
                                        mb.ImportFromFile(selectedFilePath);
                                    }
                                }

                                loadingForm.Invoke((Action)(() => loadingForm.Close())); // Cierra el cuadro de diálogo de "Cargando"
                                MessageBox.Show("Restauración exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            loadingForm.Invoke((Action)(() => loadingForm.Close())); // Cierra el cuadro de diálogo de "Cargando"
                            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    });
                };

                loadingForm.ShowDialog();
            }

        }













    }
}
