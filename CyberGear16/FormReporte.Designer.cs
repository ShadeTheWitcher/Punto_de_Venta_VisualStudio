namespace CyberGear16
{
    partial class FormReporte
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
            LUsuarios = new Label();
            PReporte = new Panel();
            BReporte = new Button();
            LHasta = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            DTPDesde = new DateTimePicker();
            panel1 = new Panel();
            PReporte.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LUsuarios
            // 
            LUsuarios.AutoSize = true;
            LUsuarios.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LUsuarios.ForeColor = Color.White;
            LUsuarios.Location = new Point(42, 39);
            LUsuarios.Name = "LUsuarios";
            LUsuarios.Size = new Size(106, 30);
            LUsuarios.TabIndex = 1;
            LUsuarios.Text = "Reportes:";
            // 
            // PReporte
            // 
            PReporte.Anchor = AnchorStyles.None;
            PReporte.BackColor = Color.SteelBlue;
            PReporte.Controls.Add(BReporte);
            PReporte.Controls.Add(LHasta);
            PReporte.Controls.Add(label1);
            PReporte.Controls.Add(dateTimePicker1);
            PReporte.Controls.Add(DTPDesde);
            PReporte.Location = new Point(133, 158);
            PReporte.Name = "PReporte";
            PReporte.Size = new Size(801, 415);
            PReporte.TabIndex = 2;
            // 
            // BReporte
            // 
            BReporte.Location = new Point(286, 249);
            BReporte.Name = "BReporte";
            BReporte.Size = new Size(235, 44);
            BReporte.TabIndex = 4;
            BReporte.Text = "Generar Reporte";
            BReporte.UseVisualStyleBackColor = true;
            // 
            // LHasta
            // 
            LHasta.AutoSize = true;
            LHasta.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LHasta.ForeColor = Color.White;
            LHasta.Location = new Point(557, 92);
            LHasta.Name = "LHasta";
            LHasta.Size = new Size(75, 25);
            LHasta.TabIndex = 3;
            LHasta.Text = "Hasta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(165, 92);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 2;
            label1.Text = "Desde:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(491, 159);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(202, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // DTPDesde
            // 
            DTPDesde.Format = DateTimePickerFormat.Short;
            DTPDesde.Location = new Point(107, 159);
            DTPDesde.Name = "DTPDesde";
            DTPDesde.Size = new Size(202, 23);
            DTPDesde.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(PReporte);
            panel1.Controls.Add(LUsuarios);
            panel1.Location = new Point(2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 794);
            panel1.TabIndex = 3;
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1061, 788);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReporte";
            Text = "Form1";
            PReporte.ResumeLayout(false);
            PReporte.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LUsuarios;
        private Panel PReporte;
        private Label LHasta;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker DTPDesde;
        private Button BReporte;
        private Panel panel1;
    }
}