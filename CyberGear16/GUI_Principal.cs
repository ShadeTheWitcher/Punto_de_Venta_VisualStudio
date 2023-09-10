
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CyberGear16;
using MySqlConnector;

namespace CyberGear16
{
    public partial class GUI_Principal : Form
    {

        int perfil_idUsuario;
        string nombreUser;

        MySqlConnection con = new MySqlConnection("server=localhost;database=bd_cybergear;Uid=root ");

        public GUI_Principal(int perfilIdUsuario, string nombreUsuario)
        {
            InitializeComponent();
            AbrirFormHija(new formInicio());
            perfil_idUsuario = perfilIdUsuario;
            nombreUser = nombreUsuario;
            establecerLimitesTipoUser();
        }


        private void establecerLimitesTipoUser()
        {
            LNomUser.Text = nombreUser;
            

            if (perfil_idUsuario == 1) //admin
            {
                LTipoUser.Text = "Admin" ;
                btnVentas.Enabled = false;
                panel1.BackColor = Color.White;

                btnClientes.Enabled = false;
                panel6.BackColor = Color.White;
            }


            if (perfil_idUsuario == 2) //vendedor
            {
                LTipoUser.Text = "Vendedor";
                btnProductos.Enabled = false;
                panel4.BackColor = Color.White;

                btnUsuarios.Enabled = false;
                panel5.BackColor = Color.White;
            }

            if (perfil_idUsuario == 3) //gerente
            {
                LTipoUser.Text = "Gerente";
                btnVentas.Enabled = false;
                panel1.BackColor = Color.White;

                btnClientes.Enabled = false;
                panel6.BackColor = Color.White;

                btnProductos.Enabled = false;
                panel4.BackColor = Color.White;

                btnUsuarios.Enabled = false;
                panel5.BackColor = Color.White;
            }


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
            AbrirFormHija(new adminUsers());
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
            formLogin formL = new formLogin();

            // Oculta el formulario actual.
            this.Hide();
            formL.Show();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // con.Close();
        }

        private void LNomUser_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
