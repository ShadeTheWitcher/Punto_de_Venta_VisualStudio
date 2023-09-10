namespace CyberGear16
{
    partial class GUI_Principal
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
            btnClientes = new Button();
            button1 = new Button();
            btnVentas = new Button();
            btnProductos = new Button();
            CabeceraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMax = new PictureBox();
            btnMin = new PictureBox();
            btnSalir = new PictureBox();
            panel2 = new Panel();
            LTipoUser = new Label();
            LNomUser = new Label();
            btnCerrarSesion = new PictureBox();
            botonSalir = new PictureBox();
            panel6 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            btnUsuarios = new Button();
            panelContenedor = new Panel();
            CabeceraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)botonSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.WhiteSmoke;
            btnClientes.Image = Properties.Resources.clientes;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(4, 399);
            btnClientes.Margin = new Padding(4, 3, 4, 3);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(290, 40);
            btnClientes.TabIndex = 10;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.reportes;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(4, 472);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(290, 40);
            button1.TabIndex = 8;
            button1.Text = "Reportes";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.White;
            btnVentas.Image = Properties.Resources.venta;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(4, 332);
            btnVentas.Margin = new Padding(4, 3, 4, 3);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(290, 40);
            btnVentas.TabIndex = 6;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = Properties.Resources.producto;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(4, 204);
            btnProductos.Margin = new Padding(4, 3, 4, 3);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(290, 40);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += button1_Click;
            // 
            // CabeceraTitulo
            // 
            CabeceraTitulo.BackColor = SystemColors.Highlight;
            CabeceraTitulo.Controls.Add(btnRestaurar);
            CabeceraTitulo.Controls.Add(btnMax);
            CabeceraTitulo.Controls.Add(btnMin);
            CabeceraTitulo.Controls.Add(btnSalir);
            CabeceraTitulo.Dock = DockStyle.Top;
            CabeceraTitulo.ForeColor = SystemColors.HotTrack;
            CabeceraTitulo.Location = new Point(0, 0);
            CabeceraTitulo.Margin = new Padding(4, 3, 4, 3);
            CabeceraTitulo.Name = "CabeceraTitulo";
            CabeceraTitulo.Size = new Size(1517, 46);
            CabeceraTitulo.TabIndex = 0;
            CabeceraTitulo.MouseDown += CabeceraTitulo_MouseDown;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = Properties.Resources.res;
            btnRestaurar.InitialImage = null;
            btnRestaurar.Location = new Point(1435, 10);
            btnRestaurar.Margin = new Padding(4, 3, 4, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(29, 29);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 2;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.Cursor = Cursors.Hand;
            btnMax.Image = Properties.Resources.icono_max;
            btnMax.InitialImage = null;
            btnMax.Location = new Point(1435, 10);
            btnMax.Margin = new Padding(4, 3, 4, 3);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(29, 29);
            btnMax.SizeMode = PictureBoxSizeMode.Zoom;
            btnMax.TabIndex = 2;
            btnMax.TabStop = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.Cursor = Cursors.Hand;
            btnMin.Image = Properties.Resources.icono_min;
            btnMin.InitialImage = null;
            btnMin.Location = new Point(1388, 10);
            btnMin.Margin = new Padding(4, 3, 4, 3);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(29, 29);
            btnMin.SizeMode = PictureBoxSizeMode.Zoom;
            btnMin.TabIndex = 1;
            btnMin.TabStop = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Image = Properties.Resources.cerrar;
            btnSalir.InitialImage = null;
            btnSalir.Location = new Point(1484, 10);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(29, 29);
            btnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnSalir.TabIndex = 0;
            btnSalir.TabStop = false;
            btnSalir.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 32, 40);
            panel2.Controls.Add(LTipoUser);
            panel2.Controls.Add(LNomUser);
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Controls.Add(botonSalir);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(btnClientes);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btnVentas);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btnUsuarios);
            panel2.Controls.Add(btnProductos);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 46);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 704);
            panel2.TabIndex = 1;
            // 
            // LTipoUser
            // 
            LTipoUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LTipoUser.AutoSize = true;
            LTipoUser.BackColor = Color.Transparent;
            LTipoUser.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LTipoUser.ForeColor = Color.LightGreen;
            LTipoUser.Location = new Point(191, 680);
            LTipoUser.Name = "LTipoUser";
            LTipoUser.Size = new Size(65, 15);
            LTipoUser.TabIndex = 14;
            LTipoUser.Text = "TipoUser";
            LTipoUser.Click += label1_Click;
            // 
            // LNomUser
            // 
            LNomUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LNomUser.AutoSize = true;
            LNomUser.BackColor = Color.Transparent;
            LNomUser.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LNomUser.ForeColor = SystemColors.ButtonHighlight;
            LNomUser.Location = new Point(191, 654);
            LNomUser.Name = "LNomUser";
            LNomUser.Size = new Size(86, 15);
            LNomUser.TabIndex = 13;
            LNomUser.Text = "NombreUser";
            LNomUser.Click += LNomUser_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Image = Properties.Resources._4043198;
            btnCerrarSesion.Location = new Point(104, 638);
            btnCerrarSesion.Margin = new Padding(4, 3, 4, 3);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(70, 52);
            btnCerrarSesion.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrarSesion.TabIndex = 12;
            btnCerrarSesion.TabStop = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // botonSalir
            // 
            botonSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            botonSalir.Cursor = Cursors.Hand;
            botonSalir.Image = Properties.Resources.salir;
            botonSalir.Location = new Point(0, 622);
            botonSalir.Margin = new Padding(4, 3, 4, 3);
            botonSalir.Name = "botonSalir";
            botonSalir.Size = new Size(96, 78);
            botonSalir.SizeMode = PictureBoxSizeMode.Zoom;
            botonSalir.TabIndex = 11;
            botonSalir.TabStop = false;
            botonSalir.Click += botonSalir_Click;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Highlight;
            panel6.Location = new Point(0, 399);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(12, 40);
            panel6.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Location = new Point(0, 472);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(12, 40);
            panel3.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Location = new Point(0, 332);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(12, 40);
            panel1.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.Location = new Point(0, 272);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(12, 37);
            panel5.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._7be5f80bdd244197bed72c7c0f28e283;
            pictureBox1.Location = new Point(44, 38);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Highlight;
            panel4.Location = new Point(0, 204);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(12, 40);
            panel4.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.ForeColor = SystemColors.Control;
            btnUsuarios.Image = Properties.Resources.clientes;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(4, 272);
            btnUsuarios.Margin = new Padding(4, 3, 4, 3);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(290, 37);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += button2_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(294, 46);
            panelContenedor.Margin = new Padding(4, 3, 4, 3);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1223, 704);
            panelContenedor.TabIndex = 2;
            // 
            // GUI_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 750);
            Controls.Add(panelContenedor);
            Controls.Add(panel2);
            Controls.Add(CabeceraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "GUI_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            CabeceraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)botonSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel CabeceraTitulo;
        private PictureBox btnSalir;
        private Panel panel2;
        private Panel panelContenedor;
        private PictureBox btnMin;
        private PictureBox btnMax;
        private PictureBox btnRestaurar;
        private Button btnUsuarios;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Panel panel1;
        private Panel panel3;
        private Panel panel6;
        private PictureBox botonSalir;
        private PictureBox btnCerrarSesion;
        private Button btnClientes;
        private Button button1;
        private Button btnVentas;
        private Button btnProductos;
        private Label LNomUser;
        private Label LTipoUser;
    }
}