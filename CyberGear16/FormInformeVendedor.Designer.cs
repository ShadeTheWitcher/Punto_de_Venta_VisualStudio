namespace CyberGear16
{
    partial class FormInformeVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformeVendedor));
            LNombre = new Label();
            LMApellido = new Label();
            LMDni = new Label();
            LEmail = new Label();
            LMEmail = new Label();
            LTelefono = new Label();
            LMTelefono = new Label();
            LFecha = new Label();
            LMNombre = new Label();
            LDni = new Label();
            LApellido = new Label();
            DTPFecha = new DateTimePicker();
            pictureBox1 = new PictureBox();
            LCantProduct = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(59, 53);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(54, 15);
            LNombre.TabIndex = 0;
            LNombre.Text = "Nombre:";
            // 
            // LMApellido
            // 
            LMApellido.AutoSize = true;
            LMApellido.Location = new Point(129, 105);
            LMApellido.Name = "LMApellido";
            LMApellido.Size = new Size(51, 15);
            LMApellido.TabIndex = 1;
            LMApellido.Text = "Apellido";
            // 
            // LMDni
            // 
            LMDni.AutoSize = true;
            LMDni.Location = new Point(332, 53);
            LMDni.Name = "LMDni";
            LMDni.Size = new Size(27, 15);
            LMDni.TabIndex = 2;
            LMDni.Text = "DNI";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Location = new Point(248, 105);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(39, 15);
            LEmail.TabIndex = 3;
            LEmail.Text = "Email:";
            // 
            // LMEmail
            // 
            LMEmail.AutoSize = true;
            LMEmail.Location = new Point(332, 105);
            LMEmail.Name = "LMEmail";
            LMEmail.Size = new Size(36, 15);
            LMEmail.TabIndex = 4;
            LMEmail.Text = "Email";
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(429, 53);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(55, 15);
            LTelefono.TabIndex = 5;
            LTelefono.Text = "Telefono:";
            // 
            // LMTelefono
            // 
            LMTelefono.AutoSize = true;
            LMTelefono.Location = new Point(513, 53);
            LMTelefono.Name = "LMTelefono";
            LMTelefono.Size = new Size(52, 15);
            LMTelefono.TabIndex = 6;
            LMTelefono.Text = "Telefono";
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.Location = new Point(429, 105);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(99, 15);
            LFecha.TabIndex = 7;
            LFecha.Text = "Fecha de Ingreso:";
            // 
            // LMNombre
            // 
            LMNombre.AutoSize = true;
            LMNombre.Location = new Point(123, 53);
            LMNombre.Name = "LMNombre";
            LMNombre.Size = new Size(51, 15);
            LMNombre.TabIndex = 9;
            LMNombre.Text = "Nombre";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(248, 53);
            LDni.Name = "LDni";
            LDni.Size = new Size(30, 15);
            LDni.TabIndex = 10;
            LDni.Text = "DNI:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(59, 105);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(54, 15);
            LApellido.TabIndex = 11;
            LApellido.Text = "Apellido:";
            // 
            // DTPFecha
            // 
            DTPFecha.Enabled = false;
            DTPFecha.Format = DateTimePickerFormat.Short;
            DTPFecha.Location = new Point(545, 105);
            DTPFecha.Name = "DTPFecha";
            DTPFecha.Size = new Size(98, 23);
            DTPFecha.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(269, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 240);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // LCantProduct
            // 
            LCantProduct.AutoSize = true;
            LCantProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LCantProduct.Location = new Point(204, 157);
            LCantProduct.Name = "LCantProduct";
            LCantProduct.Size = new Size(427, 25);
            LCantProduct.TabIndex = 28;
            LCantProduct.Text = "Cantidad de ventas realizadas por el vendedor:";
            // 
            // FormInformeVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LCantProduct);
            Controls.Add(pictureBox1);
            Controls.Add(DTPFecha);
            Controls.Add(LApellido);
            Controls.Add(LDni);
            Controls.Add(LMNombre);
            Controls.Add(LFecha);
            Controls.Add(LMTelefono);
            Controls.Add(LTelefono);
            Controls.Add(LMEmail);
            Controls.Add(LEmail);
            Controls.Add(LMDni);
            Controls.Add(LMApellido);
            Controls.Add(LNombre);
            Name = "FormInformeVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informe de Vendedor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNombre;
        private Label LMApellido;
        private Label LMDni;
        private Label LEmail;
        private Label LMEmail;
        private Label LTelefono;
        private Label LMTelefono;
        private Label LFecha;
        private Label LMNombre;
        private Label LDni;
        private Label LApellido;
        private DateTimePicker DTPFecha;
        private PictureBox pictureBox1;
        private Label LCantProduct;
    }
}