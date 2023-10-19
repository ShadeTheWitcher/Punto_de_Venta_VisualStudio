namespace CyberGear16
{
    partial class FormReporteSuper
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
            LRProductos = new Label();
            panel4 = new Panel();
            LRHasta = new Label();
            LRDesde = new Label();
            DTPGHasta = new DateTimePicker();
            DTPGDesde = new DateTimePicker();
            DGVReportes = new DataGridView();
            LRVendedores = new Label();
            BRVendedores = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            LRVentas = new Label();
            PReporte = new Panel();
            BReporte = new Button();
            LHasta = new Label();
            label1 = new Label();
            DTPHasta = new DateTimePicker();
            DTPDesde = new DateTimePicker();
            LUsuarios = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVReportes).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            PReporte.SuspendLayout();
            SuspendLayout();
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
            panel4.Location = new Point(31, 454);
            panel4.Name = "panel4";
            panel4.Size = new Size(1019, 238);
            panel4.TabIndex = 12;
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
            DGVReportes.Location = new Point(32, 51);
            DGVReportes.Name = "DGVReportes";
            DGVReportes.RowTemplate.Height = 25;
            DGVReportes.Size = new Size(953, 155);
            DGVReportes.TabIndex = 8;
            // 
            // LRVendedores
            // 
            LRVendedores.AutoSize = true;
            LRVendedores.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LRVendedores.ForeColor = Color.White;
            LRVendedores.Location = new Point(400, 22);
            LRVendedores.Name = "LRVendedores";
            LRVendedores.Size = new Size(245, 25);
            LRVendedores.TabIndex = 4;
            LRVendedores.Text = "Reporte de Más Vendidos:";
            // 
            // BRVendedores
            // 
            BRVendedores.Location = new Point(404, 62);
            BRVendedores.Name = "BRVendedores";
            BRVendedores.Size = new Size(235, 44);
            BRVendedores.TabIndex = 4;
            BRVendedores.Text = "Generar Reporte";
            BRVendedores.UseVisualStyleBackColor = true;
            BRVendedores.Click += BRVendedores_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(26, 32, 40);
            panel3.Controls.Add(BRVendedores);
            panel3.Controls.Add(LRVendedores);
            panel3.Location = new Point(31, 315);
            panel3.Name = "panel3";
            panel3.Size = new Size(1019, 125);
            panel3.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(LRVentas);
            panel1.Controls.Add(PReporte);
            panel1.Controls.Add(LUsuarios);
            panel1.Location = new Point(31, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 288);
            panel1.TabIndex = 13;
            // 
            // LRVentas
            // 
            LRVentas.AutoSize = true;
            LRVentas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LRVentas.ForeColor = Color.White;
            LRVentas.Location = new Point(431, 40);
            LRVentas.Name = "LRVentas";
            LRVentas.Size = new Size(188, 25);
            LRVentas.TabIndex = 4;
            LRVentas.Text = "Reportes de Ventas:";
            // 
            // PReporte
            // 
            PReporte.Anchor = AnchorStyles.None;
            PReporte.BackColor = Color.SteelBlue;
            PReporte.Controls.Add(BReporte);
            PReporte.Controls.Add(LHasta);
            PReporte.Controls.Add(label1);
            PReporte.Controls.Add(DTPHasta);
            PReporte.Controls.Add(DTPDesde);
            PReporte.Location = new Point(226, 77);
            PReporte.Name = "PReporte";
            PReporte.Size = new Size(582, 187);
            PReporte.TabIndex = 3;
            // 
            // BReporte
            // 
            BReporte.Location = new Point(173, 131);
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
            LHasta.Location = new Point(428, 10);
            LHasta.Name = "LHasta";
            LHasta.Size = new Size(75, 25);
            LHasta.TabIndex = 3;
            LHasta.Text = "Hasta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 10);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 2;
            label1.Text = "Desde:";
            // 
            // DTPHasta
            // 
            DTPHasta.Format = DateTimePickerFormat.Short;
            DTPHasta.Location = new Point(362, 77);
            DTPHasta.Name = "DTPHasta";
            DTPHasta.Size = new Size(202, 23);
            DTPHasta.TabIndex = 1;
            // 
            // DTPDesde
            // 
            DTPDesde.Format = DateTimePickerFormat.Short;
            DTPDesde.Location = new Point(16, 77);
            DTPDesde.Name = "DTPDesde";
            DTPDesde.Size = new Size(202, 23);
            DTPDesde.TabIndex = 0;
            // 
            // LUsuarios
            // 
            LUsuarios.AutoSize = true;
            LUsuarios.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LUsuarios.ForeColor = Color.White;
            LUsuarios.Location = new Point(14, 14);
            LUsuarios.Name = "LUsuarios";
            LUsuarios.Size = new Size(106, 30);
            LUsuarios.TabIndex = 1;
            LUsuarios.Text = "Reportes:";
            // 
            // FormReporteSuper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 704);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReporteSuper";
            Text = "Form1";
            Load += FormReporteSuper_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVReportes).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PReporte.ResumeLayout(false);
            PReporte.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LRProductos;
        private Panel panel4;
        private Label LRVendedores;
        private Button BRVendedores;
        private Panel panel3;
        private DataGridView DGVReportes;
        private Panel panel1;
        private Label LRVentas;
        private Panel PReporte;
        private Button BReporte;
        private Label LHasta;
        private Label label1;
        private DateTimePicker DTPHasta;
        private DateTimePicker DTPDesde;
        private Label LUsuarios;
        private Label LRHasta;
        private Label LRDesde;
        private DateTimePicker DTPGHasta;
        private DateTimePicker DTPGDesde;
    }
}