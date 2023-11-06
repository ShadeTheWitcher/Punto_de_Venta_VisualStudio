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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            BGeneral = new Button();
            LTop = new Label();
            LComprasCat = new Label();
            LTextComprasCat = new Label();
            CProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            CBCategorias = new ComboBox();
            LComprasTot = new Label();
            LTextComprasTot = new Label();
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
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CProducts).BeginInit();
            PReporte.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVReportes).BeginInit();
            SuspendLayout();
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LApellido.ForeColor = Color.White;
            LApellido.Location = new Point(22, 108);
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
            LDni.Location = new Point(209, 56);
            LDni.Name = "LDni";
            LDni.Size = new Size(41, 20);
            LDni.TabIndex = 23;
            LDni.Text = "DNI:";
            LDni.Click += LDni_Click;
            // 
            // LMNombre
            // 
            LMNombre.AutoSize = true;
            LMNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LMNombre.ForeColor = Color.White;
            LMNombre.Location = new Point(92, 56);
            LMNombre.Name = "LMNombre";
            LMNombre.Size = new Size(64, 20);
            LMNombre.TabIndex = 22;
            LMNombre.Text = "Nombre";
            LMNombre.Click += LMNombre_Click;
            // 
            // LMTelefono
            // 
            LMTelefono.AutoSize = true;
            LMTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LMTelefono.ForeColor = Color.White;
            LMTelefono.Location = new Point(425, 56);
            LMTelefono.Name = "LMTelefono";
            LMTelefono.Size = new Size(67, 20);
            LMTelefono.TabIndex = 20;
            LMTelefono.Text = "Telefono";
            LMTelefono.Click += LMTelefono_Click;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LTelefono.ForeColor = Color.White;
            LTelefono.Location = new Point(341, 56);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(74, 20);
            LTelefono.TabIndex = 19;
            LTelefono.Text = "Telefono:";
            LTelefono.Click += LTelefono_Click;
            // 
            // LMEmail
            // 
            LMEmail.AutoSize = true;
            LMEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LMEmail.ForeColor = Color.White;
            LMEmail.Location = new Point(256, 108);
            LMEmail.Name = "LMEmail";
            LMEmail.Size = new Size(46, 20);
            LMEmail.TabIndex = 18;
            LMEmail.Text = "Email";
            LMEmail.Click += LMEmail_Click;
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LEmail.ForeColor = Color.White;
            LEmail.Location = new Point(199, 108);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(51, 20);
            LEmail.TabIndex = 17;
            LEmail.Text = "Email:";
            LEmail.Click += LEmail_Click;
            // 
            // LMDni
            // 
            LMDni.AutoSize = true;
            LMDni.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LMDni.ForeColor = Color.White;
            LMDni.Location = new Point(256, 56);
            LMDni.Name = "LMDni";
            LMDni.Size = new Size(35, 20);
            LMDni.TabIndex = 16;
            LMDni.Text = "DNI";
            LMDni.Click += LMDni_Click;
            // 
            // LMApellido
            // 
            LMApellido.AutoSize = true;
            LMApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LMApellido.ForeColor = Color.White;
            LMApellido.Location = new Point(92, 108);
            LMApellido.Name = "LMApellido";
            LMApellido.Size = new Size(66, 20);
            LMApellido.TabIndex = 15;
            LMApellido.Text = "Apellido";
            LMApellido.Click += LMApellido_Click;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LNombre.ForeColor = Color.White;
            LNombre.Location = new Point(22, 56);
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
            LCantProduct.Location = new Point(170, 11);
            LCantProduct.Name = "LCantProduct";
            LCantProduct.Size = new Size(446, 25);
            LCantProduct.TabIndex = 27;
            LCantProduct.Text = "Cantidad de productos comprados por el cliente:";
            LCantProduct.Click += LCantProduct_Click;
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 151);
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
            panel2.Controls.Add(BGeneral);
            panel2.Controls.Add(LTop);
            panel2.Controls.Add(LComprasCat);
            panel2.Controls.Add(LTextComprasCat);
            panel2.Controls.Add(CProducts);
            panel2.Controls.Add(CBCategorias);
            panel2.Controls.Add(LComprasTot);
            panel2.Controls.Add(LTextComprasTot);
            panel2.Controls.Add(LCantProduct);
            panel2.Location = new Point(12, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(1035, 318);
            panel2.TabIndex = 29;
            // 
            // BGeneral
            // 
            BGeneral.Location = new Point(693, 258);
            BGeneral.Name = "BGeneral";
            BGeneral.Size = new Size(227, 37);
            BGeneral.TabIndex = 45;
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
            LTop.Location = new Point(119, 282);
            LTop.Name = "LTop";
            LTop.Size = new Size(256, 21);
            LTop.TabIndex = 44;
            LTop.Text = "Top 5 productos más comprados";
            // 
            // LComprasCat
            // 
            LComprasCat.AutoSize = true;
            LComprasCat.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LComprasCat.ForeColor = Color.White;
            LComprasCat.Location = new Point(799, 138);
            LComprasCat.Name = "LComprasCat";
            LComprasCat.Size = new Size(27, 20);
            LComprasCat.TabIndex = 43;
            LComprasCat.Text = "45";
            // 
            // LTextComprasCat
            // 
            LTextComprasCat.AutoSize = true;
            LTextComprasCat.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LTextComprasCat.ForeColor = Color.White;
            LTextComprasCat.Location = new Point(690, 106);
            LTextComprasCat.Name = "LTextComprasCat";
            LTextComprasCat.Size = new Size(230, 20);
            LTextComprasCat.TabIndex = 42;
            LTextComprasCat.Text = "Total de compras por categoría:";
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
            CProducts.Location = new Point(22, 48);
            CProducts.Name = "CProducts";
            CProducts.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            CProducts.Series.Add(series2);
            CProducts.Size = new Size(531, 231);
            CProducts.TabIndex = 41;
            CProducts.Text = "chart1";
            // 
            // CBCategorias
            // 
            CBCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCategorias.FormattingEnabled = true;
            CBCategorias.Location = new Point(724, 50);
            CBCategorias.Name = "CBCategorias";
            CBCategorias.Size = new Size(166, 23);
            CBCategorias.TabIndex = 40;
            CBCategorias.SelectedIndexChanged += CBCategorias_SelectedIndexChanged;
            // 
            // LComprasTot
            // 
            LComprasTot.AutoSize = true;
            LComprasTot.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LComprasTot.ForeColor = Color.White;
            LComprasTot.Location = new Point(799, 211);
            LComprasTot.Name = "LComprasTot";
            LComprasTot.Size = new Size(27, 20);
            LComprasTot.TabIndex = 36;
            LComprasTot.Text = "10";
            // 
            // LTextComprasTot
            // 
            LTextComprasTot.AutoSize = true;
            LTextComprasTot.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LTextComprasTot.ForeColor = Color.White;
            LTextComprasTot.Location = new Point(706, 181);
            LTextComprasTot.Name = "LTextComprasTot";
            LTextComprasTot.Size = new Size(206, 20);
            LTextComprasTot.TabIndex = 35;
            LTextComprasTot.Text = "Total de compras realizadas:";
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
            PReporte.TabIndex = 32;
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
            // 
            // DTPDesde
            // 
            DTPDesde.Format = DateTimePickerFormat.Short;
            DTPDesde.Location = new Point(41, 44);
            DTPDesde.Name = "DTPDesde";
            DTPDesde.Size = new Size(202, 23);
            DTPDesde.TabIndex = 0;
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
            panel4.Location = new Point(12, 498);
            panel4.Name = "panel4";
            panel4.Size = new Size(1035, 230);
            panel4.TabIndex = 47;
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
            DGVReportes.Location = new Point(44, 57);
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
            LRProductos.Size = new Size(96, 25);
            LRProductos.TabIndex = 5;
            LRProductos.Text = "Compras:";
            // 
            // FormInformeCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1058, 740);
            Controls.Add(panel4);
            Controls.Add(PReporte);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormInformeCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informe de Cliente";
            Load += FormInformeCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CProducts).EndInit();
            PReporte.ResumeLayout(false);
            PReporte.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private Label LComprasTot;
        private Label LTextComprasTot;
        private System.Windows.Forms.DataVisualization.Charting.Chart CProducts;
        private ComboBox CBCategorias;
        private Label LComprasCat;
        private Label LTextComprasCat;
        private Label LTop;
        private Panel PReporte;
        private Button BReporte;
        private Label LHasta;
        private Label label4;
        private DateTimePicker DTPHasta;
        private DateTimePicker DTPDesde;
        private Button BGeneral;
        private Panel panel4;
        private Label LRHasta;
        private Label LRDesde;
        private DateTimePicker DTPGHasta;
        private DateTimePicker DTPGDesde;
        private DataGridView DGVReportes;
        private Label LRProductos;
    }
}