namespace CyberGear16
{
    partial class FormMasVendidos
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
            DGVProductos = new DataGridView();
            BGeneral = new Button();
            LValorVentasTot = new Label();
            PReporte = new Panel();
            BReporte = new Button();
            LHasta = new Label();
            label4 = new Label();
            DTPHasta = new DateTimePicker();
            DTPDesde = new DateTimePicker();
            LTotalVentasTot = new Label();
            LTop = new Label();
            CBCategorias = new ComboBox();
            LUsuarios = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVProductos).BeginInit();
            PReporte.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(DGVProductos);
            panel1.Controls.Add(BGeneral);
            panel1.Controls.Add(LValorVentasTot);
            panel1.Controls.Add(PReporte);
            panel1.Controls.Add(LTotalVentasTot);
            panel1.Controls.Add(LTop);
            panel1.Controls.Add(CBCategorias);
            panel1.Controls.Add(LUsuarios);
            panel1.Location = new Point(12, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 669);
            panel1.TabIndex = 0;
            // 
            // DGVProductos
            // 
            DGVProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVProductos.Location = new Point(43, 336);
            DGVProductos.Name = "DGVProductos";
            DGVProductos.RowTemplate.Height = 25;
            DGVProductos.Size = new Size(436, 254);
            DGVProductos.TabIndex = 49;
            // 
            // BGeneral
            // 
            BGeneral.Location = new Point(526, 504);
            BGeneral.Name = "BGeneral";
            BGeneral.Size = new Size(227, 37);
            BGeneral.TabIndex = 48;
            BGeneral.Text = "Reporte General";
            BGeneral.UseVisualStyleBackColor = true;
            BGeneral.Click += BGeneral_Click;
            // 
            // LValorVentasTot
            // 
            LValorVentasTot.AutoSize = true;
            LValorVentasTot.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LValorVentasTot.ForeColor = Color.White;
            LValorVentasTot.Location = new Point(629, 467);
            LValorVentasTot.Name = "LValorVentasTot";
            LValorVentasTot.Size = new Size(27, 20);
            LValorVentasTot.TabIndex = 47;
            LValorVentasTot.Text = "45";
            // 
            // PReporte
            // 
            PReporte.Anchor = AnchorStyles.None;
            PReporte.BackColor = Color.SteelBlue;
            PReporte.Controls.Add(BReporte);
            PReporte.Controls.Add(LHasta);
            PReporte.Controls.Add(label4);
            PReporte.Controls.Add(DTPHasta);
            PReporte.Controls.Add(DTPDesde);
            PReporte.Location = new Point(43, 103);
            PReporte.Name = "PReporte";
            PReporte.Size = new Size(694, 202);
            PReporte.TabIndex = 41;
            // 
            // BReporte
            // 
            BReporte.Location = new Point(235, 129);
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
            LHasta.Location = new Point(468, 23);
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
            label4.Location = new Point(153, 23);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 2;
            label4.Text = "Desde:";
            // 
            // DTPHasta
            // 
            DTPHasta.Format = DateTimePickerFormat.Short;
            DTPHasta.Location = new Point(406, 67);
            DTPHasta.Name = "DTPHasta";
            DTPHasta.Size = new Size(202, 23);
            DTPHasta.TabIndex = 1;
            // 
            // DTPDesde
            // 
            DTPDesde.Format = DateTimePickerFormat.Short;
            DTPDesde.Location = new Point(89, 67);
            DTPDesde.Name = "DTPDesde";
            DTPDesde.Size = new Size(202, 23);
            DTPDesde.TabIndex = 0;
            // 
            // LTotalVentasTot
            // 
            LTotalVentasTot.AutoSize = true;
            LTotalVentasTot.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LTotalVentasTot.ForeColor = Color.White;
            LTotalVentasTot.Location = new Point(545, 435);
            LTotalVentasTot.Name = "LTotalVentasTot";
            LTotalVentasTot.Size = new Size(192, 20);
            LTotalVentasTot.TabIndex = 46;
            LTotalVentasTot.Text = "Total de ventas realizadas:";
            // 
            // LTop
            // 
            LTop.AutoSize = true;
            LTop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LTop.ForeColor = Color.White;
            LTop.Location = new Point(110, 614);
            LTop.Name = "LTop";
            LTop.Size = new Size(261, 21);
            LTop.TabIndex = 40;
            LTop.Text = "Cantidad de productos vendidos:";
            // 
            // CBCategorias
            // 
            CBCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCategorias.FormattingEnabled = true;
            CBCategorias.Location = new Point(562, 336);
            CBCategorias.Name = "CBCategorias";
            CBCategorias.Size = new Size(166, 23);
            CBCategorias.TabIndex = 3;
            CBCategorias.SelectedIndexChanged += CBCategorias_SelectedIndexChanged;
            // 
            // LUsuarios
            // 
            LUsuarios.AutoSize = true;
            LUsuarios.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LUsuarios.ForeColor = Color.White;
            LUsuarios.Location = new Point(252, 43);
            LUsuarios.Name = "LUsuarios";
            LUsuarios.Size = new Size(262, 30);
            LUsuarios.TabIndex = 2;
            LUsuarios.Text = "Productos Más Vendidos:";
            // 
            // FormMasVendidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 701);
            Controls.Add(panel1);
            Name = "FormMasVendidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos Más Vendidos";
            Load += FormMasVendidos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVProductos).EndInit();
            PReporte.ResumeLayout(false);
            PReporte.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox CBCategorias;
        private Label LUsuarios;
        private Label LTop;
        private Panel PReporte;
        private Button BReporte;
        private Label LHasta;
        private Label label4;
        private DateTimePicker DTPHasta;
        private DateTimePicker DTPDesde;
        private Label LValorVentasTot;
        private Label LTotalVentasTot;
        private Button BGeneral;
        private DataGridView DGVProductos;
    }
}