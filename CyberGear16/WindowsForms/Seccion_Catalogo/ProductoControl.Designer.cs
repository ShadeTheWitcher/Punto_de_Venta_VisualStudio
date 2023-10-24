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
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.Anchor = AnchorStyles.None;
            labelNombre.AutoSize = true;
            labelNombre.BackColor = Color.Transparent;
            labelNombre.Font = new Font("Leelawadee", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(31, 193);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(53, 14);
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
            labelPrecio.Font = new Font("Leelawadee", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrecio.Location = new Point(31, 223);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(43, 14);
            labelPrecio.TabIndex = 2;
            labelPrecio.Text = "Precio";
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Malgun Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(31, 250);
            button1.Name = "button1";
            button1.Size = new Size(124, 22);
            button1.TabIndex = 3;
            button1.Text = "Agregar al carrito";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.None;
            numericUpDown1.Location = new Point(161, 250);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(59, 23);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            numericUpDown1.Click += numericUpDown1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 250);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 13;
            label1.Text = "SIN STOCK";
            label1.Visible = false;
            // 
            // ProductoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(labelPrecio);
            Controls.Add(pictureBox1);
            Controls.Add(labelNombre);
            DoubleBuffered = true;
            Name = "ProductoControl";
            Size = new Size(238, 290);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombre;
        private PictureBox pictureBox1;
        private Label labelPrecio;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label1;
    }
}
