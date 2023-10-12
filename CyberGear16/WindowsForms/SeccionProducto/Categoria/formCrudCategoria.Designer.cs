namespace CyberGear16.WindowsForms.SeccionProducto.Categoria
{
    partial class formCrudCategoria
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
            panel1 = new Panel();
            button3 = new Button();
            BCancelar = new Button();
            txtFoto = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(BCancelar);
            panel1.Controls.Add(txtFoto);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(206, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(630, 217);
            panel1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(489, 315);
            button3.Name = "button3";
            button3.Size = new Size(111, 30);
            button3.TabIndex = 29;
            button3.Text = "Nueva Categoria";
            button3.UseVisualStyleBackColor = true;
            // 
            // BCancelar
            // 
            BCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BCancelar.ForeColor = SystemColors.ActiveCaptionText;
            BCancelar.Image = Properties.Resources.borrar;
            BCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BCancelar.Location = new Point(438, 127);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(137, 70);
            BCancelar.TabIndex = 27;
            BCancelar.Text = "Cancelar";
            BCancelar.TextAlign = ContentAlignment.MiddleRight;
            BCancelar.UseVisualStyleBackColor = true;
            BCancelar.Click += BCancelar_Click;
            // 
            // txtFoto
            // 
            txtFoto.Anchor = AnchorStyles.None;
            txtFoto.Location = new Point(640, 203);
            txtFoto.Name = "txtFoto";
            txtFoto.ReadOnly = true;
            txtFoto.Size = new Size(177, 23);
            txtFoto.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(23, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 30);
            label1.TabIndex = 0;
            label1.Text = "Categorias";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(112, 148);
            button1.Name = "button1";
            button1.Size = new Size(131, 30);
            button1.TabIndex = 9;
            button1.Text = "Agregar Categoria";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(428, 53);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 64);
            textBox4.TabIndex = 7;
            textBox4.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 4;
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
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(23, 56);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre De Categoria";
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.None;
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.None;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column7, Column3, Column6 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(120, 384);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(865, 244);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Image = Properties.Resources.flecha_verde_retroceder;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(2, 1);
            button2.Name = "button2";
            button2.Size = new Size(96, 72);
            button2.TabIndex = 5;
            button2.Text = "Volver";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Column1
            // 
            Column1.FillWeight = 60.9137039F;
            Column1.HeaderText = "id";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 107.817253F;
            Column2.HeaderText = "Nombre_categoria";
            Column2.Name = "Column2";
            // 
            // Column7
            // 
            Column7.HeaderText = "Descripcion";
            Column7.Name = "Column7";
            // 
            // Column3
            // 
            Column3.HeaderText = "Activo";
            Column3.Name = "Column3";
            // 
            // Column6
            // 
            Column6.FillWeight = 107.817253F;
            Column6.HeaderText = "Acciones";
            Column6.Name = "Column6";
            Column6.Resizable = DataGridViewTriState.True;
            Column6.SortMode = DataGridViewColumnSortMode.Automatic;
            Column6.Text = "Edit-Baja-Alta";
            Column6.UseColumnTextForButtonValue = true;
            // 
            // formCrudCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 783);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formCrudCategoria";
            Text = "formCrudCategoria";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button BCancelar;
        private TextBox txtFoto;
        private Label label1;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn Column6;
    }
}