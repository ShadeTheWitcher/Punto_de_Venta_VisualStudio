
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CyberGear16;
using MySqlConnector;
using CyberGear16.Models;
using CyberGear16.WindowsForms.Seccion_Catalogo;
using CyberGear16.WindowsForms.SeccionReportes;

namespace CyberGear16
{
    public partial class GUI_Principal : Form
    {

        int perfil_idUsuario;
        string nombreUser;
        string usuario;
        int dniUsuario;


        private readonly BdCybergearContext _context;

        public GUI_Principal(int perfilIdUsuario, string nombreUsuario, string usuarioArgs, int dniUser, BdCybergearContext context)
        {
            InitializeComponent();
            AbrirFormHija(new formInicio());
            perfil_idUsuario = perfilIdUsuario;
            nombreUser = nombreUsuario;
            usuario = usuarioArgs;
            dniUsuario = dniUser;
            _context = context; // Guarda el contexto de base de datos
            establecerLimitesTipoUser();
        }

        public BdCybergearContext ObtenerContexto()
        {
            return _context;
        }
        private void establecerLimitesTipoUser()
        {
            LNomUser.Text = nombreUser;




            if (perfil_idUsuario == 1) //admin
            {
                LTipoUser.Text = "Admin";
                btnVentas.Enabled = false;
                panel1.BackColor = Color.DimGray;

                btnClientes.Enabled = false;
                panel6.BackColor = Color.DimGray;

                btnBackUp.Enabled = false;
                panel7.BackColor = Color.DimGray;
            }


            if (perfil_idUsuario == 2) //gerente
            {
                LTipoUser.Text = "Gerente";


                btnVentas.Enabled = false;
                panel1.BackColor = Color.DimGray;

                btnClientes.Enabled = false;
                panel6.BackColor = Color.DimGray;

                btnProductos.Enabled = false;
                panel4.BackColor = Color.DimGray;

                btnUsuarios.Enabled = false;
                panel5.BackColor = Color.DimGray;
            }

            if (perfil_idUsuario == 3) //vendedor
            {

                LTipoUser.Text = "Vendedor";
                btnProductos.Enabled = false;
                panel4.BackColor = Color.DimGray;

                //btnProductos.Text = "Catalogo";

                btnUsuarios.Enabled = false;
                panel5.BackColor = Color.DimGray;

                btnBackUp.Enabled = false;
                panel7.BackColor = Color.DimGray;
            }


        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

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
            AbrirFormHija(new adminUsers(_context));
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        //Arrastrar pesta�a
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        //Posici�n
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void CabeceraTitulo_MouseDown(object sender, MouseEventArgs e) //permite mover la ventana
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void AbrirFormHija(Form formHija)
        {
            // Verificar si el formulario hijo ya est� abierto
            if (formHija.Visible)
            {
                // Si est� abierto, no es necesario hacer nada m�s
                return;
            }

            // Establecer propiedades del formulario hijo
            formHija.TopLevel = false;
            formHija.FormBorderStyle = FormBorderStyle.None;
            formHija.Dock = DockStyle.Fill;

            // Cerrar formularios secundarios abiertos previamente
            foreach (Form frm in panelContenedor.Controls)
            {
                frm.Close();
            }

            // Agregar el formulario al panel contenedor
            panelContenedor.Controls.Add(formHija);
            panelContenedor.Tag = formHija;

            // Mostrar el formulario
            formHija.Show();

        }






        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new formProductos(_context));
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

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormBackUp(_context, usuario));
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormSeccionVentas(_context, dniUsuario));
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormClientes(_context));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (perfil_idUsuario == 1)
            {
                panelSubMenuReportes.Visible = true;
                //AbrirFormHija(new FormReporte(/*_context*/));

            }
            else if (perfil_idUsuario == 2)
            {
                AbrirFormHija(new FormReporteSuper());
                //panelSubMenuReportes.Visible = true;

            }
            else
            {
                AbrirFormHija(new FormReporteVendedor(perfil_idUsuario, dniUsuario));
            }

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContenedor_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void GUI_Principal_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReportClient_Click(object sender, EventArgs e)
        {
            string tipoReporte = "Cliente";
            panelSubMenuReportes.Visible = false; //desaparece el submenu despues de dar click
            AbrirFormHija(new FormReporteSubMenu(tipoReporte));
        }

        private void btnReportVendedor_Click(object sender, EventArgs e)
        {
            string tipoReporte = "Vendedor";
            panelSubMenuReportes.Visible = false; //desaparece el submenu despues de dar click
            AbrirFormHija(new FormReporteSubMenu(tipoReporte));
        }

        private void panelSubMenuReportes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
