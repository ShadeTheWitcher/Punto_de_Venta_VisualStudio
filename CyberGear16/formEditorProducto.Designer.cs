﻿namespace CyberGear16
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
            LCategoria = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            LStockMin = new Label();
            tbStockMin = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            PStockMin = new Panel();
            label8 = new Label();
            label6 = new Label();
            PStockMin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(106, 19);
            label1.Name = "label1";
            label1.Size = new Size(260, 25);
            label1.TabIndex = 0;
            label1.Text = "Modificacion de Producto";
            label1.Click += label1_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(214, 78);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(174, 23);
            tbNombre.TabIndex = 1;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(214, 122);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(174, 23);
            tbPrecio.TabIndex = 2;
            // 
            // tbStock
            // 
            tbStock.Location = new Point(214, 165);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(174, 23);
            tbStock.TabIndex = 3;
            // 
            // comboBoxCategorias
            // 
            comboBoxCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategorias.FormattingEnabled = true;
            comboBoxCategorias.Location = new Point(214, 254);
            comboBoxCategorias.Name = "comboBoxCategorias";
            comboBoxCategorias.Size = new Size(167, 23);
            comboBoxCategorias.TabIndex = 12;
            comboBoxCategorias.SelectedIndexChanged += comboBoxCategorias_SelectedIndexChanged;
            // 
            // tbDescrip
            // 
            tbDescrip.Location = new Point(214, 294);
            tbDescrip.Multiline = true;
            tbDescrip.Name = "tbDescrip";
            tbDescrip.Size = new Size(174, 96);
            tbDescrip.TabIndex = 13;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(156, 419);
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
            label2.Location = new Point(101, 81);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 15;
            // 
            // LCategoria
            // 
            LCategoria.AutoSize = true;
            LCategoria.BackColor = Color.Black;
            LCategoria.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LCategoria.ForeColor = Color.Transparent;
            LCategoria.Location = new Point(46, 254);
            LCategoria.Name = "LCategoria";
            LCategoria.Size = new Size(77, 20);
            LCategoria.TabIndex = 20;
            LCategoria.Text = "Categoría:";
            LCategoria.Click += LCategoria_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(46, 168);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 19;
            label5.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(46, 122);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 18;
            label4.Text = "Precio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(45, 81);
            label7.Name = "label7";
            label7.Size = new Size(163, 20);
            label7.TabIndex = 16;
            label7.Text = "Nombre del Producto:";
            // 
            // LStockMin
            // 
            LStockMin.AutoSize = true;
            LStockMin.BackColor = Color.Transparent;
            LStockMin.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LStockMin.ForeColor = SystemColors.ActiveCaptionText;
            LStockMin.Location = new Point(19, 28);
            LStockMin.Name = "LStockMin";
            LStockMin.Size = new Size(110, 20);
            LStockMin.TabIndex = 23;
            LStockMin.Text = "Stock Mínimo:";
            LStockMin.Click += LStockMin_Click;
            // 
            // tbStockMin
            // 
            tbStockMin.Location = new Point(214, 206);
            tbStockMin.Name = "tbStockMin";
            tbStockMin.Size = new Size(174, 23);
            tbStockMin.TabIndex = 22;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icon_dar_baja;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(171, 457);
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
            button2.Location = new Point(171, 457);
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
            button3.Location = new Point(24, 485);
            button3.Name = "button3";
            button3.Size = new Size(75, 62);
            button3.TabIndex = 27;
            button3.Text = "Volver";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // PStockMin
            // 
            PStockMin.BackColor = Color.Black;
            PStockMin.BackgroundImage = Properties.Resources.JoystickMorado;
            PStockMin.Controls.Add(label8);
            PStockMin.Controls.Add(label6);
            PStockMin.Controls.Add(LStockMin);
            PStockMin.Location = new Point(3, -23);
            PStockMin.Name = "PStockMin";
            PStockMin.Size = new Size(575, 586);
            PStockMin.TabIndex = 61;
            PStockMin.Paint += PStockMin_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(42, 317);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 63;
            label8.Text = "Descripción:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(42, 232);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 62;
            label6.Text = "Stock Mínimo:";
            // 
            // formEditorProducto
            // 
            AcceptButton = button3;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 559);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbStockMin);
            Controls.Add(LCategoria);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(btnAplicar);
            Controls.Add(tbDescrip);
            Controls.Add(comboBoxCategorias);
            Controls.Add(tbStock);
            Controls.Add(tbPrecio);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            Controls.Add(PStockMin);
            MaximizeBox = false;
            Name = "formEditorProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Producto";
            Load += formEditorProducto_Load;
            PStockMin.ResumeLayout(false);
            PStockMin.PerformLayout();
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
        private Label LCategoria;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label LStockMin;
        private TextBox tbStockMin;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel PStockMin;
        private Label label8;
        private Label label6;
    }
}