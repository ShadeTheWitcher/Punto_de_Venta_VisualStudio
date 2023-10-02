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
    public partial class FormInformeCliente : Form
    {
        private readonly BdCybergearContext _context;
        private Cliente usuarioClienteElegido;
        public FormInformeCliente(Cliente usuarioCliente, BdCybergearContext context)
        {
            InitializeComponent();

            this.usuarioClienteElegido = usuarioCliente;

            recuperarDatosIndividuo();
        }

        private void recuperarDatosIndividuo()
        {
            if (usuarioClienteElegido != null)
            {
                LMNombre.Text = usuarioClienteElegido.Nombre;
                LMApellido.Text = usuarioClienteElegido.Apellido;
                LMEmail.Text = usuarioClienteElegido.Email;
                LMDni.Text = usuarioClienteElegido.Dni.ToString();
                LMTelefono.Text = usuarioClienteElegido.Telefono.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LMEmail_Click(object sender, EventArgs e)
        {

        }

        private void LEmail_Click(object sender, EventArgs e)
        {

        }

        private void LMApellido_Click(object sender, EventArgs e)
        {
        }

        private void LApellido_Click(object sender, EventArgs e)
        {
        }

        private void LNombre_Click(object sender, EventArgs e)
        {
        }

        private void LDni_Click(object sender, EventArgs e)
        {

        }

        private void LMNombre_Click(object sender, EventArgs e)
        {
        }

        private void LMTelefono_Click(object sender, EventArgs e)
        {
        }

        private void LTelefono_Click(object sender, EventArgs e)
        {
        }

        private void LMDni_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
