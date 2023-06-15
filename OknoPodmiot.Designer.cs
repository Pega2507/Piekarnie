namespace Piekarnie
{
    partial class OknoPodmiot
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
            this.inpTyp = new System.Windows.Forms.ComboBox();
            this.inpNazwa = new System.Windows.Forms.TextBox();
            this.inpAdres = new System.Windows.Forms.RichTextBox();
            this.inpTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inpNowyMagazyn = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Typ:";
            // 
            // inpTyp
            // 
            this.inpTyp.FormattingEnabled = true;
            this.inpTyp.Items.AddRange(new object[] {
            "Piekarnia",
            "Dostawca"});
            this.inpTyp.Location = new System.Drawing.Point(98, 24);
            this.inpTyp.Name = "inpTyp";
            this.inpTyp.Size = new System.Drawing.Size(326, 23);
            this.inpTyp.TabIndex = 1;
            // 
            // inpNazwa
            // 
            this.inpNazwa.Location = new System.Drawing.Point(98, 53);
            this.inpNazwa.Name = "inpNazwa";
            this.inpNazwa.Size = new System.Drawing.Size(326, 23);
            this.inpNazwa.TabIndex = 2;
            // 
            // inpAdres
            // 
            this.inpAdres.Location = new System.Drawing.Point(98, 82);
            this.inpAdres.Name = "inpAdres";
            this.inpAdres.Size = new System.Drawing.Size(326, 96);
            this.inpAdres.TabIndex = 3;
            this.inpAdres.Text = "";
            // 
            // inpTelefon
            // 
            this.inpTelefon.Location = new System.Drawing.Point(98, 184);
            this.inpTelefon.Name = "inpTelefon";
            this.inpTelefon.Size = new System.Drawing.Size(326, 23);
            this.inpTelefon.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nazwa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon:";
            // 
            // inpNowyMagazyn
            // 
            this.inpNowyMagazyn.AutoSize = true;
            this.inpNowyMagazyn.Enabled = false;
            this.inpNowyMagazyn.Location = new System.Drawing.Point(98, 213);
            this.inpNowyMagazyn.Name = "inpNowyMagazyn";
            this.inpNowyMagazyn.Size = new System.Drawing.Size(114, 19);
            this.inpNowyMagazyn.TabIndex = 5;
            this.inpNowyMagazyn.Text = "Utwórz magazyn";
            this.inpNowyMagazyn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnZapisz);
            this.panel1.Controls.Add(this.btnAnuluj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 53);
            this.panel1.TabIndex = 9;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(364, 18);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 7;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(12, 18);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 6;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // OknoPodmiot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 294);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inpNowyMagazyn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inpTelefon);
            this.Controls.Add(this.inpAdres);
            this.Controls.Add(this.inpNazwa);
            this.Controls.Add(this.inpTyp);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(467, 333);
            this.MinimumSize = new System.Drawing.Size(467, 333);
            this.Name = "OknoPodmiot";
            this.Text = "Podmiot";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox inpTyp;
        private TextBox inpNazwa;
        private RichTextBox inpAdres;
        private TextBox inpTelefon;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox inpNowyMagazyn;
        private Panel panel1;
        private Button btnZapisz;
        private Button btnAnuluj;
    }
}