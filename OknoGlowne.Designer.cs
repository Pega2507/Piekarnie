namespace Piekarnie
{
    partial class OknoGlowne
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbFootUzytkownik = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabZamowienia = new System.Windows.Forms.TabPage();
            this.tabZamowieniaDoDostawcow = new System.Windows.Forms.TabPage();
            this.tabMagazyny = new System.Windows.Forms.TabPage();
            this.tabProdukty = new System.Windows.Forms.TabPage();
            this.tabPodmioty = new System.Windows.Forms.TabPage();
            this.tabStatusy = new System.Windows.Forms.TabPage();
            this.tabUzytkownicy = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabZamowieniaTab = new System.Windows.Forms.TabPage();
            this.tabZamowieniaDoDostawcowTab = new System.Windows.Forms.TabPage();
            this.tabUzytkownikTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imię = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktywny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabZamowienia.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabUzytkownikTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbFootUzytkownik});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(976, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabel1.Text = "Użytkownik:";
            // 
            // lbFootUzytkownik
            // 
            this.lbFootUzytkownik.Name = "lbFootUzytkownik";
            this.lbFootUzytkownik.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabZamowienia);
            this.tabControl1.Controls.Add(this.tabZamowieniaDoDostawcow);
            this.tabControl1.Controls.Add(this.tabMagazyny);
            this.tabControl1.Controls.Add(this.tabProdukty);
            this.tabControl1.Controls.Add(this.tabPodmioty);
            this.tabControl1.Controls.Add(this.tabStatusy);
            this.tabControl1.Controls.Add(this.tabUzytkownicy);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 88);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabZamowienia
            // 
            this.tabZamowienia.Controls.Add(this.button1);
            this.tabZamowienia.Location = new System.Drawing.Point(4, 24);
            this.tabZamowienia.Name = "tabZamowienia";
            this.tabZamowienia.Padding = new System.Windows.Forms.Padding(3);
            this.tabZamowienia.Size = new System.Drawing.Size(968, 60);
            this.tabZamowienia.TabIndex = 0;
            this.tabZamowienia.Text = "Zamówienia";
            this.tabZamowienia.UseVisualStyleBackColor = true;
            // 
            // tabZamowieniaDoDostawcow
            // 
            this.tabZamowieniaDoDostawcow.Location = new System.Drawing.Point(4, 24);
            this.tabZamowieniaDoDostawcow.Name = "tabZamowieniaDoDostawcow";
            this.tabZamowieniaDoDostawcow.Padding = new System.Windows.Forms.Padding(3);
            this.tabZamowieniaDoDostawcow.Size = new System.Drawing.Size(968, 60);
            this.tabZamowieniaDoDostawcow.TabIndex = 1;
            this.tabZamowieniaDoDostawcow.Text = "Zamówienia do dostawców";
            this.tabZamowieniaDoDostawcow.UseVisualStyleBackColor = true;
            // 
            // tabMagazyny
            // 
            this.tabMagazyny.Location = new System.Drawing.Point(4, 24);
            this.tabMagazyny.Name = "tabMagazyny";
            this.tabMagazyny.Size = new System.Drawing.Size(968, 60);
            this.tabMagazyny.TabIndex = 2;
            this.tabMagazyny.Text = "Magazyny";
            this.tabMagazyny.UseVisualStyleBackColor = true;
            // 
            // tabProdukty
            // 
            this.tabProdukty.Location = new System.Drawing.Point(4, 24);
            this.tabProdukty.Name = "tabProdukty";
            this.tabProdukty.Size = new System.Drawing.Size(968, 60);
            this.tabProdukty.TabIndex = 3;
            this.tabProdukty.Text = "Produkty";
            this.tabProdukty.UseVisualStyleBackColor = true;
            // 
            // tabPodmioty
            // 
            this.tabPodmioty.Location = new System.Drawing.Point(4, 24);
            this.tabPodmioty.Name = "tabPodmioty";
            this.tabPodmioty.Size = new System.Drawing.Size(968, 60);
            this.tabPodmioty.TabIndex = 4;
            this.tabPodmioty.Text = "Podmioty";
            this.tabPodmioty.UseVisualStyleBackColor = true;
            // 
            // tabStatusy
            // 
            this.tabStatusy.Location = new System.Drawing.Point(4, 24);
            this.tabStatusy.Name = "tabStatusy";
            this.tabStatusy.Size = new System.Drawing.Size(968, 60);
            this.tabStatusy.TabIndex = 5;
            this.tabStatusy.Text = "Statusy";
            this.tabStatusy.UseVisualStyleBackColor = true;
            // 
            // tabUzytkownicy
            // 
            this.tabUzytkownicy.Location = new System.Drawing.Point(4, 24);
            this.tabUzytkownicy.Name = "tabUzytkownicy";
            this.tabUzytkownicy.Size = new System.Drawing.Size(968, 60);
            this.tabUzytkownicy.TabIndex = 6;
            this.tabUzytkownicy.Text = "Użytkownicy";
            this.tabUzytkownicy.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 340);
            this.panel1.TabIndex = 2;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabZamowieniaTab);
            this.tabControl2.Controls.Add(this.tabZamowieniaDoDostawcowTab);
            this.tabControl2.Controls.Add(this.tabUzytkownikTab);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(976, 340);
            this.tabControl2.TabIndex = 0;
            // 
            // tabZamowieniaTab
            // 
            this.tabZamowieniaTab.Location = new System.Drawing.Point(4, 24);
            this.tabZamowieniaTab.Name = "tabZamowieniaTab";
            this.tabZamowieniaTab.Padding = new System.Windows.Forms.Padding(3);
            this.tabZamowieniaTab.Size = new System.Drawing.Size(968, 312);
            this.tabZamowieniaTab.TabIndex = 0;
            this.tabZamowieniaTab.Text = "Zamówienia";
            this.tabZamowieniaTab.UseVisualStyleBackColor = true;
            // 
            // tabZamowieniaDoDostawcowTab
            // 
            this.tabZamowieniaDoDostawcowTab.Location = new System.Drawing.Point(4, 24);
            this.tabZamowieniaDoDostawcowTab.Name = "tabZamowieniaDoDostawcowTab";
            this.tabZamowieniaDoDostawcowTab.Padding = new System.Windows.Forms.Padding(3);
            this.tabZamowieniaDoDostawcowTab.Size = new System.Drawing.Size(968, 312);
            this.tabZamowieniaDoDostawcowTab.TabIndex = 1;
            this.tabZamowieniaDoDostawcowTab.Text = "Zamówienia do dostawców";
            this.tabZamowieniaDoDostawcowTab.UseVisualStyleBackColor = true;
            // 
            // tabUzytkownikTab
            // 
            this.tabUzytkownikTab.Controls.Add(this.dataGridView1);
            this.tabUzytkownikTab.Location = new System.Drawing.Point(4, 24);
            this.tabUzytkownikTab.Name = "tabUzytkownikTab";
            this.tabUzytkownikTab.Size = new System.Drawing.Size(968, 312);
            this.tabUzytkownikTab.TabIndex = 2;
            this.tabUzytkownikTab.Text = "Użytkownik";
            this.tabUzytkownikTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(968, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Login
            // 
            this.Login.Frozen = true;
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Imię
            // 
            this.Imię.HeaderText = "Imie";
            this.Imię.Name = "Imię";
            this.Imię.ReadOnly = true;
            // 
            // Nazwisko
            // 
            this.Nazwisko.HeaderText = "Nazwisko";
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.ReadOnly = true;
            // 
            // Aktywny
            // 
            this.Aktywny.HeaderText = "Aktywny";
            this.Aktywny.Name = "Aktywny";
            this.Aktywny.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "OknoGlowne";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabZamowienia.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabUzytkownikTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lbFootUzytkownik;
        private TabControl tabControl1;
        private TabPage tabZamowienia;
        private TabPage tabZamowieniaDoDostawcow;
        private Panel panel1;
        private TabPage tabMagazyny;
        private TabPage tabProdukty;
        private TabPage tabPodmioty;
        private TabPage tabStatusy;
        private TabPage tabUzytkownicy;
        private TabControl tabControl2;
        private TabPage tabZamowieniaTab;
        private TabPage tabZamowieniaDoDostawcowTab;
        private TabPage tabUzytkownikTab;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn Imię;
        private DataGridViewTextBoxColumn Nazwisko;
        private DataGridViewTextBoxColumn Aktywny;
        private Button button1;
    }
}