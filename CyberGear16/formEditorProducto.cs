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
    public partial class formEditorProducto : Form
    {
        int id_product;
        public formEditorProducto(int id_producto)
        {
            InitializeComponent();
            id_product = id_producto;
            comboBoxCategorias.Items.Add("Videjuegos");
            comboBoxCategorias.Items.Add("PC-componentes");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }
    }
}
