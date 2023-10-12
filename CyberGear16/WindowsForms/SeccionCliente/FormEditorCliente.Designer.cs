namespace CyberGear16.WindowsForms.SeccionCliente
{
    partial class FormEditorCliente
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
            TCodPostal = new TextBox();
            LCodPostal = new Label();
            BModificar = new Button();
            LModificar = new Label();
            DTPicker = new DateTimePicker();
            RBMujer = new RadioButton();
            RBHombre = new RadioButton();
            TTelefono = new TextBox();
            TDireccion = new TextBox();
            TDni = new TextBox();
            TEmail = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            LSexo = new Label();
            LEmail = new Label();
            LFechaNac = new Label();
            LDni = new Label();
            LDireccion = new Label();
            LTelefono = new Label();
            LApellido = new Label();
            LNombre = new Label();
            button3 = new Button();
            BAlta = new Button();
            BBaja = new Button();
            SuspendLayout();
            // 
            // TCodPostal
            // 
            TCodPostal.Location = new Point(227, 236);
            TCodPostal.Name = "TCodPostal";
            TCodPostal.Size = new Size(170, 23);
            TCodPostal.TabIndex = 85;
            // 
            // LCodPostal
            // 
            LCodPostal.AutoSize = true;
            LCodPostal.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LCodPostal.ForeColor = Color.White;
            LCodPostal.Location = new Point(55, 239);
            LCodPostal.Name = "LCodPostal";
            LCodPostal.Size = new Size(156, 20);
            LCodPostal.TabIndex = 84;
            LCodPostal.Text = "Número de Dirección:";
            // 
            // BModificar
            // 
            BModificar.Image = Properties.Resources.actualizar;
            BModificar.ImageAlign = ContentAlignment.MiddleLeft;
            BModificar.Location = new Point(157, 397);
            BModificar.Name = "BModificar";
            BModificar.Size = new Size(164, 40);
            BModificar.TabIndex = 83;
            BModificar.Text = "MODIFICAR USUARIO";
            BModificar.TextAlign = ContentAlignment.MiddleRight;
            BModificar.UseVisualStyleBackColor = true;
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LModificar.ForeColor = Color.White;
            LModificar.Location = new Point(142, 37);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(179, 25);
            LModificar.TabIndex = 82;
            LModificar.Text = "Modificar Cliente";
            // 
            // DTPicker
            // 
            DTPicker.Format = DateTimePickerFormat.Short;
            DTPicker.Location = new Point(227, 265);
            DTPicker.Name = "DTPicker";
            DTPicker.Size = new Size(170, 23);
            DTPicker.TabIndex = 81;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RBMujer.ForeColor = Color.White;
            RBMujer.Location = new Point(330, 327);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(66, 24);
            RBMujer.TabIndex = 79;
            RBMujer.TabStop = true;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            // 
            // RBHombre
            // 
            RBHombre.AutoSize = true;
            RBHombre.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RBHombre.ForeColor = Color.White;
            RBHombre.Location = new Point(233, 327);
            RBHombre.Name = "RBHombre";
            RBHombre.Size = new Size(80, 24);
            RBHombre.TabIndex = 78;
            RBHombre.TabStop = true;
            RBHombre.Text = "Hombre";
            RBHombre.UseVisualStyleBackColor = true;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(227, 294);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(170, 23);
            TTelefono.TabIndex = 77;
            // 
            // TDireccion
            // 
            TDireccion.Location = new Point(227, 207);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(170, 23);
            TDireccion.TabIndex = 76;
            // 
            // TDni
            // 
            TDni.Location = new Point(227, 178);
            TDni.Name = "TDni";
            TDni.Size = new Size(170, 23);
            TDni.TabIndex = 75;
            // 
            // TEmail
            // 
            TEmail.Location = new Point(227, 149);
            TEmail.Name = "TEmail";
            TEmail.Size = new Size(170, 23);
            TEmail.TabIndex = 74;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(227, 120);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(170, 23);
            TApellido.TabIndex = 71;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(227, 91);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(170, 23);
            TNombre.TabIndex = 70;
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LSexo.ForeColor = Color.White;
            LSexo.Location = new Point(56, 329);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(45, 20);
            LSexo.TabIndex = 69;
            LSexo.Text = "Sexo:";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LEmail.ForeColor = Color.White;
            LEmail.Location = new Point(56, 148);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(51, 20);
            LEmail.TabIndex = 68;
            LEmail.Text = "Email:";
            // 
            // LFechaNac
            // 
            LFechaNac.AutoSize = true;
            LFechaNac.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LFechaNac.ForeColor = Color.White;
            LFechaNac.Location = new Point(55, 267);
            LFechaNac.Name = "LFechaNac";
            LFechaNac.Size = new Size(156, 20);
            LFechaNac.TabIndex = 66;
            LFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.ForeColor = Color.White;
            LDni.Location = new Point(56, 181);
            LDni.Name = "LDni";
            LDni.Size = new Size(36, 20);
            LDni.TabIndex = 65;
            LDni.Text = "Dni:";
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LDireccion.ForeColor = Color.White;
            LDireccion.Location = new Point(55, 210);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(73, 20);
            LDireccion.TabIndex = 64;
            LDireccion.Text = "Dirección:";
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LTelefono.ForeColor = Color.White;
            LTelefono.Location = new Point(56, 297);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(72, 20);
            LTelefono.TabIndex = 62;
            LTelefono.Text = "Telefono:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.ForeColor = Color.White;
            LApellido.Location = new Point(55, 119);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(67, 20);
            LApellido.TabIndex = 60;
            LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.ForeColor = Color.White;
            LNombre.Location = new Point(56, 90);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(68, 20);
            LNombre.TabIndex = 59;
            LNombre.Text = "Nombre:";
            // 
            // button3
            // 
            button3.Image = Properties.Resources.flecha_verde_retroceder;
            button3.Location = new Point(12, 461);
            button3.Name = "button3";
            button3.Size = new Size(58, 60);
            button3.TabIndex = 88;
            button3.Text = "Volver";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // BAlta
            // 
            BAlta.Image = Properties.Resources.icon_dar_alta;
            BAlta.ImageAlign = ContentAlignment.MiddleLeft;
            BAlta.Location = new Point(173, 443);
            BAlta.Name = "BAlta";
            BAlta.Size = new Size(140, 45);
            BAlta.TabIndex = 87;
            BAlta.Text = "DAR DE ALTA";
            BAlta.TextAlign = ContentAlignment.MiddleRight;
            BAlta.UseVisualStyleBackColor = true;
            // 
            // BBaja
            // 
            BBaja.Image = Properties.Resources.icon_dar_baja;
            BBaja.ImageAlign = ContentAlignment.MiddleLeft;
            BBaja.Location = new Point(173, 443);
            BBaja.Name = "BBaja";
            BBaja.Size = new Size(140, 45);
            BBaja.TabIndex = 89;
            BBaja.Text = "DAR DE BAJA";
            BBaja.TextAlign = ContentAlignment.MiddleRight;
            BBaja.UseVisualStyleBackColor = true;
            // 
            // FormEditorCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(478, 533);
            Controls.Add(button3);
            Controls.Add(BAlta);
            Controls.Add(TCodPostal);
            Controls.Add(LCodPostal);
            Controls.Add(BModificar);
            Controls.Add(LModificar);
            Controls.Add(DTPicker);
            Controls.Add(RBMujer);
            Controls.Add(RBHombre);
            Controls.Add(TTelefono);
            Controls.Add(TDireccion);
            Controls.Add(TDni);
            Controls.Add(TEmail);
            Controls.Add(TApellido);
            Controls.Add(TNombre);
            Controls.Add(LSexo);
            Controls.Add(LEmail);
            Controls.Add(LFechaNac);
            Controls.Add(LDni);
            Controls.Add(LDireccion);
            Controls.Add(LTelefono);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(BBaja);
            Name = "FormEditorCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Cliente/Baja-Alta";
            Load += FormEditorCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TCodPostal;
        private Label LCodPostal;
        private Button BModificar;
        private Label LModificar;
        private DateTimePicker DTPicker;
        private RadioButton RBMujer;
        private RadioButton RBHombre;
        private TextBox TTelefono;
        private TextBox TDireccion;
        private TextBox TDni;
        private TextBox TEmail;
        private TextBox TApellido;
        private TextBox TNombre;
        private Label LSexo;
        private Label LEmail;
        private Label LFechaNac;
        private Label LDni;
        private Label LDireccion;
        private Label LTelefono;
        private Label LApellido;
        private Label LNombre;
        private Button button3;
        private Button BAlta;
        private Button BBaja;
    }
}