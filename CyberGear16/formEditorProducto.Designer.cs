namespace CyberGear16
{
    partial class formEditorProducto
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
            label1 = new Label();
            tbNombre = new TextBox();
            tbPrecio = new TextBox();
            tbStock = new TextBox();
            comboBoxCategorias = new ComboBox();
            tbDescrip = new TextBox();
            btnAplicar = new Button();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbStockMin = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 24);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Modificacion de Producto";
            label1.Click += label1_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(110, 66);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(167, 23);
            tbNombre.TabIndex = 1;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(110, 110);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(114, 23);
            tbPrecio.TabIndex = 2;
            // 
            // tbStock
            // 
            tbStock.Location = new Point(110, 153);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(114, 23);
            tbStock.TabIndex = 3;
            // 
            // comboBoxCategorias
            // 
            comboBoxCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategorias.FormattingEnabled = true;
            comboBoxCategorias.Location = new Point(110, 239);
            comboBoxCategorias.Name = "comboBoxCategorias";
            comboBoxCategorias.Size = new Size(167, 23);
            comboBoxCategorias.TabIndex = 12;
            // 
            // tbDescrip
            // 
            tbDescrip.Location = new Point(110, 282);
            tbDescrip.Multiline = true;
            tbDescrip.Name = "tbDescrip";
            tbDescrip.Size = new Size(174, 96);
            tbDescrip.TabIndex = 13;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(110, 409);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(174, 23);
            btnAplicar.TabIndex = 14;
            btnAplicar.Text = "Aplicar Cambios";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 68);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(24, 242);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 20;
            label6.Text = "categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(45, 156);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 19;
            label5.Text = "stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(40, 113);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 18;
            label4.Text = "precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 282);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 17;
            label3.Text = "descripcion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(3, 69);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 16;
            label7.Text = "nombre producto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(12, 197);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 23;
            label8.Text = "stock minimo";
            // 
            // tbStockMin
            // 
            tbStockMin.Location = new Point(110, 194);
            tbStockMin.Name = "tbStockMin";
            tbStockMin.Size = new Size(114, 23);
            tbStockMin.TabIndex = 22;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icon_dar_baja;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(324, 126);
            button1.Name = "button1";
            button1.Size = new Size(140, 45);
            button1.TabIndex = 25;
            button1.Text = "DAR DE BAJA";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.icon_dar_alta;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(324, 182);
            button2.Name = "button2";
            button2.Size = new Size(140, 45);
            button2.TabIndex = 26;
            button2.Text = "DAR DE ALTA";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.flecha_verde_retroceder;
            button3.Location = new Point(5, 400);
            button3.Name = "button3";
            button3.Size = new Size(75, 61);
            button3.TabIndex = 27;
            button3.Text = "Volver";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // formEditorProducto
            // 
            AcceptButton = button3;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 473);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(tbStockMin);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(btnAplicar);
            Controls.Add(tbDescrip);
            Controls.Add(comboBoxCategorias);
            Controls.Add(tbStock);
            Controls.Add(tbPrecio);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "formEditorProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNombre;
        private TextBox tbPrecio;
        private TextBox tbStock;
        private ComboBox comboBoxCategorias;
        private TextBox tbDescrip;
        private Button btnAplicar;

        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label8;
        private TextBox tbStockMin;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}