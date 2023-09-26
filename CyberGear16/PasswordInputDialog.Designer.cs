namespace CyberGear16
{
    partial class PasswordInputDialog
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
            label1 = new Label();
            textBoxPassword = new TextBox();
            button1 = new Button();
            button2 = new Button();
            mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 42);
            label1.Name = "label1";
            label1.Size = new Size(166, 50);
            label1.TabIndex = 0;
            label1.Text = "Ingrese denuevo \r\nsu contraseña";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(48, 122);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(147, 23);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(48, 182);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(139, 182);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // mySqlCommandBuilder1
            // 
            mySqlCommandBuilder1.DataAdapter = null;
            mySqlCommandBuilder1.QuotePrefix = "`";
            mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // PasswordInputDialog
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoDegradadoMoradoRosa;
            ClientSize = new Size(261, 242);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxPassword);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "PasswordInputDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PasswordInputDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPassword;
        private Button button1;
        private Button button2;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
    }
}