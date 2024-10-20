﻿namespace CyberGear16
{
    partial class FormBackUp
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
            btnRespaldar = new Button();
            btnRestaurarBase = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            label2 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRespaldar
            // 
            btnRespaldar.Anchor = AnchorStyles.None;
            btnRespaldar.Image = Properties.Resources.icon_backup_negro1;
            btnRespaldar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRespaldar.Location = new Point(197, 84);
            btnRespaldar.Name = "btnRespaldar";
            btnRespaldar.Size = new Size(200, 46);
            btnRespaldar.TabIndex = 0;
            btnRespaldar.Text = "Respaldar Base de datos";
            btnRespaldar.TextAlign = ContentAlignment.MiddleRight;
            btnRespaldar.UseVisualStyleBackColor = true;
            btnRespaldar.Click += btnRespaldar_Click;
            // 
            // btnRestaurarBase
            // 
            btnRestaurarBase.Anchor = AnchorStyles.None;
            btnRestaurarBase.Image = Properties.Resources.icon_subir_negro1;
            btnRestaurarBase.ImageAlign = ContentAlignment.MiddleLeft;
            btnRestaurarBase.Location = new Point(197, 294);
            btnRestaurarBase.Name = "btnRestaurarBase";
            btnRestaurarBase.Size = new Size(200, 46);
            btnRestaurarBase.TabIndex = 1;
            btnRestaurarBase.Text = "Restaurar Base de datos";
            btnRestaurarBase.TextAlign = ContentAlignment.MiddleRight;
            btnRestaurarBase.UseVisualStyleBackColor = true;
            btnRestaurarBase.Click += btnRestaurarBase_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 36);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(248, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 40);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 3;
            label1.Text = "Ruta de guardado";
            // 
            // button1
            // 
            button1.Location = new Point(442, 36);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Elegir ruta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(275, 20);
            label2.Name = "label2";
            label2.Size = new Size(392, 61);
            label2.TabIndex = 5;
            label2.Text = "Gestion de Backup";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnRestaurarBase);
            panel1.Controls.Add(btnRespaldar);
            panel1.Location = new Point(151, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(656, 424);
            panel1.TabIndex = 6;
            // 
            // FormBackUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 649);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBackUp";
            Text = "FormBackUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRespaldar;
        private Button btnRestaurarBase;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Label label2;
        private Panel panel1;
    }
}