namespace Piekarnie
{
    partial class OknoLogowania
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
            inpLogin = new TextBox();
            inpHaslo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnOk = new Button();
            btnAnuluj = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // inpLogin
            // 
            inpLogin.Location = new Point(201, 26);
            inpLogin.Name = "inpLogin";
            inpLogin.Size = new Size(210, 23);
            inpLogin.TabIndex = 0;
            inpLogin.Text = "admin";
            // 
            // inpHaslo
            // 
            inpHaslo.Location = new Point(201, 55);
            inpHaslo.Name = "inpHaslo";
            inpHaslo.PasswordChar = '*';
            inpHaslo.Size = new Size(210, 23);
            inpHaslo.TabIndex = 1;
            inpHaslo.Text = "123456";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 29);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 2;
            label1.Text = "Użytkownik:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 58);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Hasło:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOk);
            panel1.Controls.Add(btnAnuluj);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 45);
            panel1.TabIndex = 4;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(336, 10);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(12, 10);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(75, 23);
            btnAnuluj.TabIndex = 0;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // OknoLogowania
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnAnuluj;
            ClientSize = new Size(423, 148);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inpHaslo);
            Controls.Add(inpLogin);
            Name = "OknoLogowania";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logowanie do piekarni";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inpLogin;
        private TextBox inpHaslo;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button btnOk;
        private Button btnAnuluj;
    }
}