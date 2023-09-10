using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

using MySqlConnector;
using Microsoft.EntityFrameworkCore;
using CyberGear16.Models;

namespace CyberGear16
{
    public partial class formLogin : Form
    {
        
        //private GUI_Principal form2 = new GUI_Principal();

        public formLogin()
        {
            InitializeComponent();


        }





        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string usuario = textBox1.Text;
                string contraseña = textBox2.Text;

                Task.Run(async () => //hemos envuelto la lógica de inicio de sesión en un Task.Run para ejecutarla en segundo plano y permitir el uso de await
                {
                    using (var context = new BdCybergearContext()) // se instancia el contexto y lo englobamos en un usign para q se cierre auto
                    {
                        var usuarioEncontrado = await context.Usuarios
                            .FirstOrDefaultAsync(u => u.Usuario1 == usuario && u.Pass == contraseña);

                        if (usuarioEncontrado != null)
                        {
                            int perfilId = usuarioEncontrado.PerfilId;
                            string nombreUser = usuarioEncontrado.Nombre;

                            // Crea una instancia del formulario GUI_Principal
                            GUI_Principal form2 = new GUI_Principal(perfilId, nombreUser, context);

                            // Las credenciales son válidas, el usuario ha iniciado sesión
                            MessageBox.Show("Inicio de sesión exitoso, bienvenido " + nombreUser + " tipoUsuario: " + perfilId);

                            // Oculta el formulario actual (formLogin)
                            this.Hide();

                            // Muestra el formulario GUI_Principal
                            form2.Show();
                        }
                        else
                        {
                            // Las credenciales son incorrectas
                            MessageBox.Show("Nombre de usuario o contraseña incorrectos");
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
