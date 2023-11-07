namespace CyberGear16
{
    partial class FormSeccionVentas
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label19 = new Label();
            textBox10 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            label7 = new Label();
            button6 = new Button();
            label17 = new Label();
            label12 = new Label();
            label11 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            panel3 = new Panel();
            button4 = new Button();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewImageColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewButtonColumn();
            Column9 = new DataGridViewButtonColumn();
            textBox9 = new TextBox();
            label16 = new Label();
            toolTip1 = new ToolTip(components);
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            label5 = new Label();
            panel6 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel7 = new Panel();
            comboBox2 = new ComboBox();
            label13 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.SteelBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label19);
            panel1.Controls.Add(textBox10);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(104, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 143);
            panel1.TabIndex = 0;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.White;
            label19.Location = new Point(237, 60);
            label19.Name = "label19";
            label19.Size = new Size(27, 15);
            label19.TabIndex = 10;
            label19.Text = "DNI";
            // 
            // textBox10
            // 
            textBox10.Enabled = false;
            textBox10.Location = new Point(228, 78);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(94, 23);
            textBox10.TabIndex = 9;
            toolTip1.SetToolTip(textBox10, "Ingrese el DNI del cliente registrado y presione buscar para asinarlo\r\n");
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(100, 2);
            label10.Name = "label10";
            label10.Size = new Size(17, 15);
            label10.TabIndex = 4;
            label10.Text = "Id";
            label10.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(25, 60);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 3;
            label9.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Vendedor:";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(25, 78);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(99, 18);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(60, 23);
            textBox1.TabIndex = 0;
            textBox1.Visible = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.SteelBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox4);
            panel2.Location = new Point(505, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 140);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(7, 14);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 11;
            label7.Text = "Cliente:";
            // 
            // button6
            // 
            button6.Location = new Point(140, 88);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 11;
            button6.Text = "Limpiar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.DarkRed;
            label17.Location = new Point(262, 88);
            label17.Name = "label17";
            label17.Size = new Size(150, 19);
            label17.TabIndex = 10;
            label17.Text = "Cliente No asignado";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(262, 39);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 9;
            label12.Text = "Nombre";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(49, 40);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 8;
            label11.Text = "DNI";
            // 
            // button3
            // 
            button3.Location = new Point(140, 58);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Buscar";
            toolTip1.SetToolTip(button3, "Ingrese el dni para asignar usuario");
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(262, 57);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(142, 23);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(40, 58);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(94, 23);
            textBox4.TabIndex = 2;
            toolTip1.SetToolTip(textBox4, "Ingrese el DNI del cliente registrado y presione buscar para asinarlo\r\n");
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.SteelBlue;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(104, 195);
            panel3.Name = "panel3";
            panel3.Size = new Size(371, 118);
            panel3.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 0);
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Image = Properties.Resources.venta;
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(134, 24);
            button4.Name = "button4";
            button4.Size = new Size(108, 64);
            button4.TabIndex = 9;
            button4.Text = "Abrir Catalogo";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 9);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 5;
            label6.Text = "Producto:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(284, 617);
            button1.Name = "button1";
            button1.Size = new Size(161, 55);
            button1.TabIndex = 5;
            button1.Text = "Guardar venta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Transparent;
            button2.Location = new Point(551, 617);
            button2.Name = "button2";
            button2.Size = new Size(153, 55);
            button2.TabIndex = 6;
            button2.Text = "Vaciar Carrito";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column6, Column1, Column2, Column3, Column4, Column7, Column5, Column8, Column9 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(104, 376);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(845, 214);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            // 
            // Column6
            // 
            Column6.HeaderText = "id_producto";
            Column6.Name = "Column6";
            Column6.Visible = false;
            // 
            // Column1
            // 
            Column1.FillWeight = 119.132622F;
            Column1.HeaderText = "Nombre Producto";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 119.132622F;
            Column2.HeaderText = "Precio";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 119.132622F;
            Column3.HeaderText = "Cantidad";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.FillWeight = 119.132622F;
            Column4.HeaderText = "Categoria";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.FillWeight = 119.132622F;
            Column7.HeaderText = "Imagen";
            Column7.Name = "Column7";
            Column7.Resizable = DataGridViewTriState.True;
            Column7.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            Column5.FillWeight = 119.132622F;
            Column5.HeaderText = "SubTotal";
            Column5.Name = "Column5";
            // 
            // Column8
            // 
            Column8.FillWeight = 44.5951F;
            Column8.HeaderText = "";
            Column8.Name = "Column8";
            Column8.Resizable = DataGridViewTriState.True;
            Column8.SortMode = DataGridViewColumnSortMode.Automatic;
            Column8.Text = "+";
            Column8.UseColumnTextForButtonValue = true;
            // 
            // Column9
            // 
            Column9.FillWeight = 40.60913F;
            Column9.HeaderText = "";
            Column9.Name = "Column9";
            Column9.Resizable = DataGridViewTriState.True;
            Column9.SortMode = DataGridViewColumnSortMode.Automatic;
            Column9.Text = "-";
            Column9.UseColumnTextForButtonValue = true;
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.None;
            textBox9.Enabled = false;
            textBox9.Location = new Point(863, 630);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(86, 23);
            textBox9.TabIndex = 9;
            textBox9.TabStop = false;
            textBox9.Text = "0.00";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(26, 32, 40);
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(766, 633);
            label16.Name = "label16";
            label16.Size = new Size(81, 17);
            label16.TabIndex = 10;
            label16.Text = "Precio Total";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(26, 32, 40);
            label5.Font = new Font("Sylfaen", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(130, 330);
            label5.Name = "label5";
            label5.Size = new Size(206, 27);
            label5.TabIndex = 11;
            label5.Text = "Carrito de compras:";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel6.BackColor = Color.FromArgb(26, 32, 40);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(panel5);
            panel6.Controls.Add(textBox9);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(dataGridView1);
            panel6.Controls.Add(panel1);
            panel6.Controls.Add(panel2);
            panel6.Controls.Add(panel3);
            panel6.Location = new Point(12, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1055, 705);
            panel6.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.SteelBlue;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(dateTimePicker1);
            panel5.Location = new Point(730, 187);
            panel5.Name = "panel5";
            panel5.Size = new Size(207, 120);
            panel5.TabIndex = 16;
            panel5.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 10);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 5;
            label4.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(51, 52);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(98, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.BackColor = Color.SteelBlue;
            panel7.Controls.Add(comboBox2);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(504, 187);
            panel7.Name = "panel7";
            panel7.Size = new Size(206, 118);
            panel7.TabIndex = 15;
            panel7.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(60, 55);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(16, 10);
            label13.Name = "label13";
            label13.Size = new Size(65, 20);
            label13.TabIndex = 6;
            label13.Text = "Factura:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 58);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 5;
            label1.Text = "Tipo:";
            // 
            // FormSeccionVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 704);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSeccionVentas";
            Text = "Ventas";
            Load += FormSeccionVentas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label12;
        private Label label11;
        private Button button4;
        private TextBox textBox9;
        private Label label16;
        private Label label17;
        private Button button6;
        private ToolTip toolTip1;
        private Label label19;
        private TextBox textBox10;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Column7;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn Column8;
        private DataGridViewButtonColumn Column9;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label label5;
        private Label label7;
        private Panel panel6;
        private Panel panel7;
        private Panel panel5;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private Label label13;
        private Label label1;
    }
}