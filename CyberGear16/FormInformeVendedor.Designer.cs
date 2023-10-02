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
            LFecha = new Label();
            DTPFecha = new DateTimePicker();
            panel1 = new Panel();
            LCliente = new Label();
            label1 = new Label();
            label2 = new Label();
            LMNombre = new Label();
            LMTelefono = new Label();
            label5 = new Label();
            LMEmail = new Label();
            label7 = new Label();
            LMDni = new Label();
            LMApellido = new Label();
            LNombre = new Label();
            panel2 = new Panel();
            LCantVentas = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LFecha.ForeColor = Color.White;
            LFecha.Location = new Point(238, 55);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(142, 21);
            LFecha.TabIndex = 7;
            LFecha.Text = "Fecha de Ingreso:";
            LFecha.Click += LFecha_Click;
            // 
            // DTPFecha
            // 
            DTPFecha.Enabled = false;
            DTPFecha.Format = DateTimePickerFormat.Short;
            DTPFecha.Location = new Point(386, 56);
            DTPFecha.Name = "DTPFecha";
            DTPFecha.Size = new Size(98, 23);
            DTPFecha.TabIndex = 12;
            DTPFecha.ValueChanged += DTPFecha_ValueChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(LCliente);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(DTPFecha);
            panel1.Controls.Add(LMNombre);
            panel1.Controls.Add(LMTelefono);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(LMEmail);
            panel1.Controls.Add(LFecha);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(LMDni);
            panel1.Controls.Add(LMApellido);
            panel1.Controls.Add(LNombre);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 158);
            panel1.TabIndex = 29;
            panel1.Paint += panel1_Paint;
            // 
            // LCliente
            // 
            LCliente.AutoSize = true;
            LCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LCliente.ForeColor = Color.White;
            LCliente.Location = new Point(22, 12);
            LCliente.Name = "LCliente";
            LCliente.Size = new Size(106, 25);
            LCliente.TabIndex = 29;
            LCliente.Text = "Vendedor:";
            LCliente.Click += LCliente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(53, 108);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 24;
            label1.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(277, 108);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 23;
            label2.Text = "DNI:";
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
            // 
            // LMTelefono
            // 
            LMTelefono.AutoSize = true;
            LMTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LMTelefono.ForeColor = Color.White;
            LMTelefono.Location = new Point(606, 56);
            LMTelefono.Name = "LMTelefono";
            LMTelefono.Size = new Size(70, 20);
            LMTelefono.TabIndex = 20;
            LMTelefono.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(512, 56);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 19;
            label5.Text = "Telefono:";
            // 
            // LMEmail
            // 
            LMEmail.AutoSize = true;
            LMEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LMEmail.ForeColor = Color.White;
            LMEmail.Location = new Point(503, 109);
            LMEmail.Name = "LMEmail";
            LMEmail.Size = new Size(47, 20);
            LMEmail.TabIndex = 18;
            LMEmail.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(446, 108);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 17;
            label7.Text = "Email:";
            // 
            // LMDni
            // 
            LMDni.AutoSize = true;
            LMDni.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LMDni.ForeColor = Color.White;
            LMDni.Location = new Point(334, 108);
            LMDni.Name = "LMDni";
            LMDni.Size = new Size(37, 20);
            LMDni.TabIndex = 16;
            LMDni.Text = "DNI";
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
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(26, 32, 40);
            panel2.Controls.Add(LCantVentas);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 187);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 296);
            panel2.TabIndex = 30;
            // 
            // LCantVentas
            // 
            LCantVentas.AutoSize = true;
            LCantVentas.BackColor = Color.FromArgb(26, 32, 40);
            LCantVentas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LCantVentas.ForeColor = Color.White;
            LCantVentas.Location = new Point(169, 16);
            LCantVentas.Name = "LCantVentas";
            LCantVentas.Size = new Size(427, 25);
            LCantVentas.TabIndex = 28;
            LCantVentas.Text = "Cantidad de ventas realizadas por el vendedor:";
            LCantVentas.Click += LCantVentas_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(243, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 240);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormInformeVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormInformeVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informe de Vendedor";
            Load += FormInformeVendedor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label LFecha;
        private DateTimePicker DTPFecha;
        private Panel panel1;
        private Label LCliente;
        private Label label1;
        private Label label2;
        private Label LMNombre;
        private Label LMTelefono;
        private Label label5;
        private Label LMEmail;
        private Label label7;
        private Label LMDni;
        private Label LMApellido;
        private Label LNombre;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label LCantVentas;
    }
}