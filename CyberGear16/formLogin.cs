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

namespace CyberGear16
{
    public partial class formLogin : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=bd_cybergear;Uid=root ");
        //private GUI_Principal form2 = new GUI_Principal();

        public formLogin()
        {
            InitializeComponent();


        }





        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string usuario = textBox1.Text;
                string contraseña = textBox2.Text;

                // Consulta SQL para verificar las credenciales en la base de datosH
                string consulta = "SELECT * FROM usuarios WHERE usuario = @usuario AND pass = @contraseña";
                MySqlCommand cmd = new MySqlCommand(consulta, con);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);



                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    
                    

                    while (reader.Read())
                    {
                        int perfilId = reader.GetInt32("perfil_id"); // Ajusta el nombre de la columna según tu esquema
                        string nombreUser = reader.GetString("nombre"); // Ajusta el nombre de la columna según tu esquema




                        //pasaje de datos a GUI_Principal
                        GUI_Principal form2 = new GUI_Principal(perfilId, nombreUser);






                        // Las credenciales son válidas, el usuario ha iniciado sesión
                        MessageBox.Show("Inicio de sesión exitoso " + "bienvenido " + nombreUser + " tipoUsuario:"+ perfilId);
                        // Puedes abrir otra ventana o realizar acciones adicionales aquí

                        // Crea una instancia del formulario Form2.


                        // Oculta el formulario actual (Form1).
                        this.Hide();

                        // Muestra el formulario Form2.
                        form2.Show();
                    }
                }
                else
                {
                    // Las credenciales son incorrectas
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos");
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al intentar conectarse con la base de datos: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
