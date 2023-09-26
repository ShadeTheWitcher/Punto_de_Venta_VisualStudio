namespace CyberGear16
{
    partial class SubFormBackUp
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            btnRestaurarBase = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(444, 203);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Elegir ruta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 207);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 6;
            label1.Text = "Ruta de guardado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 203);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(248, 23);
            textBox1.TabIndex = 5;
            // 
            // btnRestaurarBase
            // 
            btnRestaurarBase.Anchor = AnchorStyles.None;
            btnRestaurarBase.Image = Properties.Resources.icon_subir_negro1;
            btnRestaurarBase.ImageAlign = ContentAlignment.MiddleLeft;
            btnRestaurarBase.Location = new Point(188, 294);
            btnRestaurarBase.Name = "btnRestaurarBase";
            btnRestaurarBase.Size = new Size(200, 46);
            btnRestaurarBase.TabIndex = 8;
            btnRestaurarBase.Text = "Restaurar Base de datos";
            btnRestaurarBase.TextAlign = ContentAlignment.MiddleRight;
            btnRestaurarBase.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(188, 30);
            label2.Name = "label2";
            label2.Size = new Size(219, 61);
            label2.TabIndex = 9;
            label2.Text = "Restaurar";
            // 
            // SubFormBackUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 450);
            Controls.Add(label2);
            Controls.Add(btnRestaurarBase);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "SubFormBackUp";
            Text = "Restaurar base ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button btnRestaurarBase;
        private Label label2;
    }
}