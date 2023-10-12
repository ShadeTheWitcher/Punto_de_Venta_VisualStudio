namespace CyberGear16.WindowsForms.Seccion_Catalogo
{
    partial class FormCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCatalogo));
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            cbFiltroCategorias = new ComboBox();
            pictureBox2 = new PictureBox();
            textBoxBusqueda = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(470, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 30);
            label1.TabIndex = 1;
            label1.Text = "Catalogo";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 19, 27);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbFiltroCategorias);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(textBoxBusqueda);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1159, 695);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(684, 56);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 5;
            label3.Text = "Categorias";
            // 
            // cbFiltroCategorias
            // 
            cbFiltroCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbFiltroCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltroCategorias.FormattingEnabled = true;
            cbFiltroCategorias.Location = new Point(753, 53);
            cbFiltroCategorias.Name = "cbFiltroCategorias";
            cbFiltroCategorias.Size = new Size(146, 23);
            cbFiltroCategorias.TabIndex = 4;
            cbFiltroCategorias.SelectedIndexChanged += cbFiltroCategorias_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1099, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // textBoxBusqueda
            // 
            textBoxBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxBusqueda.Location = new Point(938, 53);
            textBoxBusqueda.Name = "textBoxBusqueda";
            textBoxBusqueda.Size = new Size(155, 23);
            textBoxBusqueda.TabIndex = 2;
            textBoxBusqueda.TextChanged += textBoxBusqueda_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(32, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(89, 32);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(52, 3);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 1;
            label2.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.venta;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.ForeColor = Color.Black;
            flowLayoutPanel1.Location = new Point(32, 87);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1098, 586);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1159, 42);
            panel2.TabIndex = 4;
            // 
            // FormCatalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 695);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCatalogo";
            Text = "FormCatalogo";
            Load += FormCatalogo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBoxBusqueda;
        private PictureBox pictureBox2;
        private Label label3;
        private ComboBox cbFiltroCategorias;
    }
}