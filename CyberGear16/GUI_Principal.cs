//using MySqlConnector;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CyberGear16;
using MySqlConnector;

namespace CyberGear16
{
    public partial class GUI_Principal : Form
    {

        MySqlConnection con = new MySqlConnection("server=localhost;database=bd_cybergear;Uid=root ");

        public GUI_Principal()
        {
            InitializeComponent();
            AbrirFormHija(new formInicio());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            con.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMax.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new formInicio());
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void CabeceraTitulo_MouseDown(object sender, MouseEventArgs e) //permite mover la ventana
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void AbrirFormHija(Form formHija)
        {
            // Cerrar formularios secundarios abiertos previamente
            foreach (Form frm in panelContenedor.Controls)
            {
                frm.Close();
            }

            // Establecer propiedades del formulario hijo
            formHija.TopLevel = false;
            formHija.FormBorderStyle = FormBorderStyle.None;
            formHija.Dock = DockStyle.Fill;

            // Agregar el formulario al panel contenedor
            panelContenedor.Controls.Add(formHija);
            panelContenedor.Tag = formHija;

            // Mostrar el formulario
            formHija.Show();


        }






        private void button1_Click(object sender, EventArgs e)
        {
           AbrirFormHija(new formProductos());
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new formInicio());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // con.Close();
        }
    }
}
