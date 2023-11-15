namespace CyberGear16.WindowsForms.SeccionReportes
{
    partial class FormReporteSubMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteSubMenu));
            panel4 = new Panel();
            button1 = new Button();
            BSearch = new Button();
            TSearch = new TextBox();
            BBorrar = new Button();
            BBuscar = new Button();
            TBuscar = new TextBox();
            DGVReportes = new DataGridView();
            LRClienteVendedor = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVReportes).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(26, 32, 40);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(BSearch);
            panel4.Controls.Add(TSearch);
            panel4.Controls.Add(BBorrar);
            panel4.Controls.Add(BBuscar);
            panel4.Controls.Add(TBuscar);
            panel4.Controls.Add(DGVReportes);
            panel4.Controls.Add(LRClienteVendedor);
            panel4.Location = new Point(12, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1021, 642);
            panel4.TabIndex = 9;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(966, 19);
            button1.Name = "button1";
            button1.Size = new Size(38, 37);
            button1.TabIndex = 21;
            button1.UseVisualStyleBackColor = true;
            button1.Click += BDelete_Click;
            // 
            // BSearch
            // 
            BSearch.Anchor = AnchorStyles.None;
            BSearch.Image = Properties.Resources.lupa;
            BSearch.Location = new Point(922, 19);
            BSearch.Name = "BSearch";
            BSearch.Size = new Size(38, 37);
            BSearch.TabIndex = 20;
            BSearch.UseVisualStyleBackColor = true;
            BSearch.Click += BSearch_Click;
            // 
            // TSearch
            // 
            TSearch.Anchor = AnchorStyles.None;
            TSearch.Location = new Point(603, 28);
            TSearch.Name = "TSearch";
            TSearch.Size = new Size(313, 23);
            TSearch.TabIndex = 19;
            TSearch.Text = "Buscar";
            TSearch.Click += TSearch_Click;
            TSearch.KeyPress += TSearch_KeyPress;
            // 
            // BBorrar
            // 
            BBorrar.Anchor = AnchorStyles.None;
            BBorrar.Image = (Image)resources.GetObject("BBorrar.Image");
            BBorrar.Location = new Point(1387, 280);
            BBorrar.Name = "BBorrar";
            BBorrar.Size = new Size(38, 32);
            BBorrar.TabIndex = 18;
            BBorrar.UseVisualStyleBackColor = true;
            // 
            // BBuscar
            // 
            BBuscar.Anchor = AnchorStyles.None;
            BBuscar.Image = Properties.Resources.lupa;
            BBuscar.Location = new Point(1343, 280);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(38, 32);
            BBuscar.TabIndex = 17;
            BBuscar.UseVisualStyleBackColor = true;
            // 
            // TBuscar
            // 
            TBuscar.Anchor = AnchorStyles.None;
            TBuscar.Location = new Point(1180, 286);
            TBuscar.Name = "TBuscar";
            TBuscar.Size = new Size(157, 23);
            TBuscar.TabIndex = 16;
            TBuscar.Text = "Buscar";
            // 
            // DGVReportes
            // 
            DGVReportes.Anchor = AnchorStyles.None;
            DGVReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVReportes.Location = new Point(21, 62);
            DGVReportes.Name = "DGVReportes";
            DGVReportes.RowTemplate.Height = 25;
            DGVReportes.Size = new Size(983, 545);
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
            // 
            // FormReporteSubMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 646);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReporteSubMenu";
            Text = "Form1";
            Load += FormReporteSubMenu_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Button BBorrar;
        private Button BBuscar;
        private TextBox TBuscar;
        private DataGridView DGVReportes;
        private Label LRClienteVendedor;
        private Button button1;
        private Button BSearch;
        private TextBox TSearch;
    }
}