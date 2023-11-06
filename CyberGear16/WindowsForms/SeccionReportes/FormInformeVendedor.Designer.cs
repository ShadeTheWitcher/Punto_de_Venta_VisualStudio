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
            BGeneral = new Button();
            LTop = new Label();
            LValorVentasTot = new Label();
            LTotalVentasTot = new Label();
            PReporte = new Panel();
            BReporte = new Button();
            LHasta = new Label();
            label4 = new Label();
            DTPHasta = new DateTimePicker();
            DTPDesde = new DateTimePicker();
            panel4 = new Panel();
            LRHasta = new Label();
            LRDesde = new Label();
            DTPGHasta = new DateTimePicker();
            DTPGDesde = new DateTimePicker();
            DGVReportes = new DataGridView();
            LRProductos = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CProducts).BeginInit();
            panel2.SuspendLayout();
            PReporte.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVReportes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(LCliente);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(LMNombre);
            panel1.Controls.Add(LMTelefono);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(LMEmail);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(LMDni);
            panel1.Controls.Add(LMApellido);
            panel1.Controls.Add(LNombre);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 151);
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
            label1.Location = new Point(22, 107);
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
            label2.Location = new Point(217, 55);
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
            LMNombre.Location = new Point(92, 55);
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
            LMTelefono.Location = new Point(420, 55);
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
            label5.Location = new Point(349, 55);
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
            LMEmail.Location = new Point(264, 107);
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
            label7.Location = new Point(207, 107);
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
            LMDni.Location = new Point(264, 55);
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
            LMApellido.Location = new Point(92, 107);
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
            LNombre.Location = new Point(22, 55);
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
            LTotalVentasCat.Location = new Point(681, 115);
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
            LValorVentasCat.Location = new Point(780, 147);
            LValorVentasCat.Name = "LValorVentasCat";
            LValorVentasCat.Size = new Size(27, 20);
            LValorVentasCat.TabIndex = 31;
            LValorVentasCat.Text = "45";
            // 
            // CBCategorias
            // 
            CBCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCategorias.FormattingEnabled = true;
            CBCategorias.Location = new Point(707, 48);
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
            CProducts.Size = new Size(451, 233);
            CProducts.TabIndex = 43;
            CProducts.Text = "chart1";
            CProducts.Click += CProducts_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(26, 32, 40);
            panel2.Controls.Add(BGeneral);
            panel2.Controls.Add(LTop);
            panel2.Controls.Add(LValorVentasTot);
            panel2.Controls.Add(LTotalVentasTot);
            panel2.Controls.Add(CProducts);
            panel2.Controls.Add(CBCategorias);
            panel2.Controls.Add(LValorVentasCat);
            panel2.Controls.Add(LTotalVentasCat);
            panel2.Controls.Add(LCantVentas);
            panel2.Location = new Point(12, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(1035, 318);
            panel2.TabIndex = 30;
            panel2.Paint += panel2_Paint;
            // 
            // BGeneral
            // 
            BGeneral.Location = new Point(679, 257);
            BGeneral.Name = "BGeneral";
            BGeneral.Size = new Size(227, 37);
            BGeneral.TabIndex = 5;
            BGeneral.Text = "Reporte General";
            BGeneral.UseVisualStyleBackColor = true;
            BGeneral.Click += BGeneral_Click;
            // 
            // LTop
            // 
            LTop.AutoSize = true;
            LTop.BackColor = Color.FromArgb(26, 32, 40);
            LTop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LTop.ForeColor = Color.White;
            LTop.Location = new Point(150, 284);
            LTop.Name = "LTop";
            LTop.Size = new Size(241, 21);
            LTop.TabIndex = 45;
            LTop.Text = "Top 5 productos más vendidos";
            // 
            // LValorVentasTot
            // 
            LValorVentasTot.AutoSize = true;
            LValorVentasTot.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LValorVentasTot.ForeColor = Color.White;
            LValorVentasTot.Location = new Point(780, 215);
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
            LTotalVentasTot.Location = new Point(696, 183);
            LTotalVentasTot.Name = "LTotalVentasTot";
            LTotalVentasTot.Size = new Size(192, 20);
            LTotalVentasTot.TabIndex = 44;
            LTotalVentasTot.Text = "Total de ventas realizadas:";
            // 
            // PReporte
            // 
            PReporte.Anchor = AnchorStyles.None;
            PReporte.BackColor = Color.FromArgb(26, 32, 40);
            PReporte.Controls.Add(BReporte);
            PReporte.Controls.Add(LHasta);
            PReporte.Controls.Add(label4);
            PReporte.Controls.Add(DTPHasta);
            PReporte.Controls.Add(DTPDesde);
            PReporte.Location = new Point(551, 12);
            PReporte.Name = "PReporte";
            PReporte.Size = new Size(496, 151);
            PReporte.TabIndex = 31;
            // 
            // BReporte
            // 
            BReporte.Location = new Point(131, 82);
            BReporte.Name = "BReporte";
            BReporte.Size = new Size(236, 44);
            BReporte.TabIndex = 4;
            BReporte.Text = "Generar Reporte";
            BReporte.UseVisualStyleBackColor = true;
            BReporte.Click += BReporte_Click;
            // 
            // LHasta
            // 
            LHasta.AutoSize = true;
            LHasta.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LHasta.ForeColor = Color.White;
            LHasta.Location = new Point(332, 5);
            LHasta.Name = "LHasta";
            LHasta.Size = new Size(75, 25);
            LHasta.TabIndex = 3;
            LHasta.Text = "Hasta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(109, 5);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 2;
            label4.Text = "Desde:";
            // 
            // DTPHasta
            // 
            DTPHasta.Format = DateTimePickerFormat.Short;
            DTPHasta.Location = new Point(256, 44);
            DTPHasta.Name = "DTPHasta";
            DTPHasta.Size = new Size(202, 23);
            DTPHasta.TabIndex = 1;
            DTPHasta.ValueChanged += DTPHasta_ValueChanged;
            // 
            // DTPDesde
            // 
            DTPDesde.Format = DateTimePickerFormat.Short;
            DTPDesde.Location = new Point(41, 44);
            DTPDesde.Name = "DTPDesde";
            DTPDesde.Size = new Size(202, 23);
            DTPDesde.TabIndex = 0;
            DTPDesde.ValueChanged += DTPDesde_ValueChanged;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(26, 32, 40);
            panel4.Controls.Add(LRHasta);
            panel4.Controls.Add(LRDesde);
            panel4.Controls.Add(DTPGHasta);
            panel4.Controls.Add(DTPGDesde);
            panel4.Controls.Add(DGVReportes);
            panel4.Controls.Add(LRProductos);
            panel4.Location = new Point(12, 493);
            panel4.Name = "panel4";
            panel4.Size = new Size(1035, 230);
            panel4.TabIndex = 46;
            // 
            // LRHasta
            // 
            LRHasta.AutoSize = true;
            LRHasta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LRHasta.ForeColor = Color.White;
            LRHasta.Location = new Point(537, 12);
            LRHasta.Name = "LRHasta";
            LRHasta.Size = new Size(67, 25);
            LRHasta.TabIndex = 12;
            LRHasta.Text = "Hasta:";
            // 
            // LRDesde
            // 
            LRDesde.AutoSize = true;
            LRDesde.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LRDesde.ForeColor = Color.White;
            LRDesde.Location = new Point(281, 12);
            LRDesde.Name = "LRDesde";
            LRDesde.Size = new Size(71, 25);
            LRDesde.TabIndex = 11;
            LRDesde.Text = "Desde:";
            // 
            // DTPGHasta
            // 
            DTPGHasta.Enabled = false;
            DTPGHasta.Format = DateTimePickerFormat.Short;
            DTPGHasta.Location = new Point(631, 14);
            DTPGHasta.Name = "DTPGHasta";
            DTPGHasta.Size = new Size(108, 23);
            DTPGHasta.TabIndex = 10;
            // 
            // DTPGDesde
            // 
            DTPGDesde.Enabled = false;
            DTPGDesde.Format = DateTimePickerFormat.Short;
            DTPGDesde.Location = new Point(375, 14);
            DTPGDesde.Name = "DTPGDesde";
            DTPGDesde.Size = new Size(101, 23);
            DTPGDesde.TabIndex = 9;
            // 
            // DGVReportes
            // 
            DGVReportes.Anchor = AnchorStyles.None;
            DGVReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVReportes.Location = new Point(43, 60);
            DGVReportes.Name = "DGVReportes";
            DGVReportes.RowTemplate.Height = 25;
            DGVReportes.Size = new Size(953, 155);
            DGVReportes.TabIndex = 8;
            DGVReportes.CellContentClick += DGVReportes_CellContentClick;
            // 
            // LRProductos
            // 
            LRProductos.AutoSize = true;
            LRProductos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LRProductos.ForeColor = Color.White;
            LRProductos.Location = new Point(18, 12);
            LRProductos.Name = "LRProductos";
            LRProductos.Size = new Size(76, 25);
            LRProductos.TabIndex = 5;
            LRProductos.Text = "Ventas:";
            // 
            // FormInformeVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 740);
            Controls.Add(panel4);
            Controls.Add(PReporte);
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
            PReporte.ResumeLayout(false);
            PReporte.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private Label LTop;
        private Panel PReporte;
        private Button BReporte;
        private Label LHasta;
        private Label label4;
        private DateTimePicker DTPHasta;
        private DateTimePicker DTPDesde;
        private Panel panel4;
        private Label LRHasta;
        private Label LRDesde;
        private DateTimePicker DTPGHasta;
        private DateTimePicker DTPGDesde;
        private DataGridView DGVReportes;
        private Label LRProductos;
        private Button BGeneral;
    }
}