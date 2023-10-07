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



            try
            {
                // Verificar si se ha seleccionado un archivo
                if (string.IsNullOrEmpty(selectedFilePath))
                {
                    MessageBox.Show("Por favor, selecciona un archivo de respaldo antes de restaurar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmar con el usuario antes de proceder con la restauración
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas restaurar la base de datos? Esto sobrescribirá los datos actuales.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
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

                        MessageBox.Show("Restauración exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
