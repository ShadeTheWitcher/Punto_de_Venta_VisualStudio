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
            button6 = new Button();
            label17 = new Label();
            label12 = new Label();
            label11 = new Label();
            label3 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            panel3 = new Panel();
            button4 = new Button();
            label6 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
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
            panel5 = new Panel();
            comboBox2 = new ComboBox();
            label13 = new Label();
            textBox9 = new TextBox();
            label16 = new Label();
            toolTip1 = new ToolTip(components);
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.LightSlateGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label19);
            panel1.Controls.Add(textBox10);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(27, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 105);
            panel1.TabIndex = 0;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(224, 42);
            label19.Name = "label19";
            label19.Size = new Size(27, 15);
            label19.TabIndex = 10;
            label19.Text = "DNI";
            // 
            // textBox10
            // 
            textBox10.Enabled = false;
            textBox10.Location = new Point(215, 60);
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
            label9.Location = new Point(19, 42);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 3;
            label9.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 10);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Vendedor:";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(19, 60);
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
            panel2.BackColor = Color.LightSlateGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox4);
            panel2.Location = new Point(413, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 105);
            panel2.TabIndex = 1;
            // 
            // button6
            // 
            button6.Location = new Point(115, 77);
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
            label17.Location = new Point(237, 77);
            label17.Name = "label17";
            label17.Size = new Size(150, 19);
            label17.TabIndex = 10;
            label17.Text = "Cliente No asignado";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(237, 21);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 9;
            label12.Text = "Nombre";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 29);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 8;
            label11.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 10);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 7;
            label3.Text = "Cliente";
            // 
            // button3
            // 
            button3.Location = new Point(115, 47);
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
            textBox3.Location = new Point(237, 46);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(142, 23);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(15, 47);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(94, 23);
            textBox4.TabIndex = 2;
            toolTip1.SetToolTip(textBox4, "Ingrese el DNI del cliente registrado y presione buscar para asinarlo\r\n");
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.LightSlateGray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(27, 195);
            panel3.Name = "panel3";
            panel3.Size = new Size(345, 98);
            panel3.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 0);
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Image = Properties.Resources.venta;
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(119, 11);
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
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 9);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 5;
            label6.Text = "Producto";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.LightSlateGray;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Location = new Point(628, 195);
            panel4.Name = "panel4";
            panel4.Size = new Size(192, 98);
            panel4.TabIndex = 3;
            panel4.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 9);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(27, 50);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(98, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 41);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Tipo:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(214, 597);
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
            button2.Location = new Point(431, 597);
            button2.Name = "button2";
            button2.Size = new Size(153, 55);
            button2.TabIndex = 6;
            button2.Text = "Vaciar Carrito";
            button2.UseVisualStyleBackColor = true;
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
            dataGridView1.Location = new Point(27, 362);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(790, 214);
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
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.LightSlateGray;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(comboBox2);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(413, 195);
            panel5.Name = "panel5";
            panel5.Size = new Size(191, 98);
            panel5.TabIndex = 8;
            panel5.Visible = false;
            panel5.Paint += panel5_Paint;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(53, 38);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(14, 7);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 3;
            label13.Text = "Factura";
            label13.Click += label13_Click;
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.None;
            textBox9.Enabled = false;
            textBox9.Location = new Point(725, 614);
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
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(628, 617);
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
            label5.Font = new Font("Sylfaen", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 319);
            label5.Name = "label5";
            label5.Size = new Size(206, 27);
            label5.TabIndex = 11;
            label5.Text = "Carrito de compras:";
            // 
            // FormSeccionVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 664);
            Controls.Add(label5);
            Controls.Add(label16);
            Controls.Add(textBox9);
            Controls.Add(panel5);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label12;
        private Label label11;
        private Panel panel5;
        private Label label13;
        private Button button4;
        private ComboBox comboBox2;
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
    }
}