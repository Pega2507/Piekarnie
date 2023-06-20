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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lbFootUzytkownik = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lbFootMagazyn = new ToolStripStatusLabel();
            tabControl1 = new TabControl();
            tabZamowienia = new TabPage();
            label1 = new Label();
            inpZmienMagazyn = new ComboBox();
            btnUsunZamowienie = new Button();
            btnEdytujZamowienie = new Button();
            btnDodajZamowienia = new Button();
            tabZamowieniaDoDostawcow = new TabPage();
            btnUsunZamDost = new Button();
            btnEdytujZamDost = new Button();
            btnDodajZamDost = new Button();
            tabMagazyny = new TabPage();
            btnUsunMagazyny = new Button();
            btnEdytujMagazyny = new Button();
            btnDodajMagazyny = new Button();
            tabProdukty = new TabPage();
            btnUsunProdukty = new Button();
            btnEdytujProdukty = new Button();
            btnDodajProdukty = new Button();
            tabPodmioty = new TabPage();
            label2 = new Label();
            inpTypPodmiotu = new ComboBox();
            btnUsunPodmioty = new Button();
            btnEdytujPodmioty = new Button();
            btnDodajPodmioty = new Button();
            tabStatusy = new TabPage();
            btnUsunStatusy = new Button();
            btnEdytujStatusy = new Button();
            btnDodajStatusy = new Button();
            tabUzytkownicy = new TabPage();
            btnUsunUzytk = new Button();
            btnEdytujUzytk = new Button();
            btnDodajUzytk = new Button();
            panel1 = new Panel();
            tabControl2 = new TabControl();
            tabZamowieniaTab = new TabPage();
            dataGridViewZamowienia = new DataGridView();
            zamID = new DataGridViewTextBoxColumn();
            zamData = new DataGridViewTextBoxColumn();
            zamPodmiotId = new DataGridViewTextBoxColumn();
            zamStatusId = new DataGridViewTextBoxColumn();
            zamPodmiot = new DataGridViewTextBoxColumn();
            zamStatus = new DataGridViewTextBoxColumn();
            tabZamowieniaDoDostawcowTab = new TabPage();
            dataGridViewZamowieniaDostawcy = new DataGridView();
            zamdID = new DataGridViewTextBoxColumn();
            zamdData = new DataGridViewTextBoxColumn();
            zamdPodmiotId = new DataGridViewTextBoxColumn();
            zamdStatusId = new DataGridViewTextBoxColumn();
            zamdPodmiot = new DataGridViewTextBoxColumn();
            zamdStatus = new DataGridViewTextBoxColumn();
            tabMagazynTab = new TabPage();
            dataGridViewMagazyny = new DataGridView();
            tabProduktyTab = new TabPage();
            dataGridViewProdukty = new DataGridView();
            prID = new DataGridViewTextBoxColumn();
            prNazwa = new DataGridViewTextBoxColumn();
            tabPodmiotyTab = new TabPage();
            dataGridViewPodmioty = new DataGridView();
            pdId = new DataGridViewTextBoxColumn();
            pdNazwa = new DataGridViewTextBoxColumn();
            pdAdres = new DataGridViewTextBoxColumn();
            pdTelefon = new DataGridViewTextBoxColumn();
            tabStatusyTab = new TabPage();
            dataGridViewStatusy = new DataGridView();
            stID = new DataGridViewTextBoxColumn();
            stNazwa = new DataGridViewTextBoxColumn();
            tabUzytkownikTab = new TabPage();
            dataGridViewUzytkownik = new DataGridView();
            uzID = new DataGridViewTextBoxColumn();
            uzLogin = new DataGridViewTextBoxColumn();
            uzImie = new DataGridViewTextBoxColumn();
            uzNazwisko = new DataGridViewTextBoxColumn();
            uzAktywny = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            Imię = new DataGridViewTextBoxColumn();
            Nazwisko = new DataGridViewTextBoxColumn();
            Aktywny = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            mgID = new DataGridViewTextBoxColumn();
            mgNazwa = new DataGridViewTextBoxColumn();
            mgPiekarniaId = new DataGridViewTextBoxColumn();
            mgPiekarnia = new DataGridViewTextBoxColumn();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabZamowienia.SuspendLayout();
            tabZamowieniaDoDostawcow.SuspendLayout();
            tabMagazyny.SuspendLayout();
            tabProdukty.SuspendLayout();
            tabPodmioty.SuspendLayout();
            tabStatusy.SuspendLayout();
            tabUzytkownicy.SuspendLayout();
            panel1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabZamowieniaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewZamowienia).BeginInit();
            tabZamowieniaDoDostawcowTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewZamowieniaDostawcy).BeginInit();
            tabMagazynTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMagazyny).BeginInit();
            tabProduktyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdukty).BeginInit();
            tabPodmiotyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPodmioty).BeginInit();
            tabStatusyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatusy).BeginInit();
            tabUzytkownikTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUzytkownik).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lbFootUzytkownik, toolStripStatusLabel2, lbFootMagazyn });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(976, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(71, 17);
            toolStripStatusLabel1.Text = "Użytkownik:";
            // 
            // lbFootUzytkownik
            // 
            lbFootUzytkownik.Name = "lbFootUzytkownik";
            lbFootUzytkownik.Size = new Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(58, 17);
            toolStripStatusLabel2.Text = "Magazyn:";
            // 
            // lbFootMagazyn
            // 
            lbFootMagazyn.Name = "lbFootMagazyn";
            lbFootMagazyn.Size = new Size(0, 17);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabZamowienia);
            tabControl1.Controls.Add(tabZamowieniaDoDostawcow);
            tabControl1.Controls.Add(tabMagazyny);
            tabControl1.Controls.Add(tabProdukty);
            tabControl1.Controls.Add(tabPodmioty);
            tabControl1.Controls.Add(tabStatusy);
            tabControl1.Controls.Add(tabUzytkownicy);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(976, 88);
            tabControl1.TabIndex = 1;
            tabControl1.Click += tabControl1_SelectedIndexChanged;
            // 
            // tabZamowienia
            // 
            tabZamowienia.Controls.Add(label1);
            tabZamowienia.Controls.Add(inpZmienMagazyn);
            tabZamowienia.Controls.Add(btnUsunZamowienie);
            tabZamowienia.Controls.Add(btnEdytujZamowienie);
            tabZamowienia.Controls.Add(btnDodajZamowienia);
            tabZamowienia.Location = new Point(4, 24);
            tabZamowienia.Name = "tabZamowienia";
            tabZamowienia.Padding = new Padding(3);
            tabZamowienia.Size = new Size(968, 60);
            tabZamowienia.TabIndex = 0;
            tabZamowienia.Text = "Zamówienia";
            tabZamowienia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 6);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 4;
            label1.Text = "Magazyn:";
            // 
            // inpZmienMagazyn
            // 
            inpZmienMagazyn.FormattingEnabled = true;
            inpZmienMagazyn.Location = new Point(314, 31);
            inpZmienMagazyn.Name = "inpZmienMagazyn";
            inpZmienMagazyn.Size = new Size(161, 23);
            inpZmienMagazyn.TabIndex = 3;
            // 
            // btnUsunZamowienie
            // 
            btnUsunZamowienie.Location = new Point(152, 6);
            btnUsunZamowienie.Name = "btnUsunZamowienie";
            btnUsunZamowienie.Size = new Size(66, 48);
            btnUsunZamowienie.TabIndex = 2;
            btnUsunZamowienie.Text = "Usuń";
            btnUsunZamowienie.UseVisualStyleBackColor = true;
            btnUsunZamowienie.Click += btnUsunZamowienie_Click;
            // 
            // btnEdytujZamowienie
            // 
            btnEdytujZamowienie.Location = new Point(80, 6);
            btnEdytujZamowienie.Name = "btnEdytujZamowienie";
            btnEdytujZamowienie.Size = new Size(66, 48);
            btnEdytujZamowienie.TabIndex = 1;
            btnEdytujZamowienie.Text = "Edytuj";
            btnEdytujZamowienie.UseVisualStyleBackColor = true;
            btnEdytujZamowienie.Click += btnEdytujZamowienie_Click;
            // 
            // btnDodajZamowienia
            // 
            btnDodajZamowienia.Location = new Point(8, 6);
            btnDodajZamowienia.Name = "btnDodajZamowienia";
            btnDodajZamowienia.Size = new Size(66, 48);
            btnDodajZamowienia.TabIndex = 0;
            btnDodajZamowienia.Text = "Dodaj";
            btnDodajZamowienia.UseVisualStyleBackColor = true;
            btnDodajZamowienia.Click += btnDodajZamowienia_Click;
            // 
            // tabZamowieniaDoDostawcow
            // 
            tabZamowieniaDoDostawcow.Controls.Add(btnUsunZamDost);
            tabZamowieniaDoDostawcow.Controls.Add(btnEdytujZamDost);
            tabZamowieniaDoDostawcow.Controls.Add(btnDodajZamDost);
            tabZamowieniaDoDostawcow.Location = new Point(4, 24);
            tabZamowieniaDoDostawcow.Name = "tabZamowieniaDoDostawcow";
            tabZamowieniaDoDostawcow.Padding = new Padding(3);
            tabZamowieniaDoDostawcow.Size = new Size(968, 60);
            tabZamowieniaDoDostawcow.TabIndex = 1;
            tabZamowieniaDoDostawcow.Text = "Zamówienia do dostawców";
            tabZamowieniaDoDostawcow.UseVisualStyleBackColor = true;
            // 
            // btnUsunZamDost
            // 
            btnUsunZamDost.Location = new Point(151, 6);
            btnUsunZamDost.Name = "btnUsunZamDost";
            btnUsunZamDost.Size = new Size(66, 48);
            btnUsunZamDost.TabIndex = 5;
            btnUsunZamDost.Text = "Usuń";
            btnUsunZamDost.UseVisualStyleBackColor = true;
            btnUsunZamDost.Click += btnUsunZamDost_Click;
            // 
            // btnEdytujZamDost
            // 
            btnEdytujZamDost.Location = new Point(79, 6);
            btnEdytujZamDost.Name = "btnEdytujZamDost";
            btnEdytujZamDost.Size = new Size(66, 48);
            btnEdytujZamDost.TabIndex = 4;
            btnEdytujZamDost.Text = "Edytuj";
            btnEdytujZamDost.UseVisualStyleBackColor = true;
            btnEdytujZamDost.Click += btnEdytujZamDost_Click;
            // 
            // btnDodajZamDost
            // 
            btnDodajZamDost.Location = new Point(7, 6);
            btnDodajZamDost.Name = "btnDodajZamDost";
            btnDodajZamDost.Size = new Size(66, 48);
            btnDodajZamDost.TabIndex = 3;
            btnDodajZamDost.Text = "Dodaj";
            btnDodajZamDost.UseVisualStyleBackColor = true;
            btnDodajZamDost.Click += btnDodajZamDost_Click;
            // 
            // tabMagazyny
            // 
            tabMagazyny.Controls.Add(btnUsunMagazyny);
            tabMagazyny.Controls.Add(btnEdytujMagazyny);
            tabMagazyny.Controls.Add(btnDodajMagazyny);
            tabMagazyny.Location = new Point(4, 24);
            tabMagazyny.Name = "tabMagazyny";
            tabMagazyny.Size = new Size(968, 60);
            tabMagazyny.TabIndex = 2;
            tabMagazyny.Text = "Magazyny";
            tabMagazyny.UseVisualStyleBackColor = true;
            // 
            // btnUsunMagazyny
            // 
            btnUsunMagazyny.Location = new Point(152, 9);
            btnUsunMagazyny.Name = "btnUsunMagazyny";
            btnUsunMagazyny.Size = new Size(66, 48);
            btnUsunMagazyny.TabIndex = 5;
            btnUsunMagazyny.Text = "Usuń";
            btnUsunMagazyny.UseVisualStyleBackColor = true;
            btnUsunMagazyny.Click += btnUsunMagazyny_Click;
            // 
            // btnEdytujMagazyny
            // 
            btnEdytujMagazyny.Location = new Point(80, 9);
            btnEdytujMagazyny.Name = "btnEdytujMagazyny";
            btnEdytujMagazyny.Size = new Size(66, 48);
            btnEdytujMagazyny.TabIndex = 4;
            btnEdytujMagazyny.Text = "Edytuj";
            btnEdytujMagazyny.UseVisualStyleBackColor = true;
            btnEdytujMagazyny.Click += btnEdytujMagazyny_Click;
            // 
            // btnDodajMagazyny
            // 
            btnDodajMagazyny.Location = new Point(8, 9);
            btnDodajMagazyny.Name = "btnDodajMagazyny";
            btnDodajMagazyny.Size = new Size(66, 48);
            btnDodajMagazyny.TabIndex = 3;
            btnDodajMagazyny.Text = "Dodaj";
            btnDodajMagazyny.UseVisualStyleBackColor = true;
            btnDodajMagazyny.Click += btnDodajMagazyny_Click;
            // 
            // tabProdukty
            // 
            tabProdukty.Controls.Add(btnUsunProdukty);
            tabProdukty.Controls.Add(btnEdytujProdukty);
            tabProdukty.Controls.Add(btnDodajProdukty);
            tabProdukty.Location = new Point(4, 24);
            tabProdukty.Name = "tabProdukty";
            tabProdukty.Size = new Size(968, 60);
            tabProdukty.TabIndex = 3;
            tabProdukty.Text = "Produkty";
            tabProdukty.UseVisualStyleBackColor = true;
            // 
            // btnUsunProdukty
            // 
            btnUsunProdukty.Location = new Point(152, 9);
            btnUsunProdukty.Name = "btnUsunProdukty";
            btnUsunProdukty.Size = new Size(66, 48);
            btnUsunProdukty.TabIndex = 5;
            btnUsunProdukty.Text = "Usuń";
            btnUsunProdukty.UseVisualStyleBackColor = true;
            btnUsunProdukty.Click += btnUsunProdukty_Click;
            // 
            // btnEdytujProdukty
            // 
            btnEdytujProdukty.Location = new Point(80, 9);
            btnEdytujProdukty.Name = "btnEdytujProdukty";
            btnEdytujProdukty.Size = new Size(66, 48);
            btnEdytujProdukty.TabIndex = 4;
            btnEdytujProdukty.Text = "Edytuj";
            btnEdytujProdukty.UseVisualStyleBackColor = true;
            btnEdytujProdukty.Click += btnEdytujProdukty_Click;
            // 
            // btnDodajProdukty
            // 
            btnDodajProdukty.Location = new Point(8, 9);
            btnDodajProdukty.Name = "btnDodajProdukty";
            btnDodajProdukty.Size = new Size(66, 48);
            btnDodajProdukty.TabIndex = 3;
            btnDodajProdukty.Text = "Dodaj";
            btnDodajProdukty.UseVisualStyleBackColor = true;
            btnDodajProdukty.Click += btnDodajProdukty_Click;
            // 
            // tabPodmioty
            // 
            tabPodmioty.Controls.Add(label2);
            tabPodmioty.Controls.Add(inpTypPodmiotu);
            tabPodmioty.Controls.Add(btnUsunPodmioty);
            tabPodmioty.Controls.Add(btnEdytujPodmioty);
            tabPodmioty.Controls.Add(btnDodajPodmioty);
            tabPodmioty.Location = new Point(4, 24);
            tabPodmioty.Name = "tabPodmioty";
            tabPodmioty.Size = new Size(968, 60);
            tabPodmioty.TabIndex = 4;
            tabPodmioty.Text = "Podmioty";
            tabPodmioty.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 30);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 7;
            label2.Text = "Typ podmiotu:";
            // 
            // inpTypPodmiotu
            // 
            inpTypPodmiotu.FormattingEnabled = true;
            inpTypPodmiotu.Location = new Point(355, 27);
            inpTypPodmiotu.Name = "inpTypPodmiotu";
            inpTypPodmiotu.Size = new Size(194, 23);
            inpTypPodmiotu.TabIndex = 6;
            inpTypPodmiotu.SelectedIndexChanged += inpTypPodmiotu_SelectedIndexChanged;
            // 
            // btnUsunPodmioty
            // 
            btnUsunPodmioty.Location = new Point(152, 9);
            btnUsunPodmioty.Name = "btnUsunPodmioty";
            btnUsunPodmioty.Size = new Size(66, 48);
            btnUsunPodmioty.TabIndex = 5;
            btnUsunPodmioty.Text = "Usuń";
            btnUsunPodmioty.UseVisualStyleBackColor = true;
            btnUsunPodmioty.Click += btnUsunPodmioty_Click;
            // 
            // btnEdytujPodmioty
            // 
            btnEdytujPodmioty.Location = new Point(80, 9);
            btnEdytujPodmioty.Name = "btnEdytujPodmioty";
            btnEdytujPodmioty.Size = new Size(66, 48);
            btnEdytujPodmioty.TabIndex = 4;
            btnEdytujPodmioty.Text = "Edytuj";
            btnEdytujPodmioty.UseVisualStyleBackColor = true;
            btnEdytujPodmioty.Click += btnEdytujPodmioty_Click;
            // 
            // btnDodajPodmioty
            // 
            btnDodajPodmioty.Location = new Point(8, 9);
            btnDodajPodmioty.Name = "btnDodajPodmioty";
            btnDodajPodmioty.Size = new Size(66, 48);
            btnDodajPodmioty.TabIndex = 3;
            btnDodajPodmioty.Text = "Dodaj";
            btnDodajPodmioty.UseVisualStyleBackColor = true;
            btnDodajPodmioty.Click += btnDodajPodmioty_Click;
            // 
            // tabStatusy
            // 
            tabStatusy.Controls.Add(btnUsunStatusy);
            tabStatusy.Controls.Add(btnEdytujStatusy);
            tabStatusy.Controls.Add(btnDodajStatusy);
            tabStatusy.Location = new Point(4, 24);
            tabStatusy.Name = "tabStatusy";
            tabStatusy.Size = new Size(968, 60);
            tabStatusy.TabIndex = 5;
            tabStatusy.Text = "Statusy";
            tabStatusy.UseVisualStyleBackColor = true;
            // 
            // btnUsunStatusy
            // 
            btnUsunStatusy.Location = new Point(152, 9);
            btnUsunStatusy.Name = "btnUsunStatusy";
            btnUsunStatusy.Size = new Size(66, 48);
            btnUsunStatusy.TabIndex = 5;
            btnUsunStatusy.Text = "Usuń";
            btnUsunStatusy.UseVisualStyleBackColor = true;
            btnUsunStatusy.Click += btnUsunStatusy_Click;
            // 
            // btnEdytujStatusy
            // 
            btnEdytujStatusy.Location = new Point(80, 9);
            btnEdytujStatusy.Name = "btnEdytujStatusy";
            btnEdytujStatusy.Size = new Size(66, 48);
            btnEdytujStatusy.TabIndex = 4;
            btnEdytujStatusy.Text = "Edytuj";
            btnEdytujStatusy.UseVisualStyleBackColor = true;
            btnEdytujStatusy.Click += btnEdytujStatusy_Click;
            // 
            // btnDodajStatusy
            // 
            btnDodajStatusy.Location = new Point(8, 9);
            btnDodajStatusy.Name = "btnDodajStatusy";
            btnDodajStatusy.Size = new Size(66, 48);
            btnDodajStatusy.TabIndex = 3;
            btnDodajStatusy.Text = "Dodaj";
            btnDodajStatusy.UseVisualStyleBackColor = true;
            btnDodajStatusy.Click += btnDodajStatusy_Click;
            // 
            // tabUzytkownicy
            // 
            tabUzytkownicy.Controls.Add(btnUsunUzytk);
            tabUzytkownicy.Controls.Add(btnEdytujUzytk);
            tabUzytkownicy.Controls.Add(btnDodajUzytk);
            tabUzytkownicy.Location = new Point(4, 24);
            tabUzytkownicy.Name = "tabUzytkownicy";
            tabUzytkownicy.Size = new Size(968, 60);
            tabUzytkownicy.TabIndex = 6;
            tabUzytkownicy.Text = "Użytkownicy";
            tabUzytkownicy.UseVisualStyleBackColor = true;
            // 
            // btnUsunUzytk
            // 
            btnUsunUzytk.Location = new Point(152, 9);
            btnUsunUzytk.Name = "btnUsunUzytk";
            btnUsunUzytk.Size = new Size(66, 48);
            btnUsunUzytk.TabIndex = 5;
            btnUsunUzytk.Text = "Usuń";
            btnUsunUzytk.UseVisualStyleBackColor = true;
            btnUsunUzytk.Click += btnUsunUzytk_Click;
            // 
            // btnEdytujUzytk
            // 
            btnEdytujUzytk.Location = new Point(80, 9);
            btnEdytujUzytk.Name = "btnEdytujUzytk";
            btnEdytujUzytk.Size = new Size(66, 48);
            btnEdytujUzytk.TabIndex = 4;
            btnEdytujUzytk.Text = "Edytuj";
            btnEdytujUzytk.UseVisualStyleBackColor = true;
            btnEdytujUzytk.Click += btnEdytujUzytk_Click;
            // 
            // btnDodajUzytk
            // 
            btnDodajUzytk.Location = new Point(8, 9);
            btnDodajUzytk.Name = "btnDodajUzytk";
            btnDodajUzytk.Size = new Size(66, 48);
            btnDodajUzytk.TabIndex = 3;
            btnDodajUzytk.Text = "Dodaj";
            btnDodajUzytk.UseVisualStyleBackColor = true;
            btnDodajUzytk.Click += btnDodajUzytk_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 340);
            panel1.TabIndex = 2;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabZamowieniaTab);
            tabControl2.Controls.Add(tabZamowieniaDoDostawcowTab);
            tabControl2.Controls.Add(tabMagazynTab);
            tabControl2.Controls.Add(tabProduktyTab);
            tabControl2.Controls.Add(tabPodmiotyTab);
            tabControl2.Controls.Add(tabStatusyTab);
            tabControl2.Controls.Add(tabUzytkownikTab);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(976, 340);
            tabControl2.TabIndex = 0;
            // 
            // tabZamowieniaTab
            // 
            tabZamowieniaTab.Controls.Add(dataGridViewZamowienia);
            tabZamowieniaTab.Location = new Point(4, 24);
            tabZamowieniaTab.Name = "tabZamowieniaTab";
            tabZamowieniaTab.Padding = new Padding(3);
            tabZamowieniaTab.Size = new Size(968, 312);
            tabZamowieniaTab.TabIndex = 0;
            tabZamowieniaTab.Text = "Zamówienia";
            tabZamowieniaTab.UseVisualStyleBackColor = true;
            // 
            // dataGridViewZamowienia
            // 
            dataGridViewZamowienia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewZamowienia.Columns.AddRange(new DataGridViewColumn[] { zamID, zamData, zamPodmiotId, zamStatusId, zamPodmiot, zamStatus });
            dataGridViewZamowienia.Dock = DockStyle.Fill;
            dataGridViewZamowienia.Location = new Point(3, 3);
            dataGridViewZamowienia.Name = "dataGridViewZamowienia";
            dataGridViewZamowienia.RowTemplate.Height = 25;
            dataGridViewZamowienia.Size = new Size(962, 306);
            dataGridViewZamowienia.TabIndex = 0;
            // 
            // zamID
            // 
            zamID.DataPropertyName = "ID";
            zamID.HeaderText = "Numer";
            zamID.Name = "zamID";
            zamID.ReadOnly = true;
            // 
            // zamData
            // 
            zamData.DataPropertyName = "Data";
            zamData.HeaderText = "Data";
            zamData.Name = "zamData";
            zamData.ReadOnly = true;
            // 
            // zamPodmiotId
            // 
            zamPodmiotId.DataPropertyName = "podmiot_id";
            zamPodmiotId.HeaderText = "podmiot_id";
            zamPodmiotId.Name = "zamPodmiotId";
            zamPodmiotId.ReadOnly = true;
            zamPodmiotId.Visible = false;
            // 
            // zamStatusId
            // 
            zamStatusId.DataPropertyName = "status_id";
            zamStatusId.HeaderText = "status_id";
            zamStatusId.Name = "zamStatusId";
            zamStatusId.ReadOnly = true;
            zamStatusId.Visible = false;
            // 
            // zamPodmiot
            // 
            zamPodmiot.DataPropertyName = "podmiot";
            zamPodmiot.HeaderText = "Podmiot";
            zamPodmiot.Name = "zamPodmiot";
            zamPodmiot.ReadOnly = true;
            // 
            // zamStatus
            // 
            zamStatus.DataPropertyName = "status";
            zamStatus.HeaderText = "Status";
            zamStatus.Name = "zamStatus";
            zamStatus.ReadOnly = true;
            // 
            // tabZamowieniaDoDostawcowTab
            // 
            tabZamowieniaDoDostawcowTab.Controls.Add(dataGridViewZamowieniaDostawcy);
            tabZamowieniaDoDostawcowTab.Location = new Point(4, 24);
            tabZamowieniaDoDostawcowTab.Name = "tabZamowieniaDoDostawcowTab";
            tabZamowieniaDoDostawcowTab.Padding = new Padding(3);
            tabZamowieniaDoDostawcowTab.Size = new Size(968, 312);
            tabZamowieniaDoDostawcowTab.TabIndex = 1;
            tabZamowieniaDoDostawcowTab.Text = "Zamówienia do dostawców";
            tabZamowieniaDoDostawcowTab.UseVisualStyleBackColor = true;
            // 
            // dataGridViewZamowieniaDostawcy
            // 
            dataGridViewZamowieniaDostawcy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewZamowieniaDostawcy.Columns.AddRange(new DataGridViewColumn[] { zamdID, zamdData, zamdPodmiotId, zamdStatusId, zamdPodmiot, zamdStatus });
            dataGridViewZamowieniaDostawcy.Dock = DockStyle.Fill;
            dataGridViewZamowieniaDostawcy.Location = new Point(3, 3);
            dataGridViewZamowieniaDostawcy.Name = "dataGridViewZamowieniaDostawcy";
            dataGridViewZamowieniaDostawcy.RowTemplate.Height = 25;
            dataGridViewZamowieniaDostawcy.Size = new Size(962, 306);
            dataGridViewZamowieniaDostawcy.TabIndex = 0;
            // 
            // zamdID
            // 
            zamdID.DataPropertyName = "ID";
            zamdID.HeaderText = "Numer";
            zamdID.Name = "zamdID";
            zamdID.ReadOnly = true;
            // 
            // zamdData
            // 
            zamdData.DataPropertyName = "Data";
            zamdData.HeaderText = "Data";
            zamdData.Name = "zamdData";
            zamdData.ReadOnly = true;
            // 
            // zamdPodmiotId
            // 
            zamdPodmiotId.DataPropertyName = "podmiot_id";
            zamdPodmiotId.HeaderText = "podmiot_id";
            zamdPodmiotId.Name = "zamdPodmiotId";
            zamdPodmiotId.ReadOnly = true;
            zamdPodmiotId.Visible = false;
            // 
            // zamdStatusId
            // 
            zamdStatusId.DataPropertyName = "status_id";
            zamdStatusId.HeaderText = "status_id";
            zamdStatusId.Name = "zamdStatusId";
            zamdStatusId.ReadOnly = true;
            zamdStatusId.Visible = false;
            // 
            // zamdPodmiot
            // 
            zamdPodmiot.DataPropertyName = "podmiot";
            zamdPodmiot.HeaderText = "Podmiot";
            zamdPodmiot.Name = "zamdPodmiot";
            zamdPodmiot.ReadOnly = true;
            // 
            // zamdStatus
            // 
            zamdStatus.DataPropertyName = "status";
            zamdStatus.HeaderText = "Status";
            zamdStatus.Name = "zamdStatus";
            zamdStatus.ReadOnly = true;
            // 
            // tabMagazynTab
            // 
            tabMagazynTab.Controls.Add(dataGridViewMagazyny);
            tabMagazynTab.Location = new Point(4, 24);
            tabMagazynTab.Name = "tabMagazynTab";
            tabMagazynTab.Padding = new Padding(3);
            tabMagazynTab.Size = new Size(968, 312);
            tabMagazynTab.TabIndex = 3;
            tabMagazynTab.Text = "Magazyny";
            tabMagazynTab.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMagazyny
            // 
            dataGridViewMagazyny.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMagazyny.Columns.AddRange(new DataGridViewColumn[] { mgID, mgNazwa, mgPiekarniaId, mgPiekarnia });
            dataGridViewMagazyny.Dock = DockStyle.Fill;
            dataGridViewMagazyny.Location = new Point(3, 3);
            dataGridViewMagazyny.Name = "dataGridViewMagazyny";
            dataGridViewMagazyny.RowTemplate.Height = 25;
            dataGridViewMagazyny.Size = new Size(962, 306);
            dataGridViewMagazyny.TabIndex = 0;
            // 
            // tabProduktyTab
            // 
            tabProduktyTab.Controls.Add(dataGridViewProdukty);
            tabProduktyTab.Location = new Point(4, 24);
            tabProduktyTab.Name = "tabProduktyTab";
            tabProduktyTab.Padding = new Padding(3);
            tabProduktyTab.Size = new Size(968, 312);
            tabProduktyTab.TabIndex = 4;
            tabProduktyTab.Text = "Produkty";
            tabProduktyTab.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProdukty
            // 
            dataGridViewProdukty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdukty.Columns.AddRange(new DataGridViewColumn[] { prID, prNazwa });
            dataGridViewProdukty.Dock = DockStyle.Fill;
            dataGridViewProdukty.Location = new Point(3, 3);
            dataGridViewProdukty.Name = "dataGridViewProdukty";
            dataGridViewProdukty.RowTemplate.Height = 25;
            dataGridViewProdukty.Size = new Size(962, 306);
            dataGridViewProdukty.TabIndex = 0;
            // 
            // prID
            // 
            prID.DataPropertyName = "ID";
            prID.HeaderText = "ID";
            prID.Name = "prID";
            prID.ReadOnly = true;
            prID.Visible = false;
            // 
            // prNazwa
            // 
            prNazwa.DataPropertyName = "Nazwa";
            prNazwa.HeaderText = "Nazwa";
            prNazwa.Name = "prNazwa";
            prNazwa.ReadOnly = true;
            prNazwa.Width = 400;
            // 
            // tabPodmiotyTab
            // 
            tabPodmiotyTab.Controls.Add(dataGridViewPodmioty);
            tabPodmiotyTab.Location = new Point(4, 24);
            tabPodmiotyTab.Name = "tabPodmiotyTab";
            tabPodmiotyTab.Padding = new Padding(3);
            tabPodmiotyTab.Size = new Size(968, 312);
            tabPodmiotyTab.TabIndex = 5;
            tabPodmiotyTab.Text = "Podmioty";
            tabPodmiotyTab.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPodmioty
            // 
            dataGridViewPodmioty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPodmioty.Columns.AddRange(new DataGridViewColumn[] { pdId, pdNazwa, pdAdres, pdTelefon });
            dataGridViewPodmioty.Dock = DockStyle.Fill;
            dataGridViewPodmioty.Location = new Point(3, 3);
            dataGridViewPodmioty.Name = "dataGridViewPodmioty";
            dataGridViewPodmioty.RowTemplate.Height = 25;
            dataGridViewPodmioty.Size = new Size(962, 306);
            dataGridViewPodmioty.TabIndex = 0;
            // 
            // pdId
            // 
            pdId.DataPropertyName = "ID";
            pdId.HeaderText = "ID";
            pdId.Name = "pdId";
            pdId.ReadOnly = true;
            pdId.Visible = false;
            // 
            // pdNazwa
            // 
            pdNazwa.DataPropertyName = "Nazwa";
            pdNazwa.HeaderText = "Nazwa";
            pdNazwa.Name = "pdNazwa";
            pdNazwa.ReadOnly = true;
            pdNazwa.Width = 300;
            // 
            // pdAdres
            // 
            pdAdres.DataPropertyName = "Adres";
            pdAdres.HeaderText = "Adres";
            pdAdres.Name = "pdAdres";
            pdAdres.ReadOnly = true;
            pdAdres.Width = 500;
            // 
            // pdTelefon
            // 
            pdTelefon.DataPropertyName = "Telefon";
            pdTelefon.HeaderText = "Telefon";
            pdTelefon.Name = "pdTelefon";
            pdTelefon.ReadOnly = true;
            // 
            // tabStatusyTab
            // 
            tabStatusyTab.Controls.Add(dataGridViewStatusy);
            tabStatusyTab.Location = new Point(4, 24);
            tabStatusyTab.Name = "tabStatusyTab";
            tabStatusyTab.Padding = new Padding(3);
            tabStatusyTab.Size = new Size(968, 312);
            tabStatusyTab.TabIndex = 6;
            tabStatusyTab.Text = "Statusy";
            tabStatusyTab.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStatusy
            // 
            dataGridViewStatusy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatusy.Columns.AddRange(new DataGridViewColumn[] { stID, stNazwa });
            dataGridViewStatusy.Dock = DockStyle.Fill;
            dataGridViewStatusy.Location = new Point(3, 3);
            dataGridViewStatusy.Name = "dataGridViewStatusy";
            dataGridViewStatusy.RowTemplate.Height = 25;
            dataGridViewStatusy.Size = new Size(962, 306);
            dataGridViewStatusy.TabIndex = 0;
            // 
            // stID
            // 
            stID.DataPropertyName = "ID";
            stID.HeaderText = "Id";
            stID.Name = "stID";
            stID.ReadOnly = true;
            stID.Visible = false;
            // 
            // stNazwa
            // 
            stNazwa.DataPropertyName = "Nazwa";
            stNazwa.HeaderText = "Nazwa";
            stNazwa.Name = "stNazwa";
            stNazwa.ReadOnly = true;
            // 
            // tabUzytkownikTab
            // 
            tabUzytkownikTab.Controls.Add(dataGridViewUzytkownik);
            tabUzytkownikTab.Location = new Point(4, 24);
            tabUzytkownikTab.Name = "tabUzytkownikTab";
            tabUzytkownikTab.Size = new Size(968, 312);
            tabUzytkownikTab.TabIndex = 2;
            tabUzytkownikTab.Text = "Użytkownik";
            tabUzytkownikTab.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUzytkownik
            // 
            dataGridViewUzytkownik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUzytkownik.Columns.AddRange(new DataGridViewColumn[] { uzID, uzLogin, uzImie, uzNazwisko, uzAktywny });
            dataGridViewUzytkownik.Dock = DockStyle.Fill;
            dataGridViewUzytkownik.Location = new Point(0, 0);
            dataGridViewUzytkownik.Name = "dataGridViewUzytkownik";
            dataGridViewUzytkownik.RowTemplate.Height = 25;
            dataGridViewUzytkownik.Size = new Size(968, 312);
            dataGridViewUzytkownik.TabIndex = 0;
            // 
            // uzID
            // 
            uzID.DataPropertyName = "ID";
            uzID.HeaderText = "ID";
            uzID.Name = "uzID";
            uzID.Visible = false;
            // 
            // uzLogin
            // 
            uzLogin.DataPropertyName = "Login";
            uzLogin.HeaderText = "Login";
            uzLogin.Name = "uzLogin";
            uzLogin.ReadOnly = true;
            // 
            // uzImie
            // 
            uzImie.DataPropertyName = "Imie";
            uzImie.HeaderText = "Imie";
            uzImie.Name = "uzImie";
            uzImie.ReadOnly = true;
            // 
            // uzNazwisko
            // 
            uzNazwisko.DataPropertyName = "Nazwisko";
            uzNazwisko.HeaderText = "Nazwisko";
            uzNazwisko.Name = "uzNazwisko";
            uzNazwisko.ReadOnly = true;
            // 
            // uzAktywny
            // 
            uzAktywny.DataPropertyName = "aktywny";
            uzAktywny.HeaderText = "Aktywny";
            uzAktywny.Name = "uzAktywny";
            uzAktywny.ReadOnly = true;
            // 
            // Login
            // 
            Login.Frozen = true;
            Login.HeaderText = "Login";
            Login.Name = "Login";
            Login.ReadOnly = true;
            // 
            // Imię
            // 
            Imię.HeaderText = "Imie";
            Imię.Name = "Imię";
            Imię.ReadOnly = true;
            // 
            // Nazwisko
            // 
            Nazwisko.HeaderText = "Nazwisko";
            Nazwisko.Name = "Nazwisko";
            Nazwisko.ReadOnly = true;
            // 
            // Aktywny
            // 
            Aktywny.HeaderText = "Aktywny";
            Aktywny.Name = "Aktywny";
            Aktywny.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "Login";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Imie";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Nazwisko";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Aktywny";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // mgID
            // 
            mgID.DataPropertyName = "ID";
            mgID.HeaderText = "ID";
            mgID.Name = "mgID";
            mgID.ReadOnly = true;
            mgID.Visible = false;
            // 
            // mgNazwa
            // 
            mgNazwa.DataPropertyName = "Nazwa";
            mgNazwa.HeaderText = "Nazwa";
            mgNazwa.Name = "mgNazwa";
            mgNazwa.ReadOnly = true;
            mgNazwa.Width = 200;
            // 
            // mgPiekarniaId
            // 
            mgPiekarniaId.DataPropertyName = "piekarnia_id";
            mgPiekarniaId.HeaderText = "piekarnia_id";
            mgPiekarniaId.Name = "mgPiekarniaId";
            mgPiekarniaId.ReadOnly = true;
            mgPiekarniaId.Visible = false;
            // 
            // mgPiekarnia
            // 
            mgPiekarnia.DataPropertyName = "Piekarnia";
            mgPiekarnia.HeaderText = "Piekarnia";
            mgPiekarnia.Name = "mgPiekarnia";
            mgPiekarnia.ReadOnly = true;
            mgPiekarnia.Width = 300;
            // 
            // OknoGlowne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 450);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Name = "OknoGlowne";
            Text = "Form1";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabZamowienia.ResumeLayout(false);
            tabZamowienia.PerformLayout();
            tabZamowieniaDoDostawcow.ResumeLayout(false);
            tabMagazyny.ResumeLayout(false);
            tabProdukty.ResumeLayout(false);
            tabPodmioty.ResumeLayout(false);
            tabPodmioty.PerformLayout();
            tabStatusy.ResumeLayout(false);
            tabUzytkownicy.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabZamowieniaTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewZamowienia).EndInit();
            tabZamowieniaDoDostawcowTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewZamowieniaDostawcy).EndInit();
            tabMagazynTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMagazyny).EndInit();
            tabProduktyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdukty).EndInit();
            tabPodmiotyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPodmioty).EndInit();
            tabStatusyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatusy).EndInit();
            tabUzytkownikTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUzytkownik).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridView dataGridViewUzytkownik;
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
        private DataGridView dataGridViewZamowienia;
        private DataGridView dataGridViewZamowieniaDostawcy;
        private DataGridView dataGridViewMagazyny;
        private DataGridView dataGridViewProdukty;
        private DataGridView dataGridViewPodmioty;
        private DataGridView dataGridViewStatusy;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lbFootMagazyn;
        private Label label1;
        private ComboBox inpZmienMagazyn;
        private DataGridViewTextBoxColumn zamID;
        private DataGridViewTextBoxColumn zamData;
        private DataGridViewTextBoxColumn zamPodmiotId;
        private DataGridViewTextBoxColumn zamStatusId;
        private DataGridViewTextBoxColumn zamPodmiot;
        private DataGridViewTextBoxColumn zamStatus;
        private DataGridViewTextBoxColumn zamdID;
        private DataGridViewTextBoxColumn zamdData;
        private DataGridViewTextBoxColumn zamdPodmiotId;
        private DataGridViewTextBoxColumn zamdStatusId;
        private DataGridViewTextBoxColumn zamdPodmiot;
        private DataGridViewTextBoxColumn zamdStatus;
        private DataGridViewTextBoxColumn uzID;
        private DataGridViewTextBoxColumn uzLogin;
        private DataGridViewTextBoxColumn uzImie;
        private DataGridViewTextBoxColumn uzNazwisko;
        private DataGridViewTextBoxColumn uzAktywny;
        private DataGridViewTextBoxColumn stID;
        private DataGridViewTextBoxColumn stNazwa;
        private DataGridViewTextBoxColumn pdId;
        private DataGridViewTextBoxColumn pdNazwa;
        private DataGridViewTextBoxColumn pdAdres;
        private DataGridViewTextBoxColumn pdTelefon;
        private Label label2;
        private ComboBox inpTypPodmiotu;
        private DataGridViewTextBoxColumn prID;
        private DataGridViewTextBoxColumn prNazwa;
        private DataGridViewTextBoxColumn mgID;
        private DataGridViewTextBoxColumn mgNazwa;
        private DataGridViewTextBoxColumn mgPiekarniaId;
        private DataGridViewTextBoxColumn mgPiekarnia;
    }
}