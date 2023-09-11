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
            Button btnBaja;
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBoxCategorias = new ComboBox();
            textBox4 = new TextBox();
            btnAplicar = new Button();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            btnBaja = new Button();
            SuspendLayout();
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(360, 184);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(89, 57);
            btnBaja.TabIndex = 21;
            btnBaja.Text = "DAR DE BAJA PRODUCTO";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
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
            // textBox1
            // 
            textBox1.Location = new Point(110, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 23);
            textBox3.TabIndex = 3;
            // 
            // comboBoxCategorias
            // 
            comboBoxCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategorias.FormattingEnabled = true;
            comboBoxCategorias.Location = new Point(110, 202);
            comboBoxCategorias.Name = "comboBoxCategorias";
            comboBoxCategorias.Size = new Size(167, 23);
            comboBoxCategorias.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(110, 244);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 96);
            textBox4.TabIndex = 13;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(110, 382);
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
            label6.Location = new Point(24, 205);
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
            label3.Location = new Point(12, 247);
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
            // formEditorProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 450);
            Controls.Add(btnBaja);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(btnAplicar);
            Controls.Add(textBox4);
            Controls.Add(comboBoxCategorias);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "formEditorProducto";
            Text = "Modificar Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBoxCategorias;
        private TextBox textBox4;
        private Button btnAplicar;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
    }
}