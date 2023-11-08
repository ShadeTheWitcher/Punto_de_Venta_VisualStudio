using CyberGear16.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CyberGear16.WindowsForms.SeccionProducto.Categoria
{
    public partial class formCrudCategoria : Form
    {
        public formCrudCategoria()
        {
            InitializeComponent();
            CargarDatosEnDataGridView();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string nombre = textBox1.Text;
                string descripcion = textBox4.Text;


                try
                {
                    using (var context = new BdCybergearContext()) // Crea un nuevo contexto
                    {
                        // Crea una nueva instancia de Producto y configura sus propiedades.
                        Categorium nuevaCategoria = new Categorium
                        {
                            CategoriaNombre = nombre,

                        };

                        // Agrega el producto al contexto.
                        context.Categoria.Add(nuevaCategoria);

                        // Guarda los cambios en la base de datos.
                        context.SaveChanges();

                        MessageBox.Show("Categoria agregada correctamente");
                        LimpiarCampos();
                        CargarDatosEnDataGridView();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el categoria: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, comingresa valores numéricos válidos en los campos.");
            }
        }




        public bool validarCampos()
        {
            if (string.IsNullOrEmpty(textBox1.Text) // || 

                //string.IsNullOrEmpty(textBox4.Text) 
                )
            {
                MessageBox.Show("Campos incompletos");
                return false;
            }
            return true;
        }



        private void CargarDatosEnDataGridView(string filtro = "")
        {
            using (var context = new BdCybergearContext())
            {
                IQueryable<Categorium> productosQuery = context.Categoria;

                // Aplicar filtro si se proporciona
                if (!string.IsNullOrEmpty(filtro))
                {
                    productosQuery = productosQuery.Where(p => p.CategoriaNombre.Contains(filtro));
                }

                // Obtener los productos
                List<Categorium> categoriaDesdeBD = productosQuery.ToList();

                // Limpiar las filas
                dataGridView1.Rows.Clear();

                // Cambiar el color de fuente a negro para todas las celdas del DataGridView
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

                foreach (var categoria in categoriaDesdeBD)
                {
                    // Extraer la información de la base de datos
                    int id_categoria = categoria.IdCategoria;
                    string nombreCategoria = categoria.CategoriaNombre ?? "";
                    string activo = categoria.Activo;



                    // Crear una nueva fila en la tabla
                    DataGridViewRow nuevaFila = new DataGridViewRow();
                    nuevaFila.CreateCells(dataGridView1);

                    nuevaFila.Cells[0].Value = id_categoria;
                    nuevaFila.Cells[1].Value = nombreCategoria;
                    nuevaFila.Cells[3].Value = activo;


                    // Añadir la fila al DataGridView
                    dataGridView1.Rows.Add(nuevaFila);


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario y, por lo tanto, el panel en formProductos se hará visible nuevamente
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns[4].Index)
            {
                int categoriaNoEditable = 1;

                // Obtén el producto seleccionado
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int categoriaId = Convert.ToInt32(row.Cells[0].Value); // obtenemso la id

                if(categoriaId == categoriaNoEditable) {
                    MessageBox.Show("No se puede editar esto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Abre el formulario de detalles/editar con el producto seleccionado
                formEditarCategoria editorCategoria = new formEditarCategoria(categoriaId);
                editorCategoria.ShowDialog();
                CargarDatosEnDataGridView();
            }
        }



        private void LimpiarCampos()
        {
            textBox1.Clear();

            textBox4.Clear();


        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }

}
