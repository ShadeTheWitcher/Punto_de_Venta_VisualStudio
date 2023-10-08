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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CyberGear16
{
    public partial class formEditorProducto : Form
    {

        private BdCybergearContext context;
        private int id_product;

        public formEditorProducto(int id_producto, BdCybergearContext context)
        {
            InitializeComponent();
            id_product = id_producto;
            comboBoxCategorias.Items.Add("Videjuegos");
            comboBoxCategorias.Items.Add("PC-componentes");


            this.id_product = id_producto;
            this.context = context;

            recuperarDatosProduct();


        }

        private void recuperarDatosProduct()
        {

            // Asigna los valores del producto a los controles

            using (var newcontext = new BdCybergearContext())
            {  // se lo engloba en un using para q se cierre la conexion

                // Obtén el producto a través del contexto y su ID
                Product producto = newcontext.Products.FirstOrDefault(p => p.Id == this.id_product);

                if (producto != null)
                {
                    // Asigna los valores del producto a los controles
                    tbNombre.Text = producto.NombreProducto;
                    tbPrecio.Text = producto.PrecioProducto.ToString();
                    tbStock.Text = producto.Cantidad.ToString();
                    tbStockMin.Text = producto.StockMinimo.ToString();
                    comboBoxCategorias.SelectedIndex = producto.CategoriaId - 1;
                    tbDescrip.Text = producto.Descripcion;

                    if (producto.Activo == "SI")
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




        private void label1_Click(object sender, EventArgs e)
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
                        var producto = context.Products.Find(this.id_product);

                        // Actualizar el objeto con los nuevos datos
                        producto.NombreProducto = tbNombre.Text;
                        producto.PrecioProducto = Double.Parse(tbPrecio.Text);
                        producto.Cantidad = int.Parse(tbStock.Text);
                        producto.StockMinimo = int.Parse(tbStockMin.Text);
                        producto.Descripcion = tbDescrip.Text;
                        producto.CategoriaId = comboBoxCategorias.SelectedIndex + 1;



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
            if (string.IsNullOrEmpty(tbNombre.Text) ||
                string.IsNullOrEmpty(tbPrecio.Text) ||
                string.IsNullOrEmpty(tbStock.Text) ||
                string.IsNullOrEmpty(tbDescrip.Text) ||
                comboBoxCategorias.SelectedIndex == -1)
            {
                MessageBox.Show("Campos incompletos");
                return false;
            }
            return true;
        }








        private void btnBaja_Click(object sender, EventArgs e)
        {


        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres dar de baja este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); //la ultima hace q enfoque el boton 2 "NO" 



            // Verificar si el usuario hizo clic en "Sí"
            if (result == DialogResult.Yes)
            {
                using (var context = new BdCybergearContext())
                {
                    // Obtener el objeto existente que deseas actualizar
                    var producto = context.Products.Find(this.id_product);

                    producto.Activo = "NO";

                    context.SaveChanges();
                    MessageBox.Show("SE DIO DE BAJA EL PRODUCTO");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres dar de alta este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); //la ultima hace q enfoque el boton 2 "NO" 



            // Verificar si el usuario hizo clic en "Sí"
            if (result == DialogResult.Yes)
            {
                using (var context = new BdCybergearContext())
                {
                    // Obtener el objeto existente que deseas actualizar
                    var producto = context.Products.Find(this.id_product);

                    producto.Activo = "SI";

                    context.SaveChanges();
                    MessageBox.Show("SE DIO DE ALTA EL PRODUCTO");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formEditorProducto_Load(object sender, EventArgs e)
        {

        }

        private void LCategoria_Click(object sender, EventArgs e)
        {

        }

        private void PStockMin_Paint(object sender, PaintEventArgs e)
        {
            // Dibuja el fondo del Panel como transparente
            e.Graphics.Clear(Color.Transparent);

            // Dibuja el contenido del Label (texto)
            using (Brush brush = new SolidBrush(LStockMin.ForeColor))
            {
                e.Graphics.DrawString(LStockMin.Text, LStockMin.Font, brush, new PointF(0, 0));
            }
        }

        private void LStockMin_Click(object sender, EventArgs e)
        {

        }
    }
}
