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
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using CyberGear16.WindowsForms.SeccionCliente;

namespace CyberGear16
{
    public partial class FormClientes : Form
    {
        private readonly BdCybergearContext _context;

        public FormClientes(BdCybergearContext context)
        {
            InitializeComponent();
            _context = context;

        }

        private void CargarDatosEnDGVActivos()
        {
            using (var context = new BdCybergearContext())
            {

                // Vuelve a cargar los datos en el DataGridView para reflejar los cambios.
                var varClientes = context.Clientes
                .Select(p => new
                {
                    p.IdCliente,
                    p.Nombre,
                    p.Apellido,
                    p.Dni,
                    p.Email,
                    p.FechaNacimiento,
                    p.Sexo,
                    p.Telefono,
                    p.Baja
                })
                .ToList();

                var clienteNoDeBaja = context.Clientes.Where(u => u.Baja == "NO").ToList();

                DGVClientes.DataSource = clienteNoDeBaja;
            }
        }

        private void LDireccion_Click(object sender, EventArgs e)
        {

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            using (var context = new BdCybergearContext()) // se lo engloba en un using para q se cierre la conexion
            {
                // Consulta los productos desde la base de datos
                var clientes = context.Clientes
                    .Select(p => new
                    {
                        p.IdCliente,
                        p.Nombre,
                        p.Apellido,
                        p.Dni,
                        p.Email,
                        p.FechaNacimiento,
                        p.Sexo,
                        p.Telefono,
                        p.Baja
                    })
                .ToList();

                // Asigna los clientes a la fuente de datos del DataGridView
                DGVClientes.DataSource = clientes;
                CargarDatosEnDGVActivos();
                // Configura el estilo y columnas del DataGridView

                //DGVClientes.Columns["IdCliente"].Width = 40;
                //DGVClientes.Columns["DNI"].Width = 110;
                //DGVClientes.Columns["Nombre"].Width = 120;
                //DGVClientes.Columns["Apellido"].Width = 120;
                //DGVClientes.Columns["Email"].Width = 230;
                //DGVClientes.Columns["FechaNacimiento"].Width = 120;
                //DGVClientes.Columns["Telefono"].Width = 130;
                //DGVClientes.Columns["Sexo"].Width = 110;


                DataGridViewButtonColumn modificarButtonColumn = new DataGridViewButtonColumn();
                modificarButtonColumn.Name = "Acciones";
                modificarButtonColumn.Text = "Modificar/Baja-Alta";
                modificarButtonColumn.Width = 150;
                modificarButtonColumn.UseColumnTextForButtonValue = true;
                DGVClientes.Columns.Add(modificarButtonColumn);

                //DGVClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);


                // Cambia el color de fuente a negro para todas las celdas del DataGridView
                DGVClientes.DefaultCellStyle.ForeColor = Color.Black;

                // Oculta las columnas no deseadas (en este caso, ocultamos todas las demás)
                foreach (DataGridViewColumn column in DGVClientes.Columns)
                {
                    if (column.Name != "Dni" && column.Name != "Nombre" && column.Name != "Apellido" && column.Name != "Email" &&
                        column.Name != "FechaNacimiento" && column.Name != "Telefono" && column.Name != "Baja" && column.Name != "Acciones" && column.Name != "Sexo"
                        )
                    {
                        column.Visible = false;
                    }
                }
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            long telefono;
            int dni;

            if (validarCampos() && long.TryParse(TTelefono.Text, out telefono) && int.TryParse(TDni.Text, out dni))
            {

                string nombre = TNombre.Text;
                string apellido = TApellido.Text;
                string email = TEmail.Text;
                string direc = TDireccion.Text;
                int numeroDirec = int.Parse(TNumeroDirec.Text);
                DateTime fechaHora = DTPicker.Value;
                DateOnly fecha = new DateOnly(fechaHora.Year, fechaHora.Month, fechaHora.Day);
                string sexo;

                if (RBHombre.Checked)
                {
                    sexo = "Hombre";

                }
                else
                {
                    sexo = "Mujer";
                }

                try
                {
                    using (var context = new BdCybergearContext())
                    {
                        Domicilio nuevoDomicilio = new Domicilio
                        {
                            Direccion = direc,
                            CodPostal = numeroDirec
                        };

                        context.Domicilios.Add(nuevoDomicilio);

                        context.SaveChanges();
                        //TiposUsuario nuevoTipo = new TiposUsuario
                        //{
                        //    Id = indexPerfil
                        //};

                        //context.Domicilios.Add(nuevoTipo);



                        Cliente nuevoCliente = new Cliente
                        {
                            Nombre = nombre,
                            Apellido = apellido,
                            Dni = dni,
                            DomicilioId = nuevoDomicilio.Id,
                            Email = email,
                            FechaNacimiento = fecha,
                            Sexo = sexo,
                            Telefono = telefono,

                        };

                        context.Clientes.Add(nuevoCliente);

                        context.SaveChanges();



                        LimpiarCampos();
                        CargarDatosEnDGVActivos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        //-------------------------Sección Validaciones-------------------------
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

            if (validarTelefono() && validarDni() && validarNom() && validarApe()
                && validarDirec() && validarNumDirec() && validacionCorreo() && validacionFecha())
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


        private bool validarTelefono()
        {
            using (var context = new BdCybergearContext())
            {
                if (TTelefono.Text.Length >= 10 && TTelefono.Text.Length < 15)
                {
                    if (Validador.EsValorUnico(context, context.Usuarios, entidad => entidad.Tel.ToString(), TTelefono.Text))
                    {
                        return true;
                    }
                    else
                    {
                        // Muestra un mensaje de error o realiza alguna acción adecuada
                        MessageBox.Show("El Telefono ya está registrado para otro cliente. Ingresa un valor distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
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
                    if (Validador.EsValorUnico(context, context.Usuarios, entidad => entidad.Dni.ToString(), TDni.Text))
                    {
                        return true;
                    }
                    else
                    {
                        // Muestra un mensaje de error o realiza alguna acción adecuada
                        MessageBox.Show("El DNI ya está registrado para otro cliente. Ingresa un valor distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("La cantidad de caracteres del DNI debe ser de 8.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("El mínimo de caracteres aceptados para el número de dirección es de 2 y el máximo de 5.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (Validador.EsValorUnico(context, context.Usuarios, entidad => entidad.Email, TEmail.Text))
                        {
                            return true;
                        }
                        else
                        {
                            // Muestra un mensaje de error o realiza alguna acción adecuada
                            MessageBox.Show("El Email ya está registrado para otro cliente. Ingresa un valor distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
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
                    MessageBox.Show("El cliente a registrar debe de ser mayor a 6 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                // Muestra un mensaje de error o realiza alguna acción adecuada
                MessageBox.Show("La fecha no puede ser mayor a 100 años a partir de la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Restaura la fecha seleccionada a la fecha actual
                DTPicker.Value = fechaActual;
                return false;
            }
        }

        //---------------------Fin de Sección Validaciones----------------------

        private void LimpiarCampos()
        {
            TNombre.Clear();
            TApellido.Clear();
            TEmail.Clear();
            TTelefono.Clear();
            TDireccion.Clear();
            TNumeroDirec.Clear();
            TDni.Clear();
            DTPicker.Value = DateTime.Now;
        }

        private void DGVClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DGVClientes.Columns["Acciones"].Index)
            {
                // Obtén el producto seleccionado
                DataGridViewRow row = DGVClientes.Rows[e.RowIndex];
                int clienteId = Convert.ToInt32(row.Cells["IdCliente"].Value); // Asegúrate de tener una columna "IdProducto" para identificar el producto

                // Abre el formulario de detalles/editar con el Usuario seleccionado
                FormEditorCliente editorUsuario = new FormEditorCliente(clienteId, _context);
                editorUsuario.ShowDialog();
                CargarDatosEnDGVActivos();
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BActivos_Click(object sender, EventArgs e)
        {
            CargarDatosEnDGVActivos();
        }

        private void BInactivo_Click(object sender, EventArgs e)
        {
            using (var context = new BdCybergearContext())
            {
                var clientesFiltrados = context.Clientes.Where(u => u.Baja == "SI").ToList();

                // Enlazar los resultados al DataGridView.
                DGVClientes.DataSource = clientesFiltrados;

            }
        }


        private void BuscarEnBaseDeDatosYActualizarDataGridView(string buscar)
        {
            using (var context = new BdCybergearContext())
            {

                var resultados = context.Clientes.Where(e => e.Nombre.Contains(buscar) || e.Apellido.Contains(buscar)).ToList();
                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se han encontrado clientes que coincidan con la busqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarDatosEnDGVActivos();
                }
                else
                {
                    DGVClientes.DataSource = resultados;
                }
            }
        }
        private void BBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBuscar.Text))
            {
                string buscar = TBuscar.Text;
                // Llama a un método que realiza la búsqueda en la base de datos y actualiza el DataGridView.
                BuscarEnBaseDeDatosYActualizarDataGridView(buscar);
            }
            else
            {
                MessageBox.Show("No hay elementos para buscar. Por favor escriba algo y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarDatosEnDGVActivos();
            }
        }

        private void TBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter))
            {
                if (!string.IsNullOrEmpty(TBuscar.Text))
                {
                    string buscar = TBuscar.Text;
                    // Llama a un método que realiza la búsqueda en la base de datos y actualiza el DataGridView.
                    BuscarEnBaseDeDatosYActualizarDataGridView(buscar);
                }
                else
                {
                    MessageBox.Show("No hay elementos para buscar. Por favor escriba algo y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarDatosEnDGVActivos();
                }
            }
        }

        bool borrarPrimeraVez = true;

        private void TBuscar_Click(object sender, EventArgs e)
        {
            if (borrarPrimeraVez)
            {
                TBuscar.Clear();
                borrarPrimeraVez = false;
            }
        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBuscar.Text))
            {
                TBuscar.Clear();
                CargarDatosEnDGVActivos();
            }
        }
    }


}
