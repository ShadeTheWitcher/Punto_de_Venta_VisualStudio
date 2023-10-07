namespace CyberGear16
{
    partial class FormReporteVendedor
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
            panel2 = new Panel();
            BRVendedor = new Button();
            LRVendedores = new Label();
            LReporte = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(LReporte);
            panel1.Location = new Point(28, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 663);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(BRVendedor);
            panel2.Controls.Add(LRVendedores);
            panel2.Location = new Point(170, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 386);
            panel2.TabIndex = 7;
            // 
            // BRVendedor
            // 
            BRVendedor.Location = new Point(263, 207);
            BRVendedor.Name = "BRVendedor";
            BRVendedor.Size = new Size(235, 44);
            BRVendedor.TabIndex = 5;
            BRVendedor.Text = "Generar Reporte";
            BRVendedor.UseVisualStyleBackColor = true;
            BRVendedor.Click += BRVendedor_Click;
            // 
            // LRVendedores
            // 
            LRVendedores.AutoSize = true;
            LRVendedores.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LRVendedores.ForeColor = Color.White;
            LRVendedores.Location = new Point(248, 101);
            LRVendedores.Name = "LRVendedores";
            LRVendedores.Size = new Size(262, 25);
            LRVendedores.TabIndex = 6;
            LRVendedores.Text = "Reporte de Cliente (Propio):";
            // 
            // LReporte
            // 
            LReporte.AutoSize = true;
            LReporte.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LReporte.ForeColor = Color.White;
            LReporte.Location = new Point(31, 18);
            LReporte.Name = "LReporte";
            LReporte.Size = new Size(97, 30);
            LReporte.TabIndex = 3;
            LReporte.Text = "Reporte:";
            // 
            // FormReporteVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReporteVendedor";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LReporte;
        private Panel panel2;
        private Button BRVendedor;
        private Label LRVendedores;
    }
}