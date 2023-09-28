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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CyberGear16
{
    public partial class FormInformeVendedor : Form
    {
        private readonly BdCybergearContext _context;
        private Usuario usuarioVendedorElegido;
        public FormInformeVendedor(Usuario usuarioVendedor, BdCybergearContext context)
        {
            InitializeComponent();

            this.usuarioVendedorElegido = usuarioVendedor;
            //this.dniIndividuo = dniIndividuoElegido;

            recuperarDatosIndividuo();
        }

        private void recuperarDatosIndividuo()
        {
            if (usuarioVendedorElegido != null)
            {
                // Asigna los valores del producto a los controles
                LMNombre.Text = usuarioVendedorElegido.Nombre;
                LMApellido.Text = usuarioVendedorElegido.Apellido;
                LMEmail.Text = usuarioVendedorElegido.Email;
                LMDni.Text = usuarioVendedorElegido.Dni.ToString();
                DateTime fechaConHora = new DateTime(usuarioVendedorElegido.Fecha.Year, usuarioVendedorElegido.Fecha.Month, usuarioVendedorElegido.Fecha.Day); ;
                DTPFecha.Value = fechaConHora;
                LMTelefono.Text = usuarioVendedorElegido.Tel.ToString();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
