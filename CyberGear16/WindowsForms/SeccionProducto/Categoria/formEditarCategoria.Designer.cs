namespace CyberGear16.WindowsForms.SeccionProducto.Categoria
{
    partial class formEditarCategoria
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
            panel1 = new Panel();
            label2 = new Label();
            tbDescrip = new TextBox();
            tbNombre = new TextBox();
            button3 = new Button();
            button2 = new Button();
            btnAplicar = new Button();
            label1 = new Label();
            label8 = new Label();
            LStockMin = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.JoystickMorado;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbDescrip);
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnAplicar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(LStockMin);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 335);
            panel1.TabIndex = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 21);
            label2.Name = "label2";
            label2.Size = new Size(261, 25);
            label2.TabIndex = 70;
            label2.Text = "Modificacion de Categoria";
            // 
            // tbDescrip
            // 
            tbDescrip.Location = new Point(148, 126);
            tbDescrip.Multiline = true;
            tbDescrip.Name = "tbDescrip";
            tbDescrip.Size = new Size(174, 96);
            tbDescrip.TabIndex = 69;
            tbDescrip.TextChanged += tbDescrip_TextChanged;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(148, 69);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(174, 23);
            tbNombre.TabIndex = 68;
            tbNombre.TextChanged += tbNombre_TextChanged;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.flecha_verde_retroceder;
            button3.Location = new Point(12, 257);
            button3.Name = "button3";
            button3.Size = new Size(75, 62);
            button3.TabIndex = 67;
            button3.Text = "Volver";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.icon_dar_alta;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(159, 274);
            button2.Name = "button2";
            button2.Size = new Size(140, 45);
            button2.TabIndex = 66;
            button2.Text = "DAR DE ALTA";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(148, 236);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(174, 23);
            btnAplicar.TabIndex = 65;
            btnAplicar.Text = "Aplicar Cambios";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(49, 69);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 64;
            label1.Text = "Nombre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(49, 120);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 63;
            label8.Text = "Descripción:";
            // 
            // LStockMin
            // 
            LStockMin.AutoSize = true;
            LStockMin.BackColor = Color.Transparent;
            LStockMin.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LStockMin.ForeColor = Color.Transparent;
            LStockMin.Location = new Point(49, 89);
            LStockMin.Name = "LStockMin";
            LStockMin.Size = new Size(0, 20);
            LStockMin.TabIndex = 62;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icon_dar_baja;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(159, 274);
            button1.Name = "button1";
            button1.Size = new Size(140, 45);
            button1.TabIndex = 71;
            button1.Text = "DAR DE BAJA";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // formEditarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 335);
            Controls.Add(panel1);
            Name = "formEditarCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Categoria";
            Load += formEditarCategoria_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private Label LStockMin;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button btnAplicar;
        private TextBox tbDescrip;
        private TextBox tbNombre;
        private Label label2;
        private Button button1;
    }
}