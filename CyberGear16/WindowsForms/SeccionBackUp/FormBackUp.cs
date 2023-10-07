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

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\"; // Cambia la ruta según tu ubicación.
                                                       //openFileDialog1.Filter = "Archivos sql (*.sql;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                                                       //openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;



            }


        }

        private void btnRespaldar_Click(object sender, EventArgs e)
        {

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
