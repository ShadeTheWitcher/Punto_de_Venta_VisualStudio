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
            panel1 = new Panel();
            LCliente = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(216, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 240);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LApellido.ForeColor = Color.White;
            LApellido.Location = new Point(53, 108);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(71, 20);
            LApellido.TabIndex = 24;
            LApellido.Text = "Apellido:";
            LApellido.Click += LApellido_Click;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LDni.ForeColor = Color.White;
            LDni.Location = new Point(270, 56);
            LDni.Name = "LDni";
            LDni.Size = new Size(41, 20);
            LDni.TabIndex = 23;
            LDni.Text = "DNI:";
            LDni.Click += LDni_Click;
            // 
            // LMNombre
            // 
            LMNombre.AutoSize = true;
            LMNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LMNombre.ForeColor = Color.White;
            LMNombre.Location = new Point(123, 56);
            LMNombre.Name = "LMNombre";
            LMNombre.Size = new Size(67, 20);
            LMNombre.TabIndex = 22;
            LMNombre.Text = "Nombre";
            LMNombre.Click += LMNombre_Click;
            // 
            // LMTelefono
            // 
            LMTelefono.AutoSize = true;
            LMTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LMTelefono.ForeColor = Color.White;
            LMTelefono.Location = new Point(580, 56);
            LMTelefono.Name = "LMTelefono";
            LMTelefono.Size = new Size(70, 20);
            LMTelefono.TabIndex = 20;
            LMTelefono.Text = "Telefono";
            LMTelefono.Click += LMTelefono_Click;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LTelefono.ForeColor = Color.White;
            LTelefono.Location = new Point(496, 56);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(74, 20);
            LTelefono.TabIndex = 19;
            LTelefono.Text = "Telefono:";
            LTelefono.Click += LTelefono_Click;
            // 
            // LMEmail
            // 
            LMEmail.AutoSize = true;
            LMEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LMEmail.ForeColor = Color.White;
            LMEmail.Location = new Point(354, 108);
            LMEmail.Name = "LMEmail";
            LMEmail.Size = new Size(47, 20);
            LMEmail.TabIndex = 18;
            LMEmail.Text = "Email";
            LMEmail.Click += LMEmail_Click;
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LEmail.ForeColor = Color.White;
            LEmail.Location = new Point(270, 108);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(51, 20);
            LEmail.TabIndex = 17;
            LEmail.Text = "Email:";
            LEmail.Click += LEmail_Click;
            // 
            // LMDni
            // 
            LMDni.AutoSize = true;
            LMDni.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LMDni.ForeColor = Color.White;
            LMDni.Location = new Point(354, 56);
            LMDni.Name = "LMDni";
            LMDni.Size = new Size(37, 20);
            LMDni.TabIndex = 16;
            LMDni.Text = "DNI";
            LMDni.Click += LMDni_Click;
            // 
            // LMApellido
            // 
            LMApellido.AutoSize = true;
            LMApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LMApellido.ForeColor = Color.White;
            LMApellido.Location = new Point(123, 108);
            LMApellido.Name = "LMApellido";
            LMApellido.Size = new Size(67, 20);
            LMApellido.TabIndex = 15;
            LMApellido.Text = "Apellido";
            LMApellido.Click += LMApellido_Click;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LNombre.ForeColor = Color.White;
            LNombre.Location = new Point(53, 56);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(71, 20);
            LNombre.TabIndex = 14;
            LNombre.Text = "Nombre:";
            LNombre.Click += LNombre_Click;
            // 
            // LCantProduct
            // 
            LCantProduct.AutoSize = true;
            LCantProduct.BackColor = Color.FromArgb(26, 32, 40);
            LCantProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LCantProduct.ForeColor = Color.White;
            LCantProduct.Location = new Point(191, 194);
            LCantProduct.Name = "LCantProduct";
            LCantProduct.Size = new Size(446, 25);
            LCantProduct.TabIndex = 27;
            LCantProduct.Text = "Cantidad de productos comprados por el cliente:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(LCliente);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(LDni);
            panel1.Controls.Add(LMNombre);
            panel1.Controls.Add(LMTelefono);
            panel1.Controls.Add(LTelefono);
            panel1.Controls.Add(LMEmail);
            panel1.Controls.Add(LEmail);
            panel1.Controls.Add(LMDni);
            panel1.Controls.Add(LMApellido);
            panel1.Controls.Add(LNombre);
            panel1.Location = new Point(30, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 158);
            panel1.TabIndex = 28;
            panel1.Paint += panel1_Paint;
            // 
            // LCliente
            // 
            LCliente.AutoSize = true;
            LCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LCliente.ForeColor = Color.White;
            LCliente.Location = new Point(22, 12);
            LCliente.Name = "LCliente";
            LCliente.Size = new Size(78, 25);
            LCliente.TabIndex = 29;
            LCliente.Text = "Cliente:";
            LCliente.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(26, 32, 40);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(30, 187);
            panel2.Name = "panel2";
            panel2.Size = new Size(744, 296);
            panel2.TabIndex = 29;
            // 
            // FormInformeCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 495);
            Controls.Add(panel1);
            Controls.Add(LCantProduct);
            Controls.Add(panel2);
            Name = "FormInformeCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informe de Cliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
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
        private Panel panel1;
        private Label LCliente;
        private Panel panel2;
    }
}