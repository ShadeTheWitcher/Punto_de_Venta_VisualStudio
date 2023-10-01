namespace CyberGear16
{
    partial class FormReporte
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
            LUsuarios = new Label();
            panel1 = new Panel();
            LRVentas = new Label();
            PReporte = new Panel();
            BReporte = new Button();
            LHasta = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            DTPDesde = new DateTimePicker();
            panel2 = new Panel();
            BRClientes = new Button();
            LRClientes = new Label();
            panel3 = new Panel();
            BRVendedores = new Button();
            LRVendedores = new Label();
            DGVReportes = new DataGridView();
            LRClienteVendedor = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            PReporte.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVReportes).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
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
            LUsuarios.Click += LUsuarios_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(LRVentas);
            panel1.Controls.Add(PReporte);
            panel1.Controls.Add(LUsuarios);
            panel1.Location = new Point(12, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(1034, 326);
            panel1.TabIndex = 3;
            // 
            // LRVentas
            // 
            LRVentas.AutoSize = true;
            LRVentas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LRVentas.ForeColor = Color.White;
            LRVentas.Location = new Point(429, 46);
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
            PReporte.Controls.Add(dateTimePicker1);
            PReporte.Controls.Add(DTPDesde);
            PReporte.Location = new Point(227, 97);
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
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(362, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(202, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // DTPDesde
            // 
            DTPDesde.Format = DateTimePickerFormat.Short;
            DTPDesde.Location = new Point(16, 77);
            DTPDesde.Name = "DTPDesde";
            DTPDesde.Size = new Size(202, 23);
            DTPDesde.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(26, 32, 40);
            panel2.Controls.Add(BRClientes);
            panel2.Controls.Add(LRClientes);
            panel2.Location = new Point(12, 374);
            panel2.Name = "panel2";
            panel2.Size = new Size(512, 123);
            panel2.TabIndex = 5;
            // 
            // BRClientes
            // 
            BRClientes.Location = new Point(137, 62);
            BRClientes.Name = "BRClientes";
            BRClientes.Size = new Size(235, 44);
            BRClientes.TabIndex = 4;
            BRClientes.Text = "Generar Reporte";
            BRClientes.UseVisualStyleBackColor = true;
            BRClientes.Click += BRClientes_Click;
            // 
            // LRClientes
            // 
            LRClientes.AutoSize = true;
            LRClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LRClientes.ForeColor = Color.White;
            LRClientes.Location = new Point(165, 19);
            LRClientes.Name = "LRClientes";
            LRClientes.Size = new Size(190, 25);
            LRClientes.TabIndex = 4;
            LRClientes.Text = "Reporte de Clientes:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(26, 32, 40);
            panel3.Controls.Add(BRVendedores);
            panel3.Controls.Add(LRVendedores);
            panel3.Location = new Point(530, 374);
            panel3.Name = "panel3";
            panel3.Size = new Size(516, 123);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
            // 
            // BRVendedores
            // 
            BRVendedores.Location = new Point(155, 59);
            BRVendedores.Name = "BRVendedores";
            BRVendedores.Size = new Size(235, 44);
            BRVendedores.TabIndex = 4;
            BRVendedores.Text = "Generar Reporte";
            BRVendedores.UseVisualStyleBackColor = true;
            BRVendedores.Click += BRVendedores_Click;
            // 
            // LRVendedores
            // 
            LRVendedores.AutoSize = true;
            LRVendedores.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LRVendedores.ForeColor = Color.White;
            LRVendedores.Location = new Point(155, 19);
            LRVendedores.Name = "LRVendedores";
            LRVendedores.Size = new Size(227, 25);
            LRVendedores.TabIndex = 4;
            LRVendedores.Text = "Reporte de Vendedores:";
            // 
            // DGVReportes
            // 
            DGVReportes.Anchor = AnchorStyles.None;
            DGVReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVReportes.Location = new Point(30, 562);
            DGVReportes.Name = "DGVReportes";
            DGVReportes.RowTemplate.Height = 25;
            DGVReportes.Size = new Size(997, 155);
            DGVReportes.TabIndex = 7;
            DGVReportes.CellContentClick += DGVReportes_CellContentClick;
            // 
            // LRClienteVendedor
            // 
            LRClienteVendedor.AutoSize = true;
            LRClienteVendedor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LRClienteVendedor.ForeColor = Color.White;
            LRClienteVendedor.Location = new Point(18, 10);
            LRClienteVendedor.Name = "LRClienteVendedor";
            LRClienteVendedor.Size = new Size(86, 25);
            LRClienteVendedor.TabIndex = 5;
            LRClienteVendedor.Text = "Clientes:";
            LRClienteVendedor.Click += LRClienteVendedor_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(26, 32, 40);
            panel4.Controls.Add(LRClienteVendedor);
            panel4.Location = new Point(12, 503);
            panel4.Name = "panel4";
            panel4.Size = new Size(1034, 238);
            panel4.TabIndex = 8;
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1061, 788);
            Controls.Add(DGVReportes);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReporte";
            Text = "Form1";
            Load += FormReporte_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PReporte.ResumeLayout(false);
            PReporte.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVReportes).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LUsuarios;
        private Panel panel1;
        private Panel PReporte;
        private Label LRVentas;
        private Button BReporte;
        private Label LHasta;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker DTPDesde;
        private Panel panel2;
        private Button BRClientes;
        private Label LRClientes;
        private Panel panel3;
        private Button BRVendedores;
        private Label LRVendedores;
        private DataGridView DGVReportes;
        private Label LRClienteVendedor;
        private Panel panel4;
    }
}