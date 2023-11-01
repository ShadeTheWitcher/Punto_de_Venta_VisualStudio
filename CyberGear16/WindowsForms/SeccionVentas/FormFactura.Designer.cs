namespace CyberGear16.WindowsForms.SeccionVentas
{
    partial class FormFactura
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
            panel1 = new Panel();
            label13 = new Label();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            lbDireccion = new Label();
            lbNomyApellido = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            lbFecha = new Label();
            lbIdVenta = new Label();
            label1 = new Label();
            button1 = new Button();
            panelPDF = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panelPDF.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 640);
            panel1.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(537, 522);
            label13.Name = "label13";
            label13.Size = new Size(31, 15);
            label13.TabIndex = 10;
            label13.Text = "0.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(471, 514);
            label12.Name = "label12";
            label12.Size = new Size(60, 25);
            label12.TabIndex = 9;
            label12.Text = "Total:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column4 });
            dataGridView1.Location = new Point(29, 243);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(649, 268);
            dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "Descripcion";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Cantidad";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "SubTotal";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 542);
            panel3.Name = "panel3";
            panel3.Size = new Size(705, 98);
            panel3.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(577, 13);
            label11.Name = "label11";
            label11.Size = new Size(114, 27);
            label11.TabIndex = 1;
            label11.Text = "CyberGear";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 13);
            label10.Name = "label10";
            label10.Size = new Size(131, 15);
            label10.TabIndex = 0;
            label10.Text = "¡Gracias por su compra!";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(409, 61);
            label9.Name = "label9";
            label9.Size = new Size(146, 14);
            label9.TabIndex = 6;
            label9.Text = "cybergear.21@gmail.com";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(409, 37);
            label8.Name = "label8";
            label8.Size = new Size(65, 14);
            label8.TabIndex = 5;
            label8.Text = "CyberGear";
            // 
            // lbDireccion
            // 
            lbDireccion.AutoSize = true;
            lbDireccion.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbDireccion.Location = new Point(23, 61);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(60, 14);
            lbDireccion.TabIndex = 4;
            lbDireccion.Text = "Direccion";
            // 
            // lbNomyApellido
            // 
            lbNomyApellido.AutoSize = true;
            lbNomyApellido.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbNomyApellido.Location = new Point(23, 37);
            lbNomyApellido.Name = "lbNomyApellido";
            lbNomyApellido.Size = new Size(111, 14);
            lbNomyApellido.TabIndex = 3;
            lbNomyApellido.Text = "Nombre y Apellido";
            lbNomyApellido.Click += lbNomyApellido_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(409, 11);
            label5.Name = "label5";
            label5.Size = new Size(57, 18);
            label5.TabIndex = 2;
            label5.Text = "PAGA A:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 11);
            label4.Name = "label4";
            label4.Size = new Size(68, 18);
            label4.TabIndex = 1;
            label4.Text = "CLIENTE:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumPurple;
            panel2.Controls.Add(lbFecha);
            panel2.Controls.Add(lbIdVenta);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(705, 100);
            panel2.TabIndex = 0;
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbFecha.Location = new Point(586, 48);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(62, 25);
            lbFecha.TabIndex = 2;
            lbFecha.Text = "Fecha";
            // 
            // lbIdVenta
            // 
            lbIdVenta.AutoSize = true;
            lbIdVenta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbIdVenta.Location = new Point(586, 18);
            lbIdVenta.Name = "lbIdVenta";
            lbIdVenta.Size = new Size(105, 25);
            lbIdVenta.TabIndex = 1;
            lbIdVenta.Text = "#idFactura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 31);
            label1.Name = "label1";
            label1.Size = new Size(171, 42);
            label1.TabIndex = 0;
            label1.Text = "Factura";
            // 
            // button1
            // 
            button1.Location = new Point(302, 10);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 0;
            button1.Text = "Generar PDF";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // panelPDF
            // 
            panelPDF.Controls.Add(button1);
            panelPDF.Dock = DockStyle.Bottom;
            panelPDF.Location = new Point(0, 595);
            panelPDF.Name = "panelPDF";
            panelPDF.Size = new Size(705, 45);
            panelPDF.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(lbDireccion);
            panel4.Controls.Add(lbNomyApellido);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(29, 130);
            panel4.Name = "panel4";
            panel4.Size = new Size(649, 88);
            panel4.TabIndex = 11;
            // 
            // FormFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 640);
            Controls.Add(panelPDF);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Factura";
            Load += FormFactura_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelPDF.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private Label lbFecha;
        private Label lbIdVenta;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label lbDireccion;
        private Label lbNomyApellido;
        private Label label5;
        private Panel panel3;
        private Label label10;
        private Label label11;
        private DataGridView dataGridView1;
        private Label label13;
        private Label label12;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
        private Panel panelPDF;
        private Panel panel4;
    }
}