using CyberGear16.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberGear16.WindowsForms.SeccionCliente
{
    public partial class FormEditorCliente : Form
    {
        private BdCybergearContext contextCliente;
        private int id_cliente;
        private Cliente clienteModificar;
        public FormEditorCliente(int id_clienteElegido, BdCybergearContext context)
        {
            InitializeComponent();
            id_cliente = id_clienteElegido;
            contextCliente = context;

            recuperarDatosUsuario();
            clienteModificar = buscarCliente(id_cliente);
        }

        private void FormEditorCliente_Load(object sender, EventArgs e)
        {

        }

        private void recuperarDatosUsuario()
        {
            // Asigna los valores del usuario a los controles

            using (var newcontext = new BdCybergearContext())
            {  // se lo engloba en un using para q se cierre la conexion

                // Obtén el producto a través del contexto y su ID
                Cliente usuario = newcontext.Clientes.FirstOrDefault(p => p.IdCliente == this.id_cliente);


                if (usuario != null)
                {
                    // Asigna los valores del producto a los controles
                    TNombre.Text = usuario.Nombre;
                    TApellido.Text = usuario.Apellido;
                    TEmail.Text = usuario.Email;
                    TDni.Text = usuario.Dni.ToString();

                    Domicilio domiciolioUsuario = newcontext.Domicilios.FirstOrDefault(p => p.Id == usuario.DomicilioId);
                    TDireccion.Text = domiciolioUsuario.Direccion;
                    TNumeroDirec.Text = domiciolioUsuario.CodPostal.ToString();
                    DateTime fechaConHora = new DateTime(usuario.FechaNacimiento.Year, usuario.FechaNacimiento.Month, usuario.FechaNacimiento.Day); ;
                    DTPicker.Value = fechaConHora;
                    TTelefono.Text = usuario.Telefono.ToString();
                    string sexo = usuario.Sexo;

                    if (sexo == "Hombre")
                    {
                        RBHombre.Checked = true;
                    }
                    else
                    {
                        RBMujer.Checked = true;
                    }

                    if (usuario.Baja == "NO")
                    {
                        BBaja.Visible = true;
                        BAlta.Visible = false;

                    }
                    else
                    {
                        BBaja.Visible = false;
                        BAlta.Visible = true;
                    }


                }




            }
        }

        public bool validarCampos()
        {
            if (string.IsNullOrEmpty(TNombre.Text) ||
                string.IsNullOrEmpty(TApellido.Text) ||
                string.IsNullOrEmpty(TDni.Text) ||
                string.IsNullOrEmpty(TEmail.Text) ||
                string.IsNullOrEmpty(TTelefono.Text) ||
                DTPicker.Value > DateTime.Today ||
                string.IsNullOrEmpty(TDireccion.Text) ||
                string.IsNullOrEmpty(TNumeroDirec.Text) ||
                ((!RBHombre.Checked) && (!RBMujer.Checked)))
            {
                MessageBox.Show("Campos incompletos! Por favor rellénelos y vuelva a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (validarTelefono() && validarDni() && validarNom() && validarApe() &&
                validarDirec() && validarNumDirec() && validacionCorreo() && validacionFecha())
            {
                return true;
            }

            return false;
        }


        public class Validador
        {
            public static bool EsValorUnico<T>(DbContext context, DbSet<T> dbSet, Func<T, string> propiedadSelector, string valor)
                where T : class
            {
                // Obtén todos los registros de la tabla y luego realiza la comparación en memoria.
                var todosLosRegistros = dbSet.AsEnumerable();

                return !todosLosRegistros.Any(entidad => propiedadSelector(entidad) == valor);
            }
            /*DbSet<T> dbSet: Un conjunto de entidades del tipo genérico T.
            Esto se utiliza para especificar la tabla de la base de datos con la que deseas trabajar.*/
            /*Func<T, string> propiedadSelector: Una función que toma una entidad del tipo T y devuelve una cadena (string). 
            Esta función se utiliza para seleccionar la propiedad que deseas comparar con el valor ingresado.*/
        }

        private Cliente buscarCliente(int idUsuario)
        {
            using (var context = new BdCybergearContext())
            {
                Cliente cliente = context.Clientes.FirstOrDefault(p => p.IdCliente == idUsuario);

                if (cliente != null)
                {
                    return cliente;
                }
                else
                {
                    return null;
                }

            }

        }

        private bool validarTelefono()
        {
            using (var context = new BdCybergearContext())
            {
                if (TTelefono.Text.Length >= 10 && TTelefono.Text.Length < 15)
                {
                    if (clienteModificar.Telefono != long.Parse(TTelefono.Text))
                    {
                        if (Validador.EsValorUnico(context, context.Usuarios, entidad => entidad.Tel.ToString(), TTelefono.Text))
                        {
                            return true;
                        }
                        else
                        {
                            // Muestra un mensaje de error o realiza alguna acción adecuada
                            MessageBox.Show("El Telefono ya está registrado para otro usuario. Ingresa un valor distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("El mínimo de caracteres aceptados para el telefono es de 10 y el máximo de 15.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }



        }

        private bool validarDni()
        {
            if (TDni.Text.Length == 8)
            {
                using (var context = new BdCybergearContext())
                {
                    if (clienteModificar.Dni != int.Parse(TDni.Text))
                    {
                        if (Validador.EsValorUnico(context, context.Usuarios, entidad => entidad.Dni.ToString(), TDni.Text))
                        {
                            return true;
                        }
                        else
                        {
                            // Muestra un mensaje de error o realiza alguna acción adecuada
                            MessageBox.Show("El DNI ya está registrado para otro usuario. Ingresa un valor distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else
            {
                MessageBox.Show("La cantidad de caracteres del DNI debe ser de 8.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool validacionCharEstandar(string textComprobar)
        {
            if ((textComprobar.Length > 2) && (textComprobar.Length <= 15))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool validarNom()
        {
            if (validacionCharEstandar(TNombre.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El mínimo de caracteres aceptados para el nombre es de 3 y el máximo de 15.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool validarApe()
        {
            if (validacionCharEstandar(TApellido.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El mínimo de caracteres aceptados para el apellido es de 3 y el máximo de 15.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool validarDirec()
        {
            if (TDireccion.Text.Length > 2 && TDireccion.Text.Length <= 20)
            {
                return true;
            }
            else
            {
                MessageBox.Show("El mínimo de caracteres aceptados para la dirección es de 3 y el máximo de 20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool validarNumDirec()
        {
            if (TNumeroDirec.Text.Length >= 2 && TNumeroDirec.Text.Length <= 5)
            {
                return true;
            }
            else
            {
                MessageBox.Show("El mínimo de caracteres aceptados para el código postal es de 2 y el máximo de 5.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool validacionCorreo()
        {
            try
            {
                // Utiliza una expresión regular para validar el formato del correo electrónico.
                string patrón = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (Regex.IsMatch(TEmail.Text, patrón))
                {
                    using (var context = new BdCybergearContext())
                    {
                        if (clienteModificar.Email != TEmail.Text)
                        {
                            if (Validador.EsValorUnico(context, context.Usuarios, entidad => entidad.Email, TEmail.Text))
                            {
                                return true;
                            }
                            else
                            {
                                // Muestra un mensaje de error o realiza alguna acción adecuada
                                MessageBox.Show("El Email ya está registrado para otro usuario. Ingresa un valor distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }

                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Formato de correo electrónico incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                // La expresión regular tardó demasiado en ejecutarse, lo que podría indicar un patrón inválido.
                MessageBox.Show("Formato de correo electrónico incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool validacionFecha()
        {
            // Obtén la fecha seleccionada en el DateTimePicker
            DateTime fechaDTPicker = DTPicker.Value;

            // Obtén la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Calcula la diferencia en años entre la fecha seleccionada y la fecha actual
            int diferenciaAños = fechaActual.Year - fechaDTPicker.Year;

            // Verifica si la diferencia es mayor que 100 años
            if (diferenciaAños < 100)
            {
                if (diferenciaAños >= 7)
                {
                    return true;
                }
                else
                {
                    DTPicker.Value = fechaActual;
                    MessageBox.Show("El cliente a modificar debe de ser mayor a 6 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                // Muestra un mensaje de error o realiza alguna acción adecuada
                MessageBox.Show("La fecha no puede ser mayor a 100 años a partir de la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTPicker.Value = fechaActual;
                return false;
            }
        }
        //---------------------Fin de Sección Validaciones----------------------
        private void BModificar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {


                try
                {
                    using (var context = new BdCybergearContext())
                    {
                        // Obtener el objeto existente que deseas actualizar
                        var cliente = context.Clientes.Find(id_cliente);

                        // Actualizar el objeto con los nuevos datos
                        cliente.Nombre = TNombre.Text;
                        cliente.Apellido = TApellido.Text;
                        cliente.Email = TEmail.Text;
                        cliente.Dni = int.Parse(TDni.Text);

                        var direccionUsuario = context.Domicilios.Find(cliente.DomicilioId);
                        direccionUsuario.Direccion = TDireccion.Text;
                        direccionUsuario.CodPostal = int.Parse(TNumeroDirec.Text);
                        cliente.FechaNacimiento = new DateOnly(DTPicker.Value.Year, DTPicker.Value.Month, DTPicker.Value.Day);
                        cliente.Telefono = long.Parse(TTelefono.Text);

                        if (RBHombre.Checked)
                        {
                            cliente.Sexo = "Hombre";
                        }
                        else
                        {
                            cliente.Sexo = "Mujer";
                        }



                        // Guardar los cambios en la base de datos
                        context.SaveChanges();
                        MessageBox.Show("¡Cliente Actualizado Correctamente!", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void BAlta_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres dar de alta a este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            // Verificar si el usuario hizo clic en "Sí"
            if (result == DialogResult.Yes)
            {
                using (var context = new BdCybergearContext())
                {
                    // Obtener el objeto existente que deseas actualizar
                    var cliente = context.Clientes.Find(this.id_cliente);

                    cliente.Baja = "NO";

                    context.SaveChanges();
                    MessageBox.Show("Se ha dado de alta al cliente correctamente!", "Alta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BBaja_Click_1(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres dar de baja a este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);



            // Verificar si el usuario hizo clic en "Sí"
            if (result == DialogResult.Yes)
            {
                using (var context = new BdCybergearContext())
                {
                    // Obtener el objeto existente que deseas actualizar
                    var cliente = context.Clientes.Find(this.id_cliente);

                    cliente.Baja = "SI";

                    context.SaveChanges();
                    MessageBox.Show("Se ha dado de baja el cliente exitosamente!", "Baja Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
