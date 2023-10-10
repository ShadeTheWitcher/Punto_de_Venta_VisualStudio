namespace CyberGear16.WindowsForms.Seccion_Catalogo
{
    partial class ProductoControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            labelNombre = new Label();
            pictureBox1 = new PictureBox();
            labelPrecio = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.Anchor = AnchorStyles.None;
            labelNombre.AutoSize = true;
            labelNombre.BackColor = Color.Transparent;
            labelNombre.Location = new Point(31, 193);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.Producto_sin_imagen;
            pictureBox1.InitialImage = Properties.Resources.Producto_sin_imagen;
            pictureBox1.Location = new Point(31, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelPrecio
            // 
            labelPrecio.Anchor = AnchorStyles.None;
            labelPrecio.AutoSize = true;
            labelPrecio.BackColor = Color.Transparent;
            labelPrecio.Location = new Point(31, 223);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(40, 15);
            labelPrecio.TabIndex = 2;
            labelPrecio.Text = "Precio";
            // 
            // button1
            // 
            button1.Location = new Point(55, 250);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 3;
            button1.Text = "Agregar al carrito";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProductoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(button1);
            Controls.Add(labelPrecio);
            Controls.Add(pictureBox1);
            Controls.Add(labelNombre);
            DoubleBuffered = true;
            Name = "ProductoControl";
            Size = new Size(238, 290);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombre;
        private PictureBox pictureBox1;
        private Label labelPrecio;
        private Button button1;
    }
}
