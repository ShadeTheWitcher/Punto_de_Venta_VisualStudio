using CyberGear16.Models;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI.Relational;
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
    public partial class FormReporteVendedor : Form
    {
        int perfilIdUsuario;
        int dniUsuario;

        public FormReporteVendedor(int perfil_Id, int dniUser)
        {
            InitializeComponent();

            perfilIdUsuario = perfil_Id;
            dniUsuario = dniUser;
        }

        private void BRVendedor_Click(object sender, EventArgs e)
        {

            using (var context = new BdCybergearContext())
            {
                Usuario vendedorOperando = context.Usuarios.FirstOrDefault(p => p.PerfilId == perfilIdUsuario && p.Dni == dniUsuario);


                //if (vendedorOperando != null)
                //{
                //    FormInformeVendedor informeVendedorOperando = new FormInformeVendedor(vendedorOperando, context);
                //    informeVendedorOperando.ShowDialog();
                //}

            }
        }
    }
}
