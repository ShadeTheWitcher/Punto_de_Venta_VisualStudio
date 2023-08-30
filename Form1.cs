using MySqlConnector;
using System;
using System.Windows.Forms;


namespace CyberGear
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();


        }


        MySqlConnection con = new MySqlConnection("server=localhost;database=bd_cybergear;Uid=root ");




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

                    // Crea una instancia del formulario Form2.
                    form2 = new Form2();

                    // Oculta el formulario actual (Form1).
                    this.Hide();

                    // Muestra el formulario Form2.
                    form2.Show();
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

