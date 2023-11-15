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

namespace CyberGear16.WindowsForms.SeccionProducto.Categoria
{
    public partial class formEditarCategoria : Form
    {

        private int id_categoria;
        public formEditarCategoria(int idCateArgs)
        {
            InitializeComponent();
            id_categoria = idCateArgs;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbDescrip_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                try
                {
                    using (var context = new BdCybergearContext())
                    {
                        // Obtener el objeto existente que deseas actualizar
                        var categoria = context.Categoria.Find(this.id_categoria);

                        // Actualizar el objeto con los nuevos datos
                        categoria.CategoriaNombre = tbNombre.Text;




                        // Guardar los cambios en la base de datos
                        context.SaveChanges();
                        MessageBox.Show("Producto actualizado correctamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public bool validarCampos()
        {
            if (string.IsNullOrEmpty(tbNombre.Text) // ||


                //  string.IsNullOrEmpty(tbDescrip.Text) 
                )
            {
                MessageBox.Show("Campos incompletos");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres dar de alta esta categoria?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); //la ultima hace q enfoque el boton 2 "NO" 



            // Verificar si el usuario hizo clic en "Sí"
            if (result == DialogResult.Yes)
            {
                using (var context = new BdCybergearContext())
                {
                    // Obtener el objeto existente que deseas actualizar
                    var categoria = context.Categoria.Find(this.id_categoria);

                    categoria.Activo = "SI";

                    context.SaveChanges();
                    MessageBox.Show("SE DIO DE ALTA LA CATEGORIA");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres dar de baja esta categoria?\n Todos los productos con esta categoria cambiaran a (sin-categoria) ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); //la ultima hace q enfoque el boton 2 "NO" 




            // Verificar si el usuario hizo clic en "Sí"
            if (result == DialogResult.Yes)
            {
                using (var context = new BdCybergearContext())
                {
                    // Obtener el objeto existente que deseas actualizar
                    var categoria = context.Categoria.Find(this.id_categoria);

                    categoria.Activo = "NO";

                    context.SaveChanges();


                    // 1. Identificar productos asociados
                    var productsAssociatedToCategory = context.Products.Where(p => p.CategoriaId == categoria.IdCategoria).ToList();

                    // 2. Actualizar productos asociados
                    foreach (var product in productsAssociatedToCategory)
                    {
                        product.CategoriaId = 1; // asigna a otra categoría predeterminada como lo es "sin categoria"
                    }

                    // Guardar cambios en la base de datos
                    context.SaveChanges();





                    MessageBox.Show("SE DIO DE BAJA LA CATEGORIA");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void formEditarCategoria_Load(object sender, EventArgs e)
        {
            recuperarDatosProduct();
        }


        private void recuperarDatosProduct()
        {

            // Asigna los valores del producto a los controles

            using (var newcontext = new BdCybergearContext())
            {  // se lo engloba en un using para q se cierre la conexion

                // Obtén el producto a través del contexto y su ID
                Categorium categoria = newcontext.Categoria.FirstOrDefault(p => p.IdCategoria == this.id_categoria);

                if (categoria != null)
                {
                    // Asigna los valores del producto a los controles
                    tbNombre.Text = categoria.CategoriaNombre;
                    
                    //tbDescrip.Text = categoria.Descripcion;

                    if (categoria.Activo == "SI")
                    {
                        button1.Visible = true;
                        button2.Visible = false;

                    }
                    else
                    {
                        button1.Visible = false;
                        button2.Visible = true;
                    }

                   


                }







            }
        }

    }
}
