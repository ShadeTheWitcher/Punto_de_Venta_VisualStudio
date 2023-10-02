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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporte));
            panel2 = new Panel();
            BRClientes = new Button();
            LRClientes = new Label();
            panel3 = new Panel();
            BRVendedores = new Button();
            LRVendedores = new Label();
            DGVReportes = new DataGridView();
            LRClienteVendedor = new Label();
            panel4 = new Panel();
            BBorrar = new Button();
            BBuscar = new Button();
            TBuscar = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVReportes).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(26, 32, 40);
            panel2.Controls.Add(BRClientes);
            panel2.Controls.Add(LRClientes);
            panel2.Location = new Point(15, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(1034, 181);
            panel2.TabIndex = 5;
            // 
            // BRClientes
            // 
            BRClientes.Location = new Point(425, 82);
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
            LRClientes.Location = new Point(453, 39);
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
            panel3.Location = new Point(15, 219);
            panel3.Name = "panel3";
            panel3.Size = new Size(1034, 190);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
            // 
            // BRVendedores
            // 
            BRVendedores.Location = new Point(425, 93);
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
            LRVendedores.Location = new Point(425, 53);
            LRVendedores.Name = "LRVendedores";
            LRVendedores.Size = new Size(227, 25);
            LRVendedores.TabIndex = 4;
            LRVendedores.Text = "Reporte de Vendedores:";
            // 
            // DGVReportes
            // 
            DGVReportes.Anchor = AnchorStyles.None;
            DGVReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVReportes.Location = new Point(18, 51);
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
            panel4.Controls.Add(BBorrar);
            panel4.Controls.Add(BBuscar);
            panel4.Controls.Add(TBuscar);
            panel4.Controls.Add(DGVReportes);
            panel4.Controls.Add(LRClienteVendedor);
            panel4.Location = new Point(15, 428);
            panel4.Name = "panel4";
            panel4.Size = new Size(1034, 238);
            panel4.TabIndex = 8;
            // 
            // BBorrar
            // 
            BBorrar.Anchor = AnchorStyles.None;
            BBorrar.Image = (Image)resources.GetObject("BBorrar.Image");
            BBorrar.Location = new Point(977, 9);
            BBorrar.Name = "BBorrar";
            BBorrar.Size = new Size(38, 32);
            BBorrar.TabIndex = 18;
            BBorrar.UseVisualStyleBackColor = true;
            // 
            // BBuscar
            // 
            BBuscar.Anchor = AnchorStyles.None;
            BBuscar.Image = Properties.Resources.lupa;
            BBuscar.Location = new Point(933, 9);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(38, 32);
            BBuscar.TabIndex = 17;
            BBuscar.UseVisualStyleBackColor = true;
            // 
            // TBuscar
            // 
            TBuscar.Anchor = AnchorStyles.None;
            TBuscar.Location = new Point(770, 15);
            TBuscar.Name = "TBuscar";
            TBuscar.Size = new Size(157, 23);
            TBuscar.TabIndex = 16;
            TBuscar.Text = "Buscar";
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1061, 685);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReporte";
            Text = "Form1";
            Load += FormReporte_Load;
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
        private Panel panel2;
        private Button BRClientes;
        private Label LRClientes;
        private Panel panel3;
        private Button BRVendedores;
        private Label LRVendedores;
        private DataGridView DGVReportes;
        private Label LRClienteVendedor;
        private Panel panel4;
        private Button BBorrar;
        private Button BBuscar;
        private TextBox TBuscar;
    }
}