namespace CyberGear16
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
            PUsuarios = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            LApellido = new Label();
            LNombre = new Label();
            LUsuarios = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            PUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // PUsuarios
            // 
            PUsuarios.BackColor = Color.FromArgb(26, 32, 40);
            PUsuarios.Controls.Add(label5);
            PUsuarios.Controls.Add(label4);
            PUsuarios.Controls.Add(label3);
            PUsuarios.Controls.Add(LApellido);
            PUsuarios.Controls.Add(LNombre);
            PUsuarios.Controls.Add(LUsuarios);
            PUsuarios.Location = new Point(19, 11);
            PUsuarios.Name = "PUsuarios";
            PUsuarios.Size = new Size(751, 217);
            PUsuarios.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(38, 167);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 5;
            label5.Text = "Usuarios";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(373, 125);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 4;
            label4.Text = "Usuarios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(38, 125);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 3;
            label3.Text = "Usuarios";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.ForeColor = Color.White;
            LApellido.Location = new Point(38, 94);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.ForeColor = Color.White;
            LNombre.Location = new Point(38, 57);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(54, 15);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre:";
            LNombre.Click += label1_Click;
            // 
            // LUsuarios
            // 
            LUsuarios.AutoSize = true;
            LUsuarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LUsuarios.ForeColor = Color.White;
            LUsuarios.Location = new Point(20, 9);
            LUsuarios.Name = "LUsuarios";
            LUsuarios.Size = new Size(89, 25);
            LUsuarios.TabIndex = 0;
            LUsuarios.Text = "Usuarios:";
            LUsuarios.Click += LUsuarios_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(19, 272);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(751, 166);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // adminUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(PUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminUsers";
            Text = "Form1";
            PUsuarios.ResumeLayout(false);
            PUsuarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PUsuarios;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LUsuarios;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label LApellido;
        private Label LNombre;
    }
}