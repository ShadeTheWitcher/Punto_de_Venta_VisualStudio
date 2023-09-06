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
    public partial class formProductos : Form
    {
        public formProductos()
        {
            InitializeComponent();

            comboBoxCategorias.Items.Add("Videjuegos");
            comboBoxCategorias.Items.Add("PC-componentes");
        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\"; // Cambia la ruta según tu ubicación.
            openFileDialog1.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                txtFoto.Text = openFileDialog1.FileName;


                // Crear una carpeta "Images" dentro de la carpeta del proyecto
                string carpetaDestino = Path.Combine(Application.StartupPath, "Fotos");
                Directory.CreateDirectory(carpetaDestino);

                // Obtener el nombre del archivo
                string nombreArchivo = Path.GetFileName(openFileDialog1.FileName);

                // Combinar la carpeta de destino con el nombre del archivo
                string rutaArchivoDestino = Path.Combine(carpetaDestino, nombreArchivo);

                try
                {
                    // Copiar el archivo a la carpeta de destino
                    File.Copy(openFileDialog1.FileName, rutaArchivoDestino);

                    // Ahora tienes la imagen guardada en 'rutaArchivoDestino'
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
