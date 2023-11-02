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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            CProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            CBCategorias = new ComboBox();
            LUsuarios = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CProducts);
            panel1.Controls.Add(CBCategorias);
            panel1.Controls.Add(LUsuarios);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 506);
            panel1.TabIndex = 0;
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
            CProducts.Location = new Point(24, 145);
            CProducts.Name = "CProducts";
            CProducts.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            CProducts.Series.Add(series2);
            CProducts.Size = new Size(490, 245);
            CProducts.TabIndex = 39;
            CProducts.Text = "chart1";
            CProducts.Click += CProducts_Click;
            // 
            // CBCategorias
            // 
            CBCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCategorias.FormattingEnabled = true;
            CBCategorias.Location = new Point(553, 145);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 425);
            label1.Name = "label1";
            label1.Size = new Size(351, 21);
            label1.TabIndex = 40;
            label1.Text = "Top 5 productos más vendidos en la empresa";
            // 
            // FormMasVendidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(panel1);
            Name = "FormMasVendidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos Más Vendidos";
            Load += FormMasVendidos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox CBCategorias;
        private Label LUsuarios;
        private System.Windows.Forms.DataVisualization.Charting.Chart CProducts;
        private Label label1;
    }
}