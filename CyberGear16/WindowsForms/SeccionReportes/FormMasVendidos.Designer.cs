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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            CBCategorias = new ComboBox();
            LUsuarios = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            LMeses = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(LMeses);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(CBCategorias);
            panel1.Controls.Add(LUsuarios);
            panel1.Location = new Point(29, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(759, 506);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gráfico;
            pictureBox1.Location = new Point(224, 238);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 230);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // CBCategorias
            // 
            CBCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCategorias.FormattingEnabled = true;
            CBCategorias.Location = new Point(580, 108);
            CBCategorias.Name = "CBCategorias";
            CBCategorias.Size = new Size(166, 23);
            CBCategorias.TabIndex = 3;
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Tabla;
            pictureBox2.Location = new Point(168, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(406, 122);
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(120, 333);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 37;
            label3.Text = "Ventas Realizadas";
            // 
            // LMeses
            // 
            LMeses.AutoSize = true;
            LMeses.ForeColor = Color.White;
            LMeses.Location = new Point(322, 471);
            LMeses.Name = "LMeses";
            LMeses.Size = new Size(118, 15);
            LMeses.TabIndex = 38;
            LMeses.Text = "Meses del Año (1-12)";
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox CBCategorias;
        private Label LUsuarios;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label LMeses;
    }
}