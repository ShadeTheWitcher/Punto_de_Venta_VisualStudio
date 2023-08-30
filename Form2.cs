using MySqlConnector;
using System;
using System.Windows.Forms;

namespace CyberGear
{
    public partial class Form2 : Form
    {

        MySqlConnection con = new MySqlConnection("server=localhost;database=bd_cybergear;Uid=root ");

        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            con.Close();
        }
    }
}
