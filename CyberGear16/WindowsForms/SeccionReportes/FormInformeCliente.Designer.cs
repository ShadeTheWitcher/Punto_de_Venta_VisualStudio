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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            LComprasCat = new Label();
            LTextComprasCat = new Label();
            CProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            CBCategorias = new ComboBox();
            LComprasTot = new Label();
            LTextComprasTot = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CProducts).BeginInit();
            SuspendLayout();
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LApellido.ForeColor = Color.White;
            LApellido.Location = new Point(53, 108);
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
            LDni.Location = new Point(270, 56);
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
            LMNombre.Location = new Point(123, 56);
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
            LMTelefono.Location = new Point(580, 56);
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
            LTelefono.Location = new Point(496, 56);
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
            LMEmail.Location = new Point(354, 108);
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
            LEmail.Location = new Point(270, 108);
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
            LMDni.Location = new Point(354, 56);
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
            LMApellido.Location = new Point(123, 108);
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
            LNombre.Location = new Point(53, 56);
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
            LCantProduct.Location = new Point(138, 13);
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
            panel1.Size = new Size(776, 158);
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
            panel2.Controls.Add(label1);
            panel2.Controls.Add(LComprasCat);
            panel2.Controls.Add(LTextComprasCat);
            panel2.Controls.Add(CProducts);
            panel2.Controls.Add(CBCategorias);
            panel2.Controls.Add(LComprasTot);
            panel2.Controls.Add(LTextComprasTot);
            panel2.Controls.Add(LCantProduct);
            panel2.Location = new Point(12, 189);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 336);
            panel2.TabIndex = 29;
            // 
            // LComprasCat
            // 
            LComprasCat.AutoSize = true;
            LComprasCat.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LComprasCat.ForeColor = Color.White;
            LComprasCat.Location = new Point(610, 192);
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
            LTextComprasCat.Location = new Point(501, 160);
            LTextComprasCat.Name = "LTextComprasCat";
            LTextComprasCat.Size = new Size(230, 20);
            LTextComprasCat.TabIndex = 42;
            LTextComprasCat.Text = "Total de compras por categoría:";
            // 
            // CProducts
            // 
            CProducts.BackColor = Color.Transparent;
            chartArea3.BackColor = Color.Transparent;
            chartArea3.Name = "ChartArea1";
            CProducts.ChartAreas.Add(chartArea3);
            legend3.BackColor = Color.Transparent;
            legend3.ForeColor = Color.White;
            legend3.Name = "Legend1";
            legend3.TitleForeColor = Color.White;
            legend3.TitleSeparatorColor = Color.White;
            CProducts.Legends.Add(legend3);
            CProducts.Location = new Point(53, 50);
            CProducts.Name = "CProducts";
            CProducts.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            CProducts.Series.Add(series3);
            CProducts.Size = new Size(382, 245);
            CProducts.TabIndex = 41;
            CProducts.Text = "chart1";
            // 
            // CBCategorias
            // 
            CBCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCategorias.FormattingEnabled = true;
            CBCategorias.Location = new Point(534, 61);
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
            LComprasTot.Location = new Point(610, 265);
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
            LTextComprasTot.Location = new Point(517, 235);
            LTextComprasTot.Name = "LTextComprasTot";
            LTextComprasTot.Size = new Size(206, 20);
            LTextComprasTot.TabIndex = 35;
            LTextComprasTot.Text = "Total de compras realizadas:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(26, 32, 40);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(97, 298);
            label1.Name = "label1";
            label1.Size = new Size(256, 21);
            label1.TabIndex = 44;
            label1.Text = "Top 5 productos más comprados";
            // 
            // FormInformeCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 537);
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
        private Label label1;
    }
}