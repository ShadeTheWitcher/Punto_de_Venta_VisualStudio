using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;


namespace CyberGear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Form2();

        }

        
        MySqlConnection con = new MySqlConnection("server=localhost;database=bd_cybergear;Uid=root ");

        MySqlCommand codigo = new MySqlCommand();
        
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string usuario = textBox1.Text;
                string contraseña = textBox2.Text;

                // Consulta SQL para verificar las credenciales en la base de datos
                string consulta = "SELECT * FROM usuarios WHERE usuario = @usuario AND pass = @contraseña";
                MySqlCommand cmd = new MySqlCommand(consulta, con);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);

               

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    // Las credenciales son válidas, el usuario ha iniciado sesión
                    MessageBox.Show("Inicio de sesión exitoso");
                    // Puedes abrir otra ventana o realizar acciones adicionales aquí
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
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }






    }
    }

