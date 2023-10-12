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

namespace CyberGear16.WindowsForms.SeccionCliente
{
    public partial class FormEditorCliente : Form
    {
        private BdCybergearContext contextCliente;
        private int id_cliente;
        public FormEditorCliente(int id_clienteElegido, BdCybergearContext context)
        {
            InitializeComponent();
            id_cliente = id_clienteElegido;
            contextCliente = context;
        }

        private void FormEditorCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
