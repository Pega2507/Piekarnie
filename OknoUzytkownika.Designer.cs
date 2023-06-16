namespace Piekarnie
{
    partial class OknoUzytkownika
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
            label1 = new Label();
            inpLogin = new TextBox();
            inpImie = new TextBox();
            inpNazwisko = new TextBox();
            inpHaslo = new TextBox();
            groupBox1 = new GroupBox();
            inpHistoriaPodglad = new CheckBox();
            label12 = new Label();
            inpUzytkownikEytuj = new CheckBox();
            inpUzytkownikPodglad = new CheckBox();
            label11 = new Label();
            inpPodmiotEdycja = new CheckBox();
            inpPodmiotPodglad = new CheckBox();
            label10 = new Label();
            inpMagEdycja = new CheckBox();
            inpMagPodglad = new CheckBox();
            label9 = new Label();
            inpProdEdycja = new CheckBox();
            inpProdPodglad = new CheckBox();
            label8 = new Label();
            inpZamEdycja = new CheckBox();
            inpZamPodglad = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            inpMagazyn = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            inpHaslo2 = new TextBox();
            label5 = new Label();
            inpAktywny = new CheckBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnZapisz);
            panel1.Controls.Add(btnAnuluj);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 399);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 46);
            panel1.TabIndex = 0;
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(328, 11);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(75, 23);
            btnZapisz.TabIndex = 18;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(12, 11);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(75, 23);
            btnAnuluj.TabIndex = 17;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 22);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Login:";
            // 
            // inpLogin
            // 
            inpLogin.Location = new Point(117, 19);
            inpLogin.Name = "inpLogin";
            inpLogin.Size = new Size(286, 23);
            inpLogin.TabIndex = 2;
            // 
            // inpImie
            // 
            inpImie.Location = new Point(117, 48);
            inpImie.Name = "inpImie";
            inpImie.Size = new Size(286, 23);
            inpImie.TabIndex = 3;
            // 
            // inpNazwisko
            // 
            inpNazwisko.Location = new Point(117, 77);
            inpNazwisko.Name = "inpNazwisko";
            inpNazwisko.Size = new Size(286, 23);
            inpNazwisko.TabIndex = 4;
            // 
            // inpHaslo
            // 
            inpHaslo.Location = new Point(117, 106);
            inpHaslo.Name = "inpHaslo";
            inpHaslo.PasswordChar = '*';
            inpHaslo.Size = new Size(286, 23);
            inpHaslo.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(inpHistoriaPodglad);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(inpUzytkownikEytuj);
            groupBox1.Controls.Add(inpUzytkownikPodglad);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(inpPodmiotEdycja);
            groupBox1.Controls.Add(inpPodmiotPodglad);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(inpMagEdycja);
            groupBox1.Controls.Add(inpMagPodglad);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(inpProdEdycja);
            groupBox1.Controls.Add(inpProdPodglad);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(inpZamEdycja);
            groupBox1.Controls.Add(inpZamPodglad);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(inpMagazyn);
            groupBox1.Location = new Point(12, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 199);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uprawnienia";
            // 
            // inpHistoriaPodglad
            // 
            inpHistoriaPodglad.AutoSize = true;
            inpHistoriaPodglad.Location = new Point(105, 176);
            inpHistoriaPodglad.Name = "inpHistoriaPodglad";
            inpHistoriaPodglad.Size = new Size(70, 19);
            inpHistoriaPodglad.TabIndex = 21;
            inpHistoriaPodglad.Text = "podgląd";
            inpHistoriaPodglad.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(43, 177);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 20;
            label12.Text = "Historia:";
            // 
            // inpUzytkownikEytuj
            // 
            inpUzytkownikEytuj.AutoSize = true;
            inpUzytkownikEytuj.Location = new Point(246, 151);
            inpUzytkownikEytuj.Name = "inpUzytkownikEytuj";
            inpUzytkownikEytuj.Size = new Size(60, 19);
            inpUzytkownikEytuj.TabIndex = 19;
            inpUzytkownikEytuj.Text = "edycja";
            inpUzytkownikEytuj.UseVisualStyleBackColor = true;
            // 
            // inpUzytkownikPodglad
            // 
            inpUzytkownikPodglad.AutoSize = true;
            inpUzytkownikPodglad.Location = new Point(105, 151);
            inpUzytkownikPodglad.Name = "inpUzytkownikPodglad";
            inpUzytkownikPodglad.Size = new Size(70, 19);
            inpUzytkownikPodglad.TabIndex = 18;
            inpUzytkownikPodglad.Text = "podgląd";
            inpUzytkownikPodglad.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 152);
            label11.Name = "label11";
            label11.Size = new Size(71, 15);
            label11.TabIndex = 17;
            label11.Text = "Użytkownik:";
            // 
            // inpPodmiotEdycja
            // 
            inpPodmiotEdycja.AutoSize = true;
            inpPodmiotEdycja.Location = new Point(246, 126);
            inpPodmiotEdycja.Name = "inpPodmiotEdycja";
            inpPodmiotEdycja.Size = new Size(60, 19);
            inpPodmiotEdycja.TabIndex = 16;
            inpPodmiotEdycja.Text = "edycja";
            inpPodmiotEdycja.UseVisualStyleBackColor = true;
            // 
            // inpPodmiotPodglad
            // 
            inpPodmiotPodglad.AutoSize = true;
            inpPodmiotPodglad.Location = new Point(105, 126);
            inpPodmiotPodglad.Name = "inpPodmiotPodglad";
            inpPodmiotPodglad.Size = new Size(70, 19);
            inpPodmiotPodglad.TabIndex = 15;
            inpPodmiotPodglad.Text = "podgląd";
            inpPodmiotPodglad.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(43, 127);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 11;
            label10.Text = "Podmiot:";
            // 
            // inpMagEdycja
            // 
            inpMagEdycja.AutoSize = true;
            inpMagEdycja.Location = new Point(246, 101);
            inpMagEdycja.Name = "inpMagEdycja";
            inpMagEdycja.Size = new Size(60, 19);
            inpMagEdycja.TabIndex = 14;
            inpMagEdycja.Text = "edycja";
            inpMagEdycja.UseVisualStyleBackColor = true;
            // 
            // inpMagPodglad
            // 
            inpMagPodglad.AutoSize = true;
            inpMagPodglad.Location = new Point(105, 101);
            inpMagPodglad.Name = "inpMagPodglad";
            inpMagPodglad.Size = new Size(70, 19);
            inpMagPodglad.TabIndex = 13;
            inpMagPodglad.Text = "podgląd";
            inpMagPodglad.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 101);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 8;
            label9.Text = "Magazyn:";
            // 
            // inpProdEdycja
            // 
            inpProdEdycja.AutoSize = true;
            inpProdEdycja.Location = new Point(246, 76);
            inpProdEdycja.Name = "inpProdEdycja";
            inpProdEdycja.Size = new Size(60, 19);
            inpProdEdycja.TabIndex = 12;
            inpProdEdycja.Text = "edycja";
            inpProdEdycja.UseVisualStyleBackColor = true;
            // 
            // inpProdPodglad
            // 
            inpProdPodglad.AutoSize = true;
            inpProdPodglad.Location = new Point(105, 76);
            inpProdPodglad.Name = "inpProdPodglad";
            inpProdPodglad.Size = new Size(70, 19);
            inpProdPodglad.TabIndex = 11;
            inpProdPodglad.Text = "podgląd";
            inpProdPodglad.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 76);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 5;
            label8.Text = "Produkty:";
            // 
            // inpZamEdycja
            // 
            inpZamEdycja.AutoSize = true;
            inpZamEdycja.Location = new Point(246, 51);
            inpZamEdycja.Name = "inpZamEdycja";
            inpZamEdycja.Size = new Size(60, 19);
            inpZamEdycja.TabIndex = 10;
            inpZamEdycja.Text = "edycja";
            inpZamEdycja.UseVisualStyleBackColor = true;
            // 
            // inpZamPodglad
            // 
            inpZamPodglad.AutoSize = true;
            inpZamPodglad.Location = new Point(105, 51);
            inpZamPodglad.Name = "inpZamPodglad";
            inpZamPodglad.Size = new Size(70, 19);
            inpZamPodglad.TabIndex = 9;
            inpZamPodglad.Text = "podgląd";
            inpZamPodglad.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 52);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 2;
            label7.Text = "Zamówienia:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 25);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 1;
            label6.Text = "Magazyn:";
            // 
            // inpMagazyn
            // 
            inpMagazyn.FormattingEnabled = true;
            inpMagazyn.Location = new Point(105, 22);
            inpMagazyn.Name = "inpMagazyn";
            inpMagazyn.Size = new Size(280, 23);
            inpMagazyn.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 51);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 7;
            label2.Text = "Imie:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 80);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Nazwisko:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 109);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 9;
            label4.Text = "Hasło:";
            // 
            // inpHaslo2
            // 
            inpHaslo2.Location = new Point(117, 135);
            inpHaslo2.Name = "inpHaslo2";
            inpHaslo2.PasswordChar = '*';
            inpHaslo2.Size = new Size(286, 23);
            inpHaslo2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 138);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 11;
            label5.Text = "Powtórz hasło:";
            // 
            // inpAktywny
            // 
            inpAktywny.AutoSize = true;
            inpAktywny.Location = new Point(117, 169);
            inpAktywny.Name = "inpAktywny";
            inpAktywny.Size = new Size(72, 19);
            inpAktywny.TabIndex = 7;
            inpAktywny.Text = "Aktywny";
            inpAktywny.UseVisualStyleBackColor = true;
            // 
            // OknoUzytkownika
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnAnuluj;
            ClientSize = new Size(415, 445);
            ControlBox = false;
            Controls.Add(inpAktywny);
            Controls.Add(label5);
            Controls.Add(inpHaslo2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(inpHaslo);
            Controls.Add(inpNazwisko);
            Controls.Add(inpImie);
            Controls.Add(inpLogin);
            Controls.Add(label1);
            Controls.Add(panel1);
            MaximumSize = new Size(431, 484);
            MinimumSize = new Size(431, 484);
            Name = "OknoUzytkownika";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OknoUzytkownika";
            Shown += OknoUzytkownika_Shown;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnZapisz;
        private Button btnAnuluj;
        private Label label1;
        private TextBox inpLogin;
        private TextBox inpImie;
        private TextBox inpNazwisko;
        private TextBox inpHaslo;
        private GroupBox groupBox1;
        private CheckBox inpPodmiotEdycja;
        private CheckBox inpPodmiotPodglad;
        private Label label10;
        private CheckBox inpMagEdycja;
        private CheckBox inpMagPodglad;
        private Label label9;
        private CheckBox inpProdEdycja;
        private CheckBox inpProdPodglad;
        private Label label8;
        private CheckBox inpZamEdycja;
        private CheckBox inpZamPodglad;
        private Label label7;
        private Label label6;
        private ComboBox inpMagazyn;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox inpHaslo2;
        private Label label5;
        private CheckBox inpAktywny;
        private CheckBox inpHistoriaPodglad;
        private Label label12;
        private CheckBox inpUzytkownikEytuj;
        private CheckBox inpUzytkownikPodglad;
        private Label label11;
    }
}