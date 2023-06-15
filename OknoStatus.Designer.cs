namespace Piekarnie
{
    partial class OknoStatus
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
            this.label1 = new System.Windows.Forms.Label();
            this.inpZapisz = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa:";
            // 
            // inpZapisz
            // 
            this.inpZapisz.Location = new System.Drawing.Point(63, 23);
            this.inpZapisz.Name = "inpZapisz";
            this.inpZapisz.Size = new System.Drawing.Size(210, 23);
            this.inpZapisz.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnZapisz);
            this.panel1.Controls.Add(this.btnAnuluj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 50);
            this.panel1.TabIndex = 2;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(198, 15);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 3;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(12, 15);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 2;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // OknoStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuluj;
            this.ClientSize = new System.Drawing.Size(285, 117);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inpZapisz);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(301, 156);
            this.MinimumSize = new System.Drawing.Size(301, 156);
            this.Name = "OknoStatus";
            this.Text = "Status";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox inpZapisz;
        private Panel panel1;
        private Button btnZapisz;
        private Button btnAnuluj;
    }
}