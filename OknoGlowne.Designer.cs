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
            this.btnUsunZamowienie = new System.Windows.Forms.Button();
            this.btnEdytujZamowienie = new System.Windows.Forms.Button();
            this.btnDodajZamowienia = new System.Windows.Forms.Button();
            this.tabZamowieniaDoDostawcow = new System.Windows.Forms.TabPage();
            this.btnUsunZamDost = new System.Windows.Forms.Button();
            this.btnEdytujZamDost = new System.Windows.Forms.Button();
            this.btnDodajZamDost = new System.Windows.Forms.Button();
            this.tabMagazyny = new System.Windows.Forms.TabPage();
            this.btnUsunMagazyny = new System.Windows.Forms.Button();
            this.btnEdytujMagazyny = new System.Windows.Forms.Button();
            this.btnDodajMagazyny = new System.Windows.Forms.Button();
            this.tabProdukty = new System.Windows.Forms.TabPage();
            this.btnUsunProdukty = new System.Windows.Forms.Button();
            this.btnEdytujProdukty = new System.Windows.Forms.Button();
            this.btnDodajProdukty = new System.Windows.Forms.Button();
            this.tabPodmioty = new System.Windows.Forms.TabPage();
            this.btnUsunPodmioty = new System.Windows.Forms.Button();
            this.btnEdytujPodmioty = new System.Windows.Forms.Button();
            this.btnDodajPodmioty = new System.Windows.Forms.Button();
            this.tabStatusy = new System.Windows.Forms.TabPage();
            this.btnUsunStatusy = new System.Windows.Forms.Button();
            this.btnEdytujStatusy = new System.Windows.Forms.Button();
            this.btnDodajStatusy = new System.Windows.Forms.Button();
            this.tabUzytkownicy = new System.Windows.Forms.TabPage();
            this.btnUsunUzytk = new System.Windows.Forms.Button();
            this.btnEdytujUzytk = new System.Windows.Forms.Button();
            this.btnDodajUzytk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabZamowieniaTab = new System.Windows.Forms.TabPage();
            this.tabZamowieniaDoDostawcowTab = new System.Windows.Forms.TabPage();
            this.tabMagazynTab = new System.Windows.Forms.TabPage();
            this.tabProduktyTab = new System.Windows.Forms.TabPage();
            this.tabPodmiotyTab = new System.Windows.Forms.TabPage();
            this.tabStatusyTab = new System.Windows.Forms.TabPage();
            this.tabUzytkownikTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imię = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktywny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabZamowienia.SuspendLayout();
            this.tabZamowieniaDoDostawcow.SuspendLayout();
            this.tabMagazyny.SuspendLayout();
            this.tabProdukty.SuspendLayout();
            this.tabPodmioty.SuspendLayout();
            this.tabStatusy.SuspendLayout();
            this.tabUzytkownicy.SuspendLayout();
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
            this.tabZamowienia.Controls.Add(this.btnUsunZamowienie);
            this.tabZamowienia.Controls.Add(this.btnEdytujZamowienie);
            this.tabZamowienia.Controls.Add(this.btnDodajZamowienia);
            this.tabZamowienia.Location = new System.Drawing.Point(4, 24);
            this.tabZamowienia.Name = "tabZamowienia";
            this.tabZamowienia.Padding = new System.Windows.Forms.Padding(3);
            this.tabZamowienia.Size = new System.Drawing.Size(968, 60);
            this.tabZamowienia.TabIndex = 0;
            this.tabZamowienia.Text = "Zamówienia";
            this.tabZamowienia.UseVisualStyleBackColor = true;
            // 
            // btnUsunZamowienie
            // 
            this.btnUsunZamowienie.Location = new System.Drawing.Point(152, 6);
            this.btnUsunZamowienie.Name = "btnUsunZamowienie";
            this.btnUsunZamowienie.Size = new System.Drawing.Size(66, 48);
            this.btnUsunZamowienie.TabIndex = 2;
            this.btnUsunZamowienie.Text = "Usuń";
            this.btnUsunZamowienie.UseVisualStyleBackColor = true;
            // 
            // btnEdytujZamowienie
            // 
            this.btnEdytujZamowienie.Location = new System.Drawing.Point(80, 6);
            this.btnEdytujZamowienie.Name = "btnEdytujZamowienie";
            this.btnEdytujZamowienie.Size = new System.Drawing.Size(66, 48);
            this.btnEdytujZamowienie.TabIndex = 1;
            this.btnEdytujZamowienie.Text = "Edytuj";
            this.btnEdytujZamowienie.UseVisualStyleBackColor = true;
            // 
            // btnDodajZamowienia
            // 
            this.btnDodajZamowienia.Location = new System.Drawing.Point(8, 6);
            this.btnDodajZamowienia.Name = "btnDodajZamowienia";
            this.btnDodajZamowienia.Size = new System.Drawing.Size(66, 48);
            this.btnDodajZamowienia.TabIndex = 0;
            this.btnDodajZamowienia.Text = "Dodaj";
            this.btnDodajZamowienia.UseVisualStyleBackColor = true;
            // 
            // tabZamowieniaDoDostawcow
            // 
            this.tabZamowieniaDoDostawcow.Controls.Add(this.btnUsunZamDost);
            this.tabZamowieniaDoDostawcow.Controls.Add(this.btnEdytujZamDost);
            this.tabZamowieniaDoDostawcow.Controls.Add(this.btnDodajZamDost);
            this.tabZamowieniaDoDostawcow.Location = new System.Drawing.Point(4, 24);
            this.tabZamowieniaDoDostawcow.Name = "tabZamowieniaDoDostawcow";
            this.tabZamowieniaDoDostawcow.Padding = new System.Windows.Forms.Padding(3);
            this.tabZamowieniaDoDostawcow.Size = new System.Drawing.Size(968, 60);
            this.tabZamowieniaDoDostawcow.TabIndex = 1;
            this.tabZamowieniaDoDostawcow.Text = "Zamówienia do dostawców";
            this.tabZamowieniaDoDostawcow.UseVisualStyleBackColor = true;
            // 
            // btnUsunZamDost
            // 
            this.btnUsunZamDost.Location = new System.Drawing.Point(151, 6);
            this.btnUsunZamDost.Name = "btnUsunZamDost";
            this.btnUsunZamDost.Size = new System.Drawing.Size(66, 48);
            this.btnUsunZamDost.TabIndex = 5;
            this.btnUsunZamDost.Text = "Usuń";
            this.btnUsunZamDost.UseVisualStyleBackColor = true;
            // 
            // btnEdytujZamDost
            // 
            this.btnEdytujZamDost.Location = new System.Drawing.Point(79, 6);
            this.btnEdytujZamDost.Name = "btnEdytujZamDost";
            this.btnEdytujZamDost.Size = new System.Drawing.Size(66, 48);
            this.btnEdytujZamDost.TabIndex = 4;
            this.btnEdytujZamDost.Text = "Edytuj";
            this.btnEdytujZamDost.UseVisualStyleBackColor = true;
            // 
            // btnDodajZamDost
            // 
            this.btnDodajZamDost.Location = new System.Drawing.Point(7, 6);
            this.btnDodajZamDost.Name = "btnDodajZamDost";
            this.btnDodajZamDost.Size = new System.Drawing.Size(66, 48);
            this.btnDodajZamDost.TabIndex = 3;
            this.btnDodajZamDost.Text = "Dodaj";
            this.btnDodajZamDost.UseVisualStyleBackColor = true;
            // 
            // tabMagazyny
            // 
            this.tabMagazyny.Controls.Add(this.btnUsunMagazyny);
            this.tabMagazyny.Controls.Add(this.btnEdytujMagazyny);
            this.tabMagazyny.Controls.Add(this.btnDodajMagazyny);
            this.tabMagazyny.Location = new System.Drawing.Point(4, 24);
            this.tabMagazyny.Name = "tabMagazyny";
            this.tabMagazyny.Size = new System.Drawing.Size(968, 60);
            this.tabMagazyny.TabIndex = 2;
            this.tabMagazyny.Text = "Magazyny";
            this.tabMagazyny.UseVisualStyleBackColor = true;
            // 
            // btnUsunMagazyny
            // 
            this.btnUsunMagazyny.Location = new System.Drawing.Point(152, 9);
            this.btnUsunMagazyny.Name = "btnUsunMagazyny";
            this.btnUsunMagazyny.Size = new System.Drawing.Size(66, 48);
            this.btnUsunMagazyny.TabIndex = 5;
            this.btnUsunMagazyny.Text = "Usuń";
            this.btnUsunMagazyny.UseVisualStyleBackColor = true;
            // 
            // btnEdytujMagazyny
            // 
            this.btnEdytujMagazyny.Location = new System.Drawing.Point(80, 9);
            this.btnEdytujMagazyny.Name = "btnEdytujMagazyny";
            this.btnEdytujMagazyny.Size = new System.Drawing.Size(66, 48);
            this.btnEdytujMagazyny.TabIndex = 4;
            this.btnEdytujMagazyny.Text = "Edytuj";
            this.btnEdytujMagazyny.UseVisualStyleBackColor = true;
            // 
            // btnDodajMagazyny
            // 
            this.btnDodajMagazyny.Location = new System.Drawing.Point(8, 9);
            this.btnDodajMagazyny.Name = "btnDodajMagazyny";
            this.btnDodajMagazyny.Size = new System.Drawing.Size(66, 48);
            this.btnDodajMagazyny.TabIndex = 3;
            this.btnDodajMagazyny.Text = "Dodaj";
            this.btnDodajMagazyny.UseVisualStyleBackColor = true;
            this.btnDodajMagazyny.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabProdukty
            // 
            this.tabProdukty.Controls.Add(this.btnUsunProdukty);
            this.tabProdukty.Controls.Add(this.btnEdytujProdukty);
            this.tabProdukty.Controls.Add(this.btnDodajProdukty);
            this.tabProdukty.Location = new System.Drawing.Point(4, 24);
            this.tabProdukty.Name = "tabProdukty";
            this.tabProdukty.Size = new System.Drawing.Size(968, 60);
            this.tabProdukty.TabIndex = 3;
            this.tabProdukty.Text = "Produkty";
            this.tabProdukty.UseVisualStyleBackColor = true;
            // 
            // btnUsunProdukty
            // 
            this.btnUsunProdukty.Location = new System.Drawing.Point(152, 9);
            this.btnUsunProdukty.Name = "btnUsunProdukty";
            this.btnUsunProdukty.Size = new System.Drawing.Size(66, 48);
            this.btnUsunProdukty.TabIndex = 5;
            this.btnUsunProdukty.Text = "Usuń";
            this.btnUsunProdukty.UseVisualStyleBackColor = true;
            // 
            // btnEdytujProdukty
            // 
            this.btnEdytujProdukty.Location = new System.Drawing.Point(80, 9);
            this.btnEdytujProdukty.Name = "btnEdytujProdukty";
            this.btnEdytujProdukty.Size = new System.Drawing.Size(66, 48);
            this.btnEdytujProdukty.TabIndex = 4;
            this.btnEdytujProdukty.Text = "Edytuj";
            this.btnEdytujProdukty.UseVisualStyleBackColor = true;
            // 
            // btnDodajProdukty
            // 
            this.btnDodajProdukty.Location = new System.Drawing.Point(8, 9);
            this.btnDodajProdukty.Name = "btnDodajProdukty";
            this.btnDodajProdukty.Size = new System.Drawing.Size(66, 48);
            this.btnDodajProdukty.TabIndex = 3;
            this.btnDodajProdukty.Text = "Dodaj";
            this.btnDodajProdukty.UseVisualStyleBackColor = true;
            // 
            // tabPodmioty
            // 
            this.tabPodmioty.Controls.Add(this.btnUsunPodmioty);
            this.tabPodmioty.Controls.Add(this.btnEdytujPodmioty);
            this.tabPodmioty.Controls.Add(this.btnDodajPodmioty);
            this.tabPodmioty.Location = new System.Drawing.Point(4, 24);
            this.tabPodmioty.Name = "tabPodmioty";
            this.tabPodmioty.Size = new System.Drawing.Size(968, 60);
            this.tabPodmioty.TabIndex = 4;
            this.tabPodmioty.Text = "Podmioty";
            this.tabPodmioty.UseVisualStyleBackColor = true;
            // 
            // btnUsunPodmioty
            // 
            this.btnUsunPodmioty.Location = new System.Drawing.Point(152, 9);
            this.btnUsunPodmioty.Name = "btnUsunPodmioty";
            this.btnUsunPodmioty.Size = new System.Drawing.Size(66, 48);
            this.btnUsunPodmioty.TabIndex = 5;
            this.btnUsunPodmioty.Text = "Usuń";
            this.btnUsunPodmioty.UseVisualStyleBackColor = true;
            // 
            // btnEdytujPodmioty
            // 
            this.btnEdytujPodmioty.Location = new System.Drawing.Point(80, 9);
            this.btnEdytujPodmioty.Name = "btnEdytujPodmioty";
            this.btnEdytujPodmioty.Size = new System.Drawing.Size(66, 48);
            this.btnEdytujPodmioty.TabIndex = 4;
            this.btnEdytujPodmioty.Text = "Edytuj";
            this.btnEdytujPodmioty.UseVisualStyleBackColor = true;
            // 
            // btnDodajPodmioty
            // 
            this.btnDodajPodmioty.Location = new System.Drawing.Point(8, 9);
            this.btnDodajPodmioty.Name = "btnDodajPodmioty";
            this.btnDodajPodmioty.Size = new System.Drawing.Size(66, 48);
            this.btnDodajPodmioty.TabIndex = 3;
            this.btnDodajPodmioty.Text = "Dodaj";
            this.btnDodajPodmioty.UseVisualStyleBackColor = true;
            // 
            // tabStatusy
            // 
            this.tabStatusy.Controls.Add(this.btnUsunStatusy);
            this.tabStatusy.Controls.Add(this.btnEdytujStatusy);
            this.tabStatusy.Controls.Add(this.btnDodajStatusy);
            this.tabStatusy.Location = new System.Drawing.Point(4, 24);
            this.tabStatusy.Name = "tabStatusy";
            this.tabStatusy.Size = new System.Drawing.Size(968, 60);
            this.tabStatusy.TabIndex = 5;
            this.tabStatusy.Text = "Statusy";
            this.tabStatusy.UseVisualStyleBackColor = true;
            // 
            // btnUsunStatusy
            // 
            this.btnUsunStatusy.Location = new System.Drawing.Point(152, 9);
            this.btnUsunStatusy.Name = "btnUsunStatusy";
            this.btnUsunStatusy.Size = new System.Drawing.Size(66, 48);
            this.btnUsunStatusy.TabIndex = 5;
            this.btnUsunStatusy.Text = "Usuń";
            this.btnUsunStatusy.UseVisualStyleBackColor = true;
            // 
            // btnEdytujStatusy
            // 
            this.btnEdytujStatusy.Location = new System.Drawing.Point(80, 9);
            this.btnEdytujStatusy.Name = "btnEdytujStatusy";
            this.btnEdytujStatusy.Size = new System.Drawing.Size(66, 48);
            this.btnEdytujStatusy.TabIndex = 4;
            this.btnEdytujStatusy.Text = "Edytuj";
            this.btnEdytujStatusy.UseVisualStyleBackColor = true;
            // 
            // btnDodajStatusy
            // 
            this.btnDodajStatusy.Location = new System.Drawing.Point(8, 9);
            this.btnDodajStatusy.Name = "btnDodajStatusy";
            this.btnDodajStatusy.Size = new System.Drawing.Size(66, 48);
            this.btnDodajStatusy.TabIndex = 3;
            this.btnDodajStatusy.Text = "Dodaj";
            this.btnDodajStatusy.UseVisualStyleBackColor = true;
            // 
            // tabUzytkownicy
            // 
            this.tabUzytkownicy.Controls.Add(this.btnUsunUzytk);
            this.tabUzytkownicy.Controls.Add(this.btnEdytujUzytk);
            this.tabUzytkownicy.Controls.Add(this.btnDodajUzytk);
            this.tabUzytkownicy.Location = new System.Drawing.Point(4, 24);
            this.tabUzytkownicy.Name = "tabUzytkownicy";
            this.tabUzytkownicy.Size = new System.Drawing.Size(968, 60);
            this.tabUzytkownicy.TabIndex = 6;
            this.tabUzytkownicy.Text = "Użytkownicy";
            this.tabUzytkownicy.UseVisualStyleBackColor = true;
            // 
            // btnUsunUzytk
            // 
            this.btnUsunUzytk.Location = new System.Drawing.Point(152, 9);
            this.btnUsunUzytk.Name = "btnUsunUzytk";
            this.btnUsunUzytk.Size = new System.Drawing.Size(66, 48);
            this.btnUsunUzytk.TabIndex = 5;
            this.btnUsunUzytk.Text = "Usuń";
            this.btnUsunUzytk.UseVisualStyleBackColor = true;
            // 
            // btnEdytujUzytk
            // 
            this.btnEdytujUzytk.Location = new System.Drawing.Point(80, 9);
            this.btnEdytujUzytk.Name = "btnEdytujUzytk";
            this.btnEdytujUzytk.Size = new System.Drawing.Size(66, 48);
            this.btnEdytujUzytk.TabIndex = 4;
            this.btnEdytujUzytk.Text = "Edytuj";
            this.btnEdytujUzytk.UseVisualStyleBackColor = true;
            // 
            // btnDodajUzytk
            // 
            this.btnDodajUzytk.Location = new System.Drawing.Point(8, 9);
            this.btnDodajUzytk.Name = "btnDodajUzytk";
            this.btnDodajUzytk.Size = new System.Drawing.Size(66, 48);
            this.btnDodajUzytk.TabIndex = 3;
            this.btnDodajUzytk.Text = "Dodaj";
            this.btnDodajUzytk.UseVisualStyleBackColor = true;
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
            this.tabControl2.Controls.Add(this.tabMagazynTab);
            this.tabControl2.Controls.Add(this.tabProduktyTab);
            this.tabControl2.Controls.Add(this.tabPodmiotyTab);
            this.tabControl2.Controls.Add(this.tabStatusyTab);
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
            // tabMagazynTab
            // 
            this.tabMagazynTab.Location = new System.Drawing.Point(4, 24);
            this.tabMagazynTab.Name = "tabMagazynTab";
            this.tabMagazynTab.Padding = new System.Windows.Forms.Padding(3);
            this.tabMagazynTab.Size = new System.Drawing.Size(968, 312);
            this.tabMagazynTab.TabIndex = 3;
            this.tabMagazynTab.Text = "Magazyny";
            this.tabMagazynTab.UseVisualStyleBackColor = true;
            // 
            // tabProduktyTab
            // 
            this.tabProduktyTab.Location = new System.Drawing.Point(4, 24);
            this.tabProduktyTab.Name = "tabProduktyTab";
            this.tabProduktyTab.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduktyTab.Size = new System.Drawing.Size(968, 312);
            this.tabProduktyTab.TabIndex = 4;
            this.tabProduktyTab.Text = "Produkty";
            this.tabProduktyTab.UseVisualStyleBackColor = true;
            // 
            // tabPodmiotyTab
            // 
            this.tabPodmiotyTab.Location = new System.Drawing.Point(4, 24);
            this.tabPodmiotyTab.Name = "tabPodmiotyTab";
            this.tabPodmiotyTab.Padding = new System.Windows.Forms.Padding(3);
            this.tabPodmiotyTab.Size = new System.Drawing.Size(968, 312);
            this.tabPodmiotyTab.TabIndex = 5;
            this.tabPodmiotyTab.Text = "Podmioty";
            this.tabPodmiotyTab.UseVisualStyleBackColor = true;
            // 
            // tabStatusyTab
            // 
            this.tabStatusyTab.Location = new System.Drawing.Point(4, 24);
            this.tabStatusyTab.Name = "tabStatusyTab";
            this.tabStatusyTab.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatusyTab.Size = new System.Drawing.Size(968, 312);
            this.tabStatusyTab.TabIndex = 6;
            this.tabStatusyTab.Text = "Statusy";
            this.tabStatusyTab.UseVisualStyleBackColor = true;
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
            this.tabZamowieniaDoDostawcow.ResumeLayout(false);
            this.tabMagazyny.ResumeLayout(false);
            this.tabProdukty.ResumeLayout(false);
            this.tabPodmioty.ResumeLayout(false);
            this.tabStatusy.ResumeLayout(false);
            this.tabUzytkownicy.ResumeLayout(false);
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
        private Button btnDodajZamowienia;
        private Button btnUsunZamowienie;
        private Button btnEdytujZamowienie;
        private TabPage tabMagazynTab;
        private TabPage tabProduktyTab;
        private TabPage tabPodmiotyTab;
        private TabPage tabStatusyTab;
        private Button btnUsunZamDost;
        private Button btnEdytujZamDost;
        private Button btnDodajZamDost;
        private Button btnUsunMagazyny;
        private Button btnEdytujMagazyny;
        private Button btnDodajMagazyny;
        private Button btnUsunProdukty;
        private Button btnEdytujProdukty;
        private Button btnDodajProdukty;
        private Button btnUsunPodmioty;
        private Button btnEdytujPodmioty;
        private Button btnDodajPodmioty;
        private Button btnUsunStatusy;
        private Button btnEdytujStatusy;
        private Button btnDodajStatusy;
        private Button btnUsunUzytk;
        private Button btnEdytujUzytk;
        private Button btnDodajUzytk;
    }
}