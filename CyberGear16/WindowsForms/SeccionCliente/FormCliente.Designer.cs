namespace CyberGear16
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            PUsuarios = new Panel();
            TNumeroDirec = new TextBox();
            LCodPostal = new Label();
            DTPicker = new DateTimePicker();
            BCancelar = new Button();
            BGuardar = new Button();
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
            LUsuarios = new Label();
            TBuscar = new TextBox();
            DGVClientes = new DataGridView();
            BBorrar = new Button();
            BBuscar = new Button();
            BActivos = new Button();
            BInactivo = new Button();
            PUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVClientes).BeginInit();
            SuspendLayout();
            // 
            // PUsuarios
            // 
            PUsuarios.Anchor = AnchorStyles.None;
            PUsuarios.BackColor = Color.FromArgb(26, 32, 40);
            PUsuarios.Controls.Add(TNumeroDirec);
            PUsuarios.Controls.Add(LCodPostal);
            PUsuarios.Controls.Add(DTPicker);
            PUsuarios.Controls.Add(BCancelar);
            PUsuarios.Controls.Add(BGuardar);
            PUsuarios.Controls.Add(RBMujer);
            PUsuarios.Controls.Add(RBHombre);
            PUsuarios.Controls.Add(TTelefono);
            PUsuarios.Controls.Add(TDireccion);
            PUsuarios.Controls.Add(TDni);
            PUsuarios.Controls.Add(TEmail);
            PUsuarios.Controls.Add(TApellido);
            PUsuarios.Controls.Add(TNombre);
            PUsuarios.Controls.Add(LSexo);
            PUsuarios.Controls.Add(LEmail);
            PUsuarios.Controls.Add(LFechaNac);
            PUsuarios.Controls.Add(LDni);
            PUsuarios.Controls.Add(LDireccion);
            PUsuarios.Controls.Add(LTelefono);
            PUsuarios.Controls.Add(LApellido);
            PUsuarios.Controls.Add(LNombre);
            PUsuarios.Controls.Add(LUsuarios);
            PUsuarios.Location = new Point(20, 12);
            PUsuarios.Name = "PUsuarios";
            PUsuarios.Size = new Size(1019, 333);
            PUsuarios.TabIndex = 1;
            // 
            // TNumeroDirec
            // 
            TNumeroDirec.Location = new Point(483, 120);
            TNumeroDirec.Name = "TNumeroDirec";
            TNumeroDirec.Size = new Size(170, 23);
            TNumeroDirec.TabIndex = 29;
            // 
            // LCodPostal
            // 
            LCodPostal.AutoSize = true;
            LCodPostal.ForeColor = Color.White;
            LCodPostal.Location = new Point(349, 123);
            LCodPostal.Name = "LCodPostal";
            LCodPostal.Size = new Size(123, 15);
            LCodPostal.TabIndex = 28;
            LCodPostal.Text = "Número de Dirección:";
            // 
            // DTPicker
            // 
            DTPicker.Format = DateTimePickerFormat.Short;
            DTPicker.Location = new Point(483, 149);
            DTPicker.Name = "DTPicker";
            DTPicker.Size = new Size(170, 23);
            DTPicker.TabIndex = 27;
            // 
            // BCancelar
            // 
            BCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BCancelar.Image = Properties.Resources.borrar;
            BCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BCancelar.Location = new Point(731, 158);
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
            BGuardar.Location = new Point(731, 70);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(137, 68);
            BGuardar.TabIndex = 25;
            BGuardar.Text = "Guardar";
            BGuardar.TextAlign = ContentAlignment.MiddleRight;
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.ForeColor = Color.White;
            RBMujer.Location = new Point(586, 217);
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
            RBHombre.Location = new Point(489, 217);
            RBHombre.Name = "RBHombre";
            RBHombre.Size = new Size(69, 19);
            RBHombre.TabIndex = 22;
            RBHombre.TabStop = true;
            RBHombre.Text = "Hombre";
            RBHombre.UseVisualStyleBackColor = true;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(483, 178);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(170, 23);
            TTelefono.TabIndex = 21;
            // 
            // TDireccion
            // 
            TDireccion.Location = new Point(483, 90);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(170, 23);
            TDireccion.TabIndex = 19;
            // 
            // TDni
            // 
            TDni.Location = new Point(113, 178);
            TDni.Name = "TDni";
            TDni.Size = new Size(170, 23);
            TDni.TabIndex = 18;
            // 
            // TEmail
            // 
            TEmail.Location = new Point(113, 148);
            TEmail.Name = "TEmail";
            TEmail.Size = new Size(170, 23);
            TEmail.TabIndex = 16;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(113, 119);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(170, 23);
            TApellido.TabIndex = 13;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(113, 90);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(170, 23);
            TNombre.TabIndex = 12;
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.ForeColor = Color.White;
            LSexo.Location = new Point(349, 216);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(35, 15);
            LSexo.TabIndex = 11;
            LSexo.Text = "Sexo:";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.ForeColor = Color.White;
            LEmail.Location = new Point(38, 151);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(39, 15);
            LEmail.TabIndex = 10;
            LEmail.Text = "Email:";
            // 
            // LFechaNac
            // 
            LFechaNac.AutoSize = true;
            LFechaNac.ForeColor = Color.White;
            LFechaNac.Location = new Point(349, 151);
            LFechaNac.Name = "LFechaNac";
            LFechaNac.Size = new Size(122, 15);
            LFechaNac.TabIndex = 8;
            LFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.ForeColor = Color.White;
            LDni.Location = new Point(38, 186);
            LDni.Name = "LDni";
            LDni.Size = new Size(28, 15);
            LDni.TabIndex = 7;
            LDni.Text = "Dni:";
            // 
            // LDireccion
            // 
            LDireccion.AutoSize = true;
            LDireccion.ForeColor = Color.White;
            LDireccion.Location = new Point(349, 93);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(60, 15);
            LDireccion.TabIndex = 6;
            LDireccion.Text = "Dirección:";
            LDireccion.Click += LDireccion_Click;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.ForeColor = Color.White;
            LTelefono.Location = new Point(349, 181);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(55, 15);
            LTelefono.TabIndex = 4;
            LTelefono.Text = "Telefono:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.ForeColor = Color.White;
            LApellido.Location = new Point(37, 122);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(54, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.ForeColor = Color.White;
            LNombre.Location = new Point(38, 93);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(54, 15);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre:";
            // 
            // LUsuarios
            // 
            LUsuarios.AutoSize = true;
            LUsuarios.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LUsuarios.ForeColor = Color.White;
            LUsuarios.Location = new Point(24, 21);
            LUsuarios.Name = "LUsuarios";
            LUsuarios.Size = new Size(96, 30);
            LUsuarios.TabIndex = 0;
            LUsuarios.Text = "Clientes:";
            // 
            // TBuscar
            // 
            TBuscar.Anchor = AnchorStyles.None;
            TBuscar.Location = new Point(639, 389);
            TBuscar.Name = "TBuscar";
            TBuscar.Size = new Size(313, 23);
            TBuscar.TabIndex = 8;
            TBuscar.Text = "Buscar";
            TBuscar.Click += TBuscar_Click;
            TBuscar.KeyPress += TBuscar_KeyPress;
            // 
            // DGVClientes
            // 
            DGVClientes.Anchor = AnchorStyles.None;
            DGVClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVClientes.Location = new Point(21, 430);
            DGVClientes.Name = "DGVClientes";
            DGVClientes.RowTemplate.Height = 25;
            DGVClientes.Size = new Size(1019, 248);
            DGVClientes.TabIndex = 5;
            DGVClientes.CellContentClick += DGVClientes_CellContentClick;
            // 
            // BBorrar
            // 
            BBorrar.Anchor = AnchorStyles.None;
            BBorrar.Image = (Image)resources.GetObject("BBorrar.Image");
            BBorrar.Location = new Point(1001, 380);
            BBorrar.Name = "BBorrar";
            BBorrar.Size = new Size(38, 37);
            BBorrar.TabIndex = 32;
            BBorrar.UseVisualStyleBackColor = true;
            BBorrar.Click += BBorrar_Click;
            // 
            // BBuscar
            // 
            BBuscar.Anchor = AnchorStyles.None;
            BBuscar.Image = Properties.Resources.lupa;
            BBuscar.Location = new Point(957, 380);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(38, 37);
            BBuscar.TabIndex = 31;
            BBuscar.UseVisualStyleBackColor = true;
            BBuscar.Click += BBuscar_Click;
            // 
            // BActivos
            // 
            BActivos.Anchor = AnchorStyles.None;
            BActivos.Location = new Point(20, 384);
            BActivos.Name = "BActivos";
            BActivos.Size = new Size(113, 28);
            BActivos.TabIndex = 6;
            BActivos.Text = "Activos";
            BActivos.UseVisualStyleBackColor = true;
            BActivos.Click += BActivos_Click;
            // 
            // BInactivo
            // 
            BInactivo.Anchor = AnchorStyles.None;
            BInactivo.Location = new Point(158, 384);
            BInactivo.Name = "BInactivo";
            BInactivo.Size = new Size(113, 28);
            BInactivo.TabIndex = 7;
            BInactivo.Text = "Inactivos";
            BInactivo.UseVisualStyleBackColor = true;
            BInactivo.Click += BInactivo_Click;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 705);
            Controls.Add(BBorrar);
            Controls.Add(BBuscar);
            Controls.Add(TBuscar);
            Controls.Add(BInactivo);
            Controls.Add(BActivos);
            Controls.Add(DGVClientes);
            Controls.Add(PUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormClientes";
            Text = "Clientes";
            Load += FormClientes_Load;
            PUsuarios.ResumeLayout(false);
            PUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PUsuarios;
        private TextBox TNumeroDirec;
        private Label LCodPostal;
        private DateTimePicker DTPicker;
        private Button BCancelar;
        private Button BGuardar;
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
        private Label LUsuarios;
        private TextBox TBuscar;
        private DataGridView DGVClientes;
        private Button BBorrar;
        private Button BBuscar;
        private Button BActivos;
        private Button BInactivo;
    }
}