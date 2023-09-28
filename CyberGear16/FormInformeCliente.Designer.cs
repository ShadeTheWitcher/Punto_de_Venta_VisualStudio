namespace CyberGear16
{
    partial class FormInformeCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformeCliente));
            pictureBox1 = new PictureBox();
            LApellido = new Label();
            LDni = new Label();
            LMNombre = new Label();
            LMTelefono = new Label();
            LTelefono = new Label();
            LMEmail = new Label();
            LEmail = new Label();
            LMDni = new Label();
            LMApellido = new Label();
            LNombre = new Label();
            LCantProduct = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(297, 198);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 240);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(108, 92);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(54, 15);
            LApellido.TabIndex = 24;
            LApellido.Text = "Apellido:";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(297, 40);
            LDni.Name = "LDni";
            LDni.Size = new Size(30, 15);
            LDni.TabIndex = 23;
            LDni.Text = "DNI:";
            // 
            // LMNombre
            // 
            LMNombre.AutoSize = true;
            LMNombre.Location = new Point(172, 40);
            LMNombre.Name = "LMNombre";
            LMNombre.Size = new Size(51, 15);
            LMNombre.TabIndex = 22;
            LMNombre.Text = "Nombre";
            // 
            // LMTelefono
            // 
            LMTelefono.AutoSize = true;
            LMTelefono.Location = new Point(562, 40);
            LMTelefono.Name = "LMTelefono";
            LMTelefono.Size = new Size(52, 15);
            LMTelefono.TabIndex = 20;
            LMTelefono.Text = "Telefono";
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(478, 40);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(55, 15);
            LTelefono.TabIndex = 19;
            LTelefono.Text = "Telefono:";
            // 
            // LMEmail
            // 
            LMEmail.AutoSize = true;
            LMEmail.Location = new Point(381, 92);
            LMEmail.Name = "LMEmail";
            LMEmail.Size = new Size(36, 15);
            LMEmail.TabIndex = 18;
            LMEmail.Text = "Email";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Location = new Point(297, 92);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(39, 15);
            LEmail.TabIndex = 17;
            LEmail.Text = "Email:";
            // 
            // LMDni
            // 
            LMDni.AutoSize = true;
            LMDni.Location = new Point(381, 40);
            LMDni.Name = "LMDni";
            LMDni.Size = new Size(27, 15);
            LMDni.TabIndex = 16;
            LMDni.Text = "DNI";
            // 
            // LMApellido
            // 
            LMApellido.AutoSize = true;
            LMApellido.Location = new Point(178, 92);
            LMApellido.Name = "LMApellido";
            LMApellido.Size = new Size(51, 15);
            LMApellido.TabIndex = 15;
            LMApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(108, 40);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(54, 15);
            LNombre.TabIndex = 14;
            LNombre.Text = "Nombre:";
            // 
            // LCantProduct
            // 
            LCantProduct.AutoSize = true;
            LCantProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LCantProduct.Location = new Point(220, 170);
            LCantProduct.Name = "LCantProduct";
            LCantProduct.Size = new Size(446, 25);
            LCantProduct.TabIndex = 27;
            LCantProduct.Text = "Cantidad de productos comprados por el cliente:";
            // 
            // FormInformeCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LCantProduct);
            Controls.Add(pictureBox1);
            Controls.Add(LApellido);
            Controls.Add(LDni);
            Controls.Add(LMNombre);
            Controls.Add(LMTelefono);
            Controls.Add(LTelefono);
            Controls.Add(LMEmail);
            Controls.Add(LEmail);
            Controls.Add(LMDni);
            Controls.Add(LMApellido);
            Controls.Add(LNombre);
            Name = "FormInformeCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informe de Cliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LApellido;
        private Label LDni;
        private Label LMNombre;
        private Label LMTelefono;
        private Label LTelefono;
        private Label LMEmail;
        private Label LEmail;
        private Label LMDni;
        private Label LMApellido;
        private Label LNombre;
        private Label LCantProduct;
    }
}