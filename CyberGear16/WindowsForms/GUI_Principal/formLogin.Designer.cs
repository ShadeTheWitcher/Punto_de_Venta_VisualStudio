namespace CyberGear16
{
    partial class formLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            panel1 = new Panel();
            BOcultar = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            bManual = new PictureBox();
            panelManual = new Panel();
            CerrarManual = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bManual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CerrarManual).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.fondoDegradadoMoradoRosa;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(BOcultar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(486, 222);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 376);
            panel1.TabIndex = 0;
            // 
            // BOcultar
            // 
            BOcultar.BackColor = Color.Transparent;
            BOcultar.FlatAppearance.BorderSize = 0;
            BOcultar.FlatStyle = FlatStyle.Flat;
            BOcultar.Image = (Image)resources.GetObject("BOcultar.Image");
            BOcultar.Location = new Point(268, 251);
            BOcultar.Name = "BOcultar";
            BOcultar.Size = new Size(33, 29);
            BOcultar.TabIndex = 31;
            BOcultar.UseVisualStyleBackColor = false;
            BOcultar.Click += BOcultar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(145, 45);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(155, 293);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(91, 27);
            button1.TabIndex = 4;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(145, 251);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(116, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 200);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 254);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 203);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(130, 256);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(222, 235);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // bManual
            // 
            bManual.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bManual.BackColor = Color.Transparent;
            bManual.Cursor = Cursors.Hand;
            bManual.Image = (Image)resources.GetObject("bManual.Image");
            bManual.Location = new Point(12, 664);
            bManual.Name = "bManual";
            bManual.Size = new Size(71, 73);
            bManual.SizeMode = PictureBoxSizeMode.StretchImage;
            bManual.TabIndex = 2;
            bManual.TabStop = false;
            bManual.Click += pictureBox3_Click;
            // 
            // panelManual
            // 
            panelManual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelManual.Location = new Point(119, 1);
            panelManual.Name = "panelManual";
            panelManual.Size = new Size(1052, 748);
            panelManual.TabIndex = 3;
            panelManual.Visible = false;
            // 
            // CerrarManual
            // 
            CerrarManual.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CerrarManual.BackColor = Color.Transparent;
            CerrarManual.Image = (Image)resources.GetObject("CerrarManual.Image");
            CerrarManual.Location = new Point(12, 568);
            CerrarManual.Name = "CerrarManual";
            CerrarManual.Size = new Size(71, 68);
            CerrarManual.SizeMode = PictureBoxSizeMode.StretchImage;
            CerrarManual.TabIndex = 4;
            CerrarManual.TabStop = false;
            CerrarManual.Visible = false;
            CerrarManual.Click += pictureBox3_Click_1;
            // 
            // formLogin
            // 
            AcceptButton = button1;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._1092728;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1364, 749);
            Controls.Add(CerrarManual);
            Controls.Add(panelManual);
            Controls.Add(bManual);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio Sesión";
            WindowState = FormWindowState.Maximized;
            Load += formLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bManual).EndInit();
            ((System.ComponentModel.ISupportInitialize)CerrarManual).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button BOcultar;
        private PictureBox bManual;
        private Panel panelManual;
        private PictureBox CerrarManual;
    }
}