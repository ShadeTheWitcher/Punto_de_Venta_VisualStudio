﻿namespace CyberGear16
{
    partial class FormEditorUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditorUsuario));
            DTPicker = new DateTimePicker();
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
            LModificar = new Label();
            BModificar = new Button();
            BAlta = new Button();
            BBaja = new Button();
            button3 = new Button();
            TCodPostal = new TextBox();
            LCodPostal = new Label();
            BOcultar = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DTPicker
            // 
            DTPicker.Format = DateTimePickerFormat.Short;
            DTPicker.Location = new Point(243, 336);
            DTPicker.Name = "DTPicker";
            DTPicker.Size = new Size(170, 23);
            DTPicker.TabIndex = 50;
            // 
            // CBPerfil
            // 
            CBPerfil.FormattingEnabled = true;
            CBPerfil.Location = new Point(243, 220);
            CBPerfil.Name = "CBPerfil";
            CBPerfil.Size = new Size(170, 23);
            CBPerfil.TabIndex = 49;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RBMujer.ForeColor = Color.White;
            RBMujer.Location = new Point(346, 398);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(66, 24);
            RBMujer.TabIndex = 48;
            RBMujer.TabStop = true;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            // 
            // RBHombre
            // 
            RBHombre.AutoSize = true;
            RBHombre.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RBHombre.ForeColor = Color.White;
            RBHombre.Location = new Point(249, 398);
            RBHombre.Name = "RBHombre";
            RBHombre.Size = new Size(80, 24);
            RBHombre.TabIndex = 47;
            RBHombre.TabStop = true;
            RBHombre.Text = "Hombre";
            RBHombre.UseVisualStyleBackColor = true;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(243, 365);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(170, 23);
            TTelefono.TabIndex = 46;
            // 
            // TDireccion
            // 
            TDireccion.Location = new Point(243, 278);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(170, 23);
            TDireccion.TabIndex = 45;
            // 
            // TDni
            // 
            TDni.Location = new Point(243, 249);
            TDni.Name = "TDni";
            TDni.Size = new Size(170, 23);
            TDni.TabIndex = 44;
            // 
            // TEmail
            // 
            TEmail.Location = new Point(243, 191);
            TEmail.Name = "TEmail";
            TEmail.Size = new Size(170, 23);
            TEmail.TabIndex = 43;
            // 
            // TContraseña
            // 
            TContraseña.Location = new Point(243, 162);
            TContraseña.Name = "TContraseña";
            TContraseña.PasswordChar = '*';
            TContraseña.Size = new Size(170, 23);
            TContraseña.TabIndex = 42;
            // 
            // TUsuario
            // 
            TUsuario.Location = new Point(243, 132);
            TUsuario.Name = "TUsuario";
            TUsuario.Size = new Size(170, 23);
            TUsuario.TabIndex = 41;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(243, 103);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(170, 23);
            TApellido.TabIndex = 40;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(243, 74);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(170, 23);
            TNombre.TabIndex = 39;
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LSexo.ForeColor = Color.White;
            LSexo.Location = new Point(72, 400);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(45, 20);
            LSexo.TabIndex = 38;
            LSexo.Text = "Sexo:";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LEmail.ForeColor = Color.White;
            LEmail.Location = new Point(72, 190);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(51, 20);
            LEmail.TabIndex = 37;
            LEmail.Text = "Email:";
            // 
            // LPerfil
            // 
            LPerfil.AutoSize = true;
            LPerfil.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LPerfil.ForeColor = Color.White;
            LPerfil.Location = new Point(71, 223);
            LPerfil.Name = "LPerfil";
            LPerfil.Size = new Size(51, 20);
            LPerfil.TabIndex = 36;
            LPerfil.Text = "Perfil:";
            // 
            // LFechaNac
            // 
            LFechaNac.AutoSize = true;
            LFechaNac.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LFechaNac.ForeColor = Color.White;
            LFechaNac.Location = new Point(71, 338);
            LFechaNac.Name = "LFechaNac";
            LFechaNac.Size = new Size(156, 20);
            LFechaNac.TabIndex = 35;
            LFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.ForeColor = Color.White;
            LDni.Location = new Point(72, 252);
            LDni.Name = "LDni";
            LDni.Size = new Size(36, 20);
            LDni.TabIndex = 34;
            LDni.Text = "Dni:";
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LDireccion.ForeColor = Color.White;
            LDireccion.Location = new Point(71, 281);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(73, 20);
            LDireccion.TabIndex = 33;
            LDireccion.Text = "Dirección:";
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LContraseña.ForeColor = Color.White;
            LContraseña.Location = new Point(71, 161);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(88, 20);
            LContraseña.TabIndex = 32;
            LContraseña.Text = "Contraseña:";
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LTelefono.ForeColor = Color.White;
            LTelefono.Location = new Point(72, 368);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(72, 20);
            LTelefono.TabIndex = 31;
            LTelefono.Text = "Telefono:";
            // 
            // LUsuario
            // 
            LUsuario.AutoSize = true;
            LUsuario.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LUsuario.ForeColor = Color.White;
            LUsuario.Location = new Point(71, 131);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(64, 20);
            LUsuario.TabIndex = 30;
            LUsuario.Text = "Usuario:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.ForeColor = Color.White;
            LApellido.Location = new Point(71, 102);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(67, 20);
            LApellido.TabIndex = 29;
            LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.ForeColor = Color.White;
            LNombre.Location = new Point(72, 73);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(68, 20);
            LNombre.TabIndex = 28;
            LNombre.Text = "Nombre:";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LModificar.ForeColor = Color.White;
            LModificar.Location = new Point(159, 22);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(183, 25);
            LModificar.TabIndex = 51;
            LModificar.Text = "Modificar Usuario";
            // 
            // BModificar
            // 
            BModificar.Image = Properties.Resources.actualizar;
            BModificar.ImageAlign = ContentAlignment.MiddleLeft;
            BModificar.Location = new Point(159, 440);
            BModificar.Name = "BModificar";
            BModificar.Size = new Size(164, 40);
            BModificar.TabIndex = 52;
            BModificar.Text = "MODIFICAR USUARIO";
            BModificar.TextAlign = ContentAlignment.MiddleRight;
            BModificar.UseVisualStyleBackColor = true;
            BModificar.Click += BModificar_Click;
            // 
            // BAlta
            // 
            BAlta.Image = Properties.Resources.icon_dar_alta;
            BAlta.ImageAlign = ContentAlignment.MiddleLeft;
            BAlta.Location = new Point(177, 491);
            BAlta.Name = "BAlta";
            BAlta.Size = new Size(140, 45);
            BAlta.TabIndex = 54;
            BAlta.Text = "DAR DE ALTA";
            BAlta.TextAlign = ContentAlignment.MiddleRight;
            BAlta.UseVisualStyleBackColor = true;
            BAlta.Click += BAlta_Click;
            // 
            // BBaja
            // 
            BBaja.Image = Properties.Resources.icon_dar_baja;
            BBaja.ImageAlign = ContentAlignment.MiddleLeft;
            BBaja.Location = new Point(177, 491);
            BBaja.Name = "BBaja";
            BBaja.Size = new Size(140, 45);
            BBaja.TabIndex = 53;
            BBaja.Text = "DAR DE BAJA";
            BBaja.TextAlign = ContentAlignment.MiddleRight;
            BBaja.UseVisualStyleBackColor = true;
            BBaja.Click += BBaja_Click_1;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.flecha_verde_retroceder;
            button3.Location = new Point(12, 491);
            button3.Name = "button3";
            button3.Size = new Size(58, 60);
            button3.TabIndex = 55;
            button3.Text = "Volver";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // TCodPostal
            // 
            TCodPostal.Location = new Point(243, 307);
            TCodPostal.Name = "TCodPostal";
            TCodPostal.Size = new Size(170, 23);
            TCodPostal.TabIndex = 57;
            // 
            // LCodPostal
            // 
            LCodPostal.AutoSize = true;
            LCodPostal.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LCodPostal.ForeColor = Color.White;
            LCodPostal.Location = new Point(71, 310);
            LCodPostal.Name = "LCodPostal";
            LCodPostal.Size = new Size(156, 20);
            LCodPostal.TabIndex = 56;
            LCodPostal.Text = "Número de Dirección:";
            // 
            // BOcultar
            // 
            BOcultar.BackColor = Color.Black;
            BOcultar.FlatAppearance.BorderSize = 0;
            BOcultar.FlatStyle = FlatStyle.Flat;
            BOcultar.Image = (Image)resources.GetObject("BOcultar.Image");
            BOcultar.Location = new Point(419, 158);
            BOcultar.Name = "BOcultar";
            BOcultar.Size = new Size(33, 29);
            BOcultar.TabIndex = 58;
            BOcultar.UseVisualStyleBackColor = false;
            BOcultar.Click += BOcultar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(BOcultar);
            panel1.Controls.Add(TCodPostal);
            panel1.Controls.Add(LCodPostal);
            panel1.Controls.Add(BModificar);
            panel1.Controls.Add(LModificar);
            panel1.Controls.Add(DTPicker);
            panel1.Controls.Add(CBPerfil);
            panel1.Controls.Add(RBMujer);
            panel1.Controls.Add(RBHombre);
            panel1.Controls.Add(TTelefono);
            panel1.Controls.Add(TDireccion);
            panel1.Controls.Add(TDni);
            panel1.Controls.Add(TEmail);
            panel1.Controls.Add(TContraseña);
            panel1.Controls.Add(TUsuario);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(LSexo);
            panel1.Controls.Add(LEmail);
            panel1.Controls.Add(LPerfil);
            panel1.Controls.Add(LFechaNac);
            panel1.Controls.Add(LDni);
            panel1.Controls.Add(LDireccion);
            panel1.Controls.Add(LContraseña);
            panel1.Controls.Add(LTelefono);
            panel1.Controls.Add(LUsuario);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(LNombre);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 572);
            panel1.TabIndex = 59;
            // 
            // FormEditorUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(488, 559);
            Controls.Add(button3);
            Controls.Add(BAlta);
            Controls.Add(BBaja);
            Controls.Add(panel1);
            Name = "FormEditorUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Usuario/Baja-Alta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker DTPicker;
        private ComboBox CBPerfil;
        private RadioButton RBMujer;
        private RadioButton RBHombre;
        private TextBox TTelefono;
        private TextBox TDireccion;
        private TextBox TDni;
        private TextBox TEmail;
        private TextBox TContraseña;
        private TextBox TUsuario;
        private TextBox TApellido;
        private TextBox TNombre;
        private Label LSexo;
        private Label LEmail;
        private Label LPerfil;
        private Label LFechaNac;
        private Label LDni;
        private Label LDireccion;
        private Label LContraseña;
        private Label LTelefono;
        private Label LUsuario;
        private Label LApellido;
        private Label LNombre;
        private Label LModificar;
        private Button BModificar;
        private Button BAlta;
        private Button BBaja;
        private Button button3;
        private TextBox TCodPostal;
        private Label LCodPostal;
        private Button BOcultar;
        private Panel panel1;
    }
}