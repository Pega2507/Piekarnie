namespace Piekarnie
{
    partial class OknoPozycjiZamowienia
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
            panel1 = new Panel();
            btnZapisz = new Button();
            btnAnuluj = new Button();
            inpProdukt = new ComboBox();
            label1 = new Label();
            inpIlosc = new TextBox();
            inpCena = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnZapisz);
            panel1.Controls.Add(btnAnuluj);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 48);
            panel1.TabIndex = 0;
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(363, 13);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(75, 23);
            btnZapisz.TabIndex = 1;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(12, 13);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(75, 23);
            btnAnuluj.TabIndex = 0;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // inpProdukt
            // 
            inpProdukt.FormattingEnabled = true;
            inpProdukt.Location = new Point(83, 12);
            inpProdukt.Name = "inpProdukt";
            inpProdukt.Size = new Size(355, 23);
            inpProdukt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 15);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "Produkt:";
            // 
            // inpIlosc
            // 
            inpIlosc.Location = new Point(83, 41);
            inpIlosc.Name = "inpIlosc";
            inpIlosc.Size = new Size(100, 23);
            inpIlosc.TabIndex = 3;
            // 
            // inpCena
            // 
            inpCena.Location = new Point(295, 41);
            inpCena.Name = "inpCena";
            inpCena.Size = new Size(100, 23);
            inpCena.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 44);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 5;
            label2.Text = "Ilość:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 44);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 6;
            label3.Text = "Cena:";
            // 
            // OknoPozycjiZamowienia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnAnuluj;
            ClientSize = new Size(450, 140);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inpCena);
            Controls.Add(inpIlosc);
            Controls.Add(label1);
            Controls.Add(inpProdukt);
            Controls.Add(panel1);
            MaximumSize = new Size(466, 179);
            MinimumSize = new Size(466, 179);
            Name = "OknoPozycjiZamowienia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pozycja zamówienia";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnZapisz;
        private Button btnAnuluj;
        private ComboBox inpProdukt;
        private Label label1;
        private TextBox inpIlosc;
        private TextBox inpCena;
        private Label label2;
        private Label label3;
    }
}