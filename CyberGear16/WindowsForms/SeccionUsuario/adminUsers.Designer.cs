﻿namespace CyberGear16
{
    partial class adminUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminUsers));
            PUsuarios = new Panel();
            BOcultar = new Button();
            TCodPostal = new TextBox();
            LCodPostal = new Label();
            DTPicker = new DateTimePicker();
            BCancelar = new Button();
            BGuardar = new Button();
            CBPerfil = new ComboBox();
            RBMujer = new RadioButton();
            RBHombre = new RadioButton();
            TTelefono = new TextBox();
            TDireccion = new TextBox();
            TDni = new TextBox();
            TEmail = new TextBox();
            TContraseña = new TextBox();
            TUsuario = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            LSexo = new Label();
            LEmail = new Label();
            LPerfil = new Label();
            LFechaNac = new Label();
            LDni = new Label();
            LDireccion = new Label();
            LContraseña = new Label();
            LTelefono = new Label();
            LUsuario = new Label();
            LApellido = new Label();
            LNombre = new Label();
            LUsuarios = new Label();
            DGVUsuarios = new DataGridView();
            BActivos = new Button();
            BInactivo = new Button();
            TBuscar = new TextBox();
            BBuscar = new Button();
            BBorrar = new Button();
            PUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).BeginInit();
            SuspendLayout();
            // 
            // PUsuarios
            // 
            PUsuarios.Anchor = AnchorStyles.None;
            PUsuarios.BackColor = Color.FromArgb(26, 32, 40);
            PUsuarios.Controls.Add(BOcultar);
            PUsuarios.Controls.Add(TCodPostal);
            PUsuarios.Controls.Add(LCodPostal);
            PUsuarios.Controls.Add(DTPicker);
            PUsuarios.Controls.Add(BCancelar);
            PUsuarios.Controls.Add(BGuardar);
            PUsuarios.Controls.Add(CBPerfil);
            PUsuarios.Controls.Add(RBMujer);
            PUsuarios.Controls.Add(RBHombre);
            PUsuarios.Controls.Add(TTelefono);
            PUsuarios.Controls.Add(TDireccion);
            PUsuarios.Controls.Add(TDni);
            PUsuarios.Controls.Add(TEmail);
            PUsuarios.Controls.Add(TContraseña);
            PUsuarios.Controls.Add(TUsuario);
            PUsuarios.Controls.Add(TApellido);
            PUsuarios.Controls.Add(TNombre);
            PUsuarios.Controls.Add(LSexo);
            PUsuarios.Controls.Add(LEmail);
            PUsuarios.Controls.Add(LPerfil);
            PUsuarios.Controls.Add(LFechaNac);
            PUsuarios.Controls.Add(LDni);
            PUsuarios.Controls.Add(LDireccion);
            PUsuarios.Controls.Add(LContraseña);
            PUsuarios.Controls.Add(LTelefono);
            PUsuarios.Controls.Add(LUsuario);
            PUsuarios.Controls.Add(LApellido);
            PUsuarios.Controls.Add(LNombre);
            PUsuarios.Controls.Add(LUsuarios);
            PUsuarios.Location = new Point(44, 12);
            PUsuarios.Name = "PUsuarios";
            PUsuarios.Size = new Size(982, 325);
            PUsuarios.TabIndex = 0;
            PUsuarios.Paint += PUsuarios_Paint;
            // 
            // BOcultar
            // 
            BOcultar.BackColor = Color.FromArgb(26, 32, 40);
            BOcultar.FlatAppearance.BorderSize = 0;
            BOcultar.FlatStyle = FlatStyle.Flat;
            BOcultar.Image = (Image)resources.GetObject("BOcultar.Image");
            BOcultar.Location = new Point(288, 158);
            BOcultar.Name = "BOcultar";
            BOcultar.Size = new Size(33, 29);
            BOcultar.TabIndex = 30;
            BOcultar.UseVisualStyleBackColor = false;
            BOcultar.Click += BOcultar_Click;
            // 
            // TCodPostal
            // 
            TCodPostal.Location = new Point(490, 129);
            TCodPostal.Name = "TCodPostal";
            TCodPostal.Size = new Size(170, 23);
            TCodPostal.TabIndex = 29;
            TCodPostal.TextChanged += TCodPostal_TextChanged;
            // 
            // LCodPostal
            // 
            LCodPostal.AutoSize = true;
            LCodPostal.ForeColor = Color.White;
            LCodPostal.Location = new Point(356, 127);
            LCodPostal.Name = "LCodPostal";
            LCodPostal.Size = new Size(123, 15);
            LCodPostal.TabIndex = 28;
            LCodPostal.Text = "Número de Dirección:";
            LCodPostal.Click += LCodPostal_Click;
            // 
            // DTPicker
            // 
            DTPicker.Format = DateTimePickerFormat.Short;
            DTPicker.Location = new Point(490, 158);
            DTPicker.Name = "DTPicker";
            DTPicker.Size = new Size(170, 23);
            DTPicker.TabIndex = 27;
            // 
            // BCancelar
            // 
            BCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BCancelar.Image = Properties.Resources.borrar;
            BCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BCancelar.Location = new Point(744, 155);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(137, 70);
            BCancelar.TabIndex = 26;
            BCancelar.Text = "Cancelar";
            BCancelar.TextAlign = ContentAlignment.MiddleRight;
            BCancelar.UseVisualStyleBackColor = true;
            BCancelar.Click += BCancelar_Click;
            // 
            // BGuardar
            // 
            BGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BGuardar.ForeColor = SystemColors.ControlText;
            BGuardar.Image = (Image)resources.GetObject("BGuardar.Image");
            BGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BGuardar.Location = new Point(744, 54);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(137, 68);
            BGuardar.TabIndex = 25;
            BGuardar.Text = "Guardar";
            BGuardar.TextAlign = ContentAlignment.MiddleRight;
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // CBPerfil
            // 
            CBPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            CBPerfil.FormattingEnabled = true;
            CBPerfil.Location = new Point(112, 216);
            CBPerfil.Name = "CBPerfil";
            CBPerfil.Size = new Size(170, 23);
            CBPerfil.TabIndex = 24;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.ForeColor = Color.White;
            RBMujer.Location = new Point(598, 223);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(56, 19);
            RBMujer.TabIndex = 23;
            RBMujer.TabStop = true;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            // 
            // RBHombre
            // 
            RBHombre.AutoSize = true;
            RBHombre.ForeColor = Color.White;
            RBHombre.Location = new Point(501, 218);
            RBHombre.Name = "RBHombre";
            RBHombre.Size = new Size(69, 19);
            RBHombre.TabIndex = 22;
            RBHombre.TabStop = true;
            RBHombre.Text = "Hombre";
            RBHombre.UseVisualStyleBackColor = true;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(490, 187);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(170, 23);
            TTelefono.TabIndex = 21;
            // 
            // TDireccion
            // 
            TDireccion.Location = new Point(490, 99);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(170, 23);
            TDireccion.TabIndex = 19;
            // 
            // TDni
            // 
            TDni.Location = new Point(490, 70);
            TDni.Name = "TDni";
            TDni.Size = new Size(170, 23);
            TDni.TabIndex = 18;
            // 
            // TEmail
            // 
            TEmail.Location = new Point(112, 187);
            TEmail.Name = "TEmail";
            TEmail.Size = new Size(170, 23);
            TEmail.TabIndex = 16;
            // 
            // TContraseña
            // 
            TContraseña.BackColor = SystemColors.Window;
            TContraseña.ForeColor = SystemColors.WindowText;
            TContraseña.Location = new Point(112, 158);
            TContraseña.Name = "TContraseña";
            TContraseña.PasswordChar = '*';
            TContraseña.Size = new Size(170, 23);
            TContraseña.TabIndex = 15;
            // 
            // TUsuario
            // 
            TUsuario.Location = new Point(112, 128);
            TUsuario.Name = "TUsuario";
            TUsuario.Size = new Size(170, 23);
            TUsuario.TabIndex = 14;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(112, 99);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(170, 23);
            TApellido.TabIndex = 13;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(112, 70);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(170, 23);
            TNombre.TabIndex = 12;
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.ForeColor = Color.White;
            LSexo.Location = new Point(356, 219);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(35, 15);
            LSexo.TabIndex = 11;
            LSexo.Text = "Sexo:";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.ForeColor = Color.White;
            LEmail.Location = new Point(37, 190);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(39, 15);
            LEmail.TabIndex = 10;
            LEmail.Text = "Email:";
            // 
            // LPerfil
            // 
            LPerfil.AutoSize = true;
            LPerfil.ForeColor = Color.White;
            LPerfil.Location = new Point(39, 216);
            LPerfil.Name = "LPerfil";
            LPerfil.Size = new Size(37, 15);
            LPerfil.TabIndex = 9;
            LPerfil.Text = "Perfil:";
            LPerfil.Click += label5_Click_1;
            // 
            // LFechaNac
            // 
            LFechaNac.AutoSize = true;
            LFechaNac.ForeColor = Color.White;
            LFechaNac.Location = new Point(356, 155);
            LFechaNac.Name = "LFechaNac";
            LFechaNac.Size = new Size(122, 15);
            LFechaNac.TabIndex = 8;
            LFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.ForeColor = Color.White;
            LDni.Location = new Point(356, 73);
            LDni.Name = "LDni";
            LDni.Size = new Size(28, 15);
            LDni.TabIndex = 7;
            LDni.Text = "Dni:";
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.ForeColor = Color.White;
            LDireccion.Location = new Point(356, 102);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(60, 15);
            LDireccion.TabIndex = 6;
            LDireccion.Text = "Dirección:";
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.ForeColor = Color.White;
            LContraseña.Location = new Point(36, 161);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(70, 15);
            LContraseña.TabIndex = 5;
            LContraseña.Text = "Contraseña:";
            LContraseña.Click += label5_Click;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.ForeColor = Color.White;
            LTelefono.Location = new Point(356, 185);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(55, 15);
            LTelefono.TabIndex = 4;
            LTelefono.Text = "Telefono:";
            // 
            // LUsuario
            // 
            LUsuario.AutoSize = true;
            LUsuario.ForeColor = Color.White;
            LUsuario.Location = new Point(36, 131);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(50, 15);
            LUsuario.TabIndex = 3;
            LUsuario.Text = "Usuario:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.ForeColor = Color.White;
            LApellido.Location = new Point(36, 102);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(54, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido:";
            LApellido.Click += LApellido_Click;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.ForeColor = Color.White;
            LNombre.Location = new Point(37, 73);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(54, 15);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre:";
            LNombre.Click += label1_Click;
            // 
            // LUsuarios
            // 
            LUsuarios.AutoSize = true;
            LUsuarios.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LUsuarios.ForeColor = Color.White;
            LUsuarios.Location = new Point(24, 15);
            LUsuarios.Name = "LUsuarios";
            LUsuarios.Size = new Size(103, 30);
            LUsuarios.TabIndex = 0;
            LUsuarios.Text = "Usuarios:";
            LUsuarios.Click += LUsuarios_Click;
            // 
            // DGVUsuarios
            // 
            DGVUsuarios.Anchor = AnchorStyles.None;
            DGVUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUsuarios.Location = new Point(44, 395);
            DGVUsuarios.Name = "DGVUsuarios";
            DGVUsuarios.RowTemplate.Height = 25;
            DGVUsuarios.Size = new Size(982, 213);
            DGVUsuarios.TabIndex = 1;
            DGVUsuarios.CellContentClick += DGVUsuarios_CellContentClick;
            // 
            // BActivos
            // 
            BActivos.Anchor = AnchorStyles.None;
            BActivos.Location = new Point(44, 357);
            BActivos.Name = "BActivos";
            BActivos.Size = new Size(113, 28);
            BActivos.TabIndex = 2;
            BActivos.Text = "Activos";
            BActivos.UseVisualStyleBackColor = true;
            BActivos.Click += BActivos_Click;
            // 
            // BInactivo
            // 
            BInactivo.Anchor = AnchorStyles.None;
            BInactivo.Location = new Point(182, 357);
            BInactivo.Name = "BInactivo";
            BInactivo.Size = new Size(113, 28);
            BInactivo.TabIndex = 3;
            BInactivo.Text = "Inactivos";
            BInactivo.UseVisualStyleBackColor = true;
            BInactivo.Click += BInactivos_Click;
            // 
            // TBuscar
            // 
            TBuscar.Anchor = AnchorStyles.None;
            TBuscar.Location = new Point(626, 361);
            TBuscar.Name = "TBuscar";
            TBuscar.Size = new Size(313, 23);
            TBuscar.TabIndex = 4;
            TBuscar.Text = "Buscar";
            TBuscar.Click += TBuscar_Click;
            TBuscar.TextChanged += TBuscar_TextChanged;
            TBuscar.KeyPress += TBuscar_KeyPress;
            // 
            // BBuscar
            // 
            BBuscar.Anchor = AnchorStyles.None;
            BBuscar.Image = Properties.Resources.lupa;
            BBuscar.Location = new Point(945, 352);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(38, 37);
            BBuscar.TabIndex = 5;
            BBuscar.UseVisualStyleBackColor = true;
            BBuscar.Click += BBuscar_Click;
            // 
            // BBorrar
            // 
            BBorrar.Anchor = AnchorStyles.None;
            BBorrar.Image = (Image)resources.GetObject("BBorrar.Image");
            BBorrar.Location = new Point(989, 352);
            BBorrar.Name = "BBorrar";
            BBorrar.Size = new Size(38, 37);
            BBorrar.TabIndex = 6;
            BBorrar.UseVisualStyleBackColor = true;
            BBorrar.Click += BBorrar_Click;
            // 
            // adminUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 629);
            Controls.Add(BBorrar);
            Controls.Add(BBuscar);
            Controls.Add(TBuscar);
            Controls.Add(BInactivo);
            Controls.Add(BActivos);
            Controls.Add(DGVUsuarios);
            Controls.Add(PUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminUsers";
            Text = "Form1";
            Load += adminUsers_Load;
            PUsuarios.ResumeLayout(false);
            PUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PUsuarios;
        private Label LUsuarios;
        private Label LContraseña;
        private Label LTelefono;
        private Label LUsuario;
        private Label LApellido;
        private Label LNombre;
        private Label LEmail;
        private Label LPerfil;
        private Label LFechaNac;
        private Label LDni;
        private Label LDireccion;
        private Label LSexo;
        private TextBox TUsuario;
        private TextBox TApellido;
        private TextBox TNombre;
        private TextBox TEmail;
        private TextBox TContraseña;
        private RadioButton RBHombre;
        private TextBox TTelefono;
        private TextBox TDireccion;
        private TextBox TDni;
        private RadioButton RBMujer;
        private ComboBox CBPerfil;
        private Button BCancelar;
        private Button BGuardar;
        private DateTimePicker DTPicker;
        private DataGridView DGVUsuarios;
        private Button BActivos;
        private Button BInactivo;
        private TextBox TCodPostal;
        private Label LCodPostal;
        private TextBox TBuscar;
        private Button BBuscar;
        private Button BBorrar;
        private Button BOcultar;
    }
}