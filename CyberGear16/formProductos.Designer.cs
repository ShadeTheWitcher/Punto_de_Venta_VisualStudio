﻿namespace CyberGear16
{
    partial class formProductos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProductos));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            BCancelar = new Button();
            textBox5 = new TextBox();
            label7 = new Label();
            comboBoxCategorias = new ComboBox();
            button1 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtFoto = new TextBox();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            BActivos = new Button();
            BInactivo = new Button();
            BBorrar = new Button();
            BBuscar = new Button();
            TBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 0;
            label1.Text = "Productos:";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.producto_nuevo_png_1;
            pictureBox1.Location = new Point(723, 37);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(BCancelar);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(comboBoxCategorias);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(89, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(630, 309);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // BCancelar
            // 
            BCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BCancelar.ForeColor = SystemColors.ActiveCaptionText;
            BCancelar.Image = Properties.Resources.borrar;
            BCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BCancelar.Location = new Point(449, 226);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(137, 70);
            BCancelar.TabIndex = 27;
            BCancelar.Text = "Cancelar";
            BCancelar.TextAlign = ContentAlignment.MiddleRight;
            BCancelar.UseVisualStyleBackColor = true;
            BCancelar.Click += BCancelar_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(152, 169);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(75, 23);
            textBox5.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(23, 172);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 13;
            label7.Text = "Stock Mínimo:";
            // 
            // comboBoxCategorias
            // 
            comboBoxCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategorias.FormattingEnabled = true;
            comboBoxCategorias.Location = new Point(152, 208);
            comboBoxCategorias.Name = "comboBoxCategorias";
            comboBoxCategorias.Size = new Size(167, 23);
            comboBoxCategorias.TabIndex = 11;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(96, 257);
            button1.Name = "button1";
            button1.Size = new Size(131, 30);
            button1.TabIndex = 9;
            button1.Text = "Agregar Producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(23, 208);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 8;
            label6.Text = "Categoria";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(428, 53);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 64);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(23, 132);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 3;
            label5.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(23, 93);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 2;
            label4.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(354, 53);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 1;
            label3.Text = "Descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(23, 56);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre Del Producto:";
            // 
            // txtFoto
            // 
            txtFoto.Location = new Point(777, 209);
            txtFoto.Name = "txtFoto";
            txtFoto.ReadOnly = true;
            txtFoto.Size = new Size(177, 23);
            txtFoto.TabIndex = 12;
            txtFoto.Visible = false;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(798, 238);
            button2.Name = "button2";
            button2.Size = new Size(131, 30);
            button2.TabIndex = 10;
            button2.Text = "subir foto";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.None;
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(77, 411);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(865, 244);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BActivos
            // 
            BActivos.ForeColor = SystemColors.ActiveCaptionText;
            BActivos.Location = new Point(77, 368);
            BActivos.Name = "BActivos";
            BActivos.Size = new Size(113, 28);
            BActivos.TabIndex = 4;
            BActivos.Text = "Activos";
            BActivos.UseVisualStyleBackColor = true;
            BActivos.Click += BActivos_Click;
            // 
            // BInactivo
            // 
            BInactivo.ForeColor = SystemColors.ActiveCaptionText;
            BInactivo.Location = new Point(203, 368);
            BInactivo.Name = "BInactivo";
            BInactivo.Size = new Size(113, 28);
            BInactivo.TabIndex = 5;
            BInactivo.Text = "Inactivos";
            BInactivo.UseVisualStyleBackColor = true;
            BInactivo.Click += BInactivo_Click;
            // 
            // BBorrar
            // 
            BBorrar.Image = (Image)resources.GetObject("BBorrar.Image");
            BBorrar.Location = new Point(901, 363);
            BBorrar.Name = "BBorrar";
            BBorrar.Size = new Size(38, 37);
            BBorrar.TabIndex = 9;
            BBorrar.UseVisualStyleBackColor = true;
            BBorrar.Click += BBorrar_Click;
            // 
            // BBuscar
            // 
            BBuscar.Image = Properties.Resources.lupa;
            BBuscar.Location = new Point(857, 363);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(38, 37);
            BBuscar.TabIndex = 8;
            BBuscar.UseVisualStyleBackColor = true;
            BBuscar.Click += BBuscar_Click;
            // 
            // TBuscar
            // 
            TBuscar.Location = new Point(538, 372);
            TBuscar.Name = "TBuscar";
            TBuscar.Size = new Size(313, 23);
            TBuscar.TabIndex = 7;
            TBuscar.Text = "Buscar";
            TBuscar.Click += TBuscar_Click;
            TBuscar.TextChanged += TBuscar_TextChanged;
            TBuscar.KeyPress += TBuscar_KeyPress;
            // 
            // formProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 687);
            Controls.Add(BBorrar);
            Controls.Add(BBuscar);
            Controls.Add(TBuscar);
            Controls.Add(txtFoto);
            Controls.Add(BInactivo);
            Controls.Add(BActivos);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "formProductos";
            Text = "Productos";
            Load += formProductos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button1;
        private ComboBox comboBoxCategorias;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private TextBox txtFoto;
        private DataGridView dataGridView1;
        private TextBox textBox5;
        private Label label7;
        private Button BActivos;
        private Button BInactivo;
        private Button BBorrar;
        private Button BBuscar;
        private TextBox TBuscar;
        private Button BCancelar;
    }
}