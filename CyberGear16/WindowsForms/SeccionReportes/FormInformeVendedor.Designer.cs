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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            LCantVentas = new Label();
            LTotalVentasCat = new Label();
            LValorVentasCat = new Label();
            CBCategorias = new ComboBox();
            CProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2 = new Panel();
            LValorVentasTot = new Label();
            LTotalVentasTot = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CProducts).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LFecha.ForeColor = Color.White;
            LFecha.Location = new Point(228, 55);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(175, 21);
            LFecha.TabIndex = 7;
            LFecha.Text = "Fecha de Nacimiento:";
            LFecha.Click += LFecha_Click;
            // 
            // DTPFecha
            // 
            DTPFecha.Enabled = false;
            DTPFecha.Format = DateTimePickerFormat.Short;
            DTPFecha.Location = new Point(399, 55);
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
            LMNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LMNombre.ForeColor = Color.White;
            LMNombre.Location = new Point(123, 56);
            LMNombre.Name = "LMNombre";
            LMNombre.Size = new Size(64, 20);
            LMNombre.TabIndex = 22;
            LMNombre.Text = "Nombre";
            // 
            // LMTelefono
            // 
            LMTelefono.AutoSize = true;
            LMTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LMTelefono.ForeColor = Color.White;
            LMTelefono.Location = new Point(644, 55);
            LMTelefono.Name = "LMTelefono";
            LMTelefono.Size = new Size(67, 20);
            LMTelefono.TabIndex = 20;
            LMTelefono.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(550, 55);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 19;
            label5.Text = "Telefono:";
            // 
            // LMEmail
            // 
            LMEmail.AutoSize = true;
            LMEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LMEmail.ForeColor = Color.White;
            LMEmail.Location = new Point(503, 109);
            LMEmail.Name = "LMEmail";
            LMEmail.Size = new Size(46, 20);
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
            LMDni.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LMDni.ForeColor = Color.White;
            LMDni.Location = new Point(334, 108);
            LMDni.Name = "LMDni";
            LMDni.Size = new Size(35, 20);
            LMDni.TabIndex = 16;
            LMDni.Text = "DNI";
            // 
            // LMApellido
            // 
            LMApellido.AutoSize = true;
            LMApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LMApellido.ForeColor = Color.White;
            LMApellido.Location = new Point(123, 108);
            LMApellido.Name = "LMApellido";
            LMApellido.Size = new Size(66, 20);
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
            // LTotalVentasCat
            // 
            LTotalVentasCat.AutoSize = true;
            LTotalVentasCat.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LTotalVentasCat.ForeColor = Color.White;
            LTotalVentasCat.Location = new Point(550, 161);
            LTotalVentasCat.Name = "LTotalVentasCat";
            LTotalVentasCat.Size = new Size(216, 20);
            LTotalVentasCat.TabIndex = 30;
            LTotalVentasCat.Text = "Total de ventas por categoría:";
            // 
            // LValorVentasCat
            // 
            LValorVentasCat.AutoSize = true;
            LValorVentasCat.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LValorVentasCat.ForeColor = Color.White;
            LValorVentasCat.Location = new Point(649, 193);
            LValorVentasCat.Name = "LValorVentasCat";
            LValorVentasCat.Size = new Size(27, 20);
            LValorVentasCat.TabIndex = 31;
            LValorVentasCat.Text = "45";
            // 
            // CBCategorias
            // 
            CBCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCategorias.FormattingEnabled = true;
            CBCategorias.Location = new Point(577, 75);
            CBCategorias.Name = "CBCategorias";
            CBCategorias.Size = new Size(166, 23);
            CBCategorias.TabIndex = 42;
            CBCategorias.SelectedIndexChanged += CBCategorias_SelectedIndexChanged;
            // 
            // CProducts
            // 
            CProducts.BackColor = Color.Transparent;
            chartArea2.BackColor = Color.Transparent;
            chartArea2.Name = "ChartArea1";
            CProducts.ChartAreas.Add(chartArea2);
            legend2.BackColor = Color.Transparent;
            legend2.ForeColor = Color.White;
            legend2.Name = "Legend1";
            legend2.TitleForeColor = Color.White;
            legend2.TitleSeparatorColor = Color.White;
            CProducts.Legends.Add(legend2);
            CProducts.Location = new Point(82, 48);
            CProducts.Name = "CProducts";
            CProducts.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            CProducts.Series.Add(series2);
            CProducts.Size = new Size(382, 245);
            CProducts.TabIndex = 43;
            CProducts.Text = "chart1";
            CProducts.Click += CProducts_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(26, 32, 40);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(LValorVentasTot);
            panel2.Controls.Add(LTotalVentasTot);
            panel2.Controls.Add(CProducts);
            panel2.Controls.Add(CBCategorias);
            panel2.Controls.Add(LValorVentasCat);
            panel2.Controls.Add(LTotalVentasCat);
            panel2.Controls.Add(LCantVentas);
            panel2.Location = new Point(12, 191);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 334);
            panel2.TabIndex = 30;
            panel2.Paint += panel2_Paint;
            // 
            // LValorVentasTot
            // 
            LValorVentasTot.AutoSize = true;
            LValorVentasTot.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LValorVentasTot.ForeColor = Color.White;
            LValorVentasTot.Location = new Point(648, 261);
            LValorVentasTot.Name = "LValorVentasTot";
            LValorVentasTot.Size = new Size(27, 20);
            LValorVentasTot.TabIndex = 45;
            LValorVentasTot.Text = "45";
            // 
            // LTotalVentasTot
            // 
            LTotalVentasTot.AutoSize = true;
            LTotalVentasTot.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LTotalVentasTot.ForeColor = Color.White;
            LTotalVentasTot.Location = new Point(565, 229);
            LTotalVentasTot.Name = "LTotalVentasTot";
            LTotalVentasTot.Size = new Size(192, 20);
            LTotalVentasTot.TabIndex = 44;
            LTotalVentasTot.Text = "Total de ventas realizadas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(26, 32, 40);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(123, 296);
            label3.Name = "label3";
            label3.Size = new Size(241, 21);
            label3.TabIndex = 45;
            label3.Text = "Top 5 productos más vendidos";
            // 
            // FormInformeVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 537);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormInformeVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informe de Vendedor";
            Load += FormInformeVendedor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CProducts).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Label LCantVentas;
        private Label LTotalVentasCat;
        private Label LValorVentasCat;
        private ComboBox CBCategorias;
        private System.Windows.Forms.DataVisualization.Charting.Chart CProducts;
        private Panel panel2;
        private Label LValorVentasTot;
        private Label LTotalVentasTot;
        private Label label3;
    }
}