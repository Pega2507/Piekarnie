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
            tabZamowieniaDoDostawcowTab = new TabPage();
            dataGridViewZamówieniaDostawcy = new DataGridView();
            tabMagazynTab = new TabPage();
            dataGridViewMagazyny = new DataGridView();
            tabProduktyTab = new TabPage();
            dataGridViewProdukty = new DataGridView();
            tabPodmiotyTab = new TabPage();
            dataGridViewPodmioty = new DataGridView();
            tabStatusyTab = new TabPage();
            dataGridViewStatusy = new DataGridView();
            tabUzytkownikTab = new TabPage();
            dataGridViewUzytkownik = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            Imię = new DataGridViewTextBoxColumn();
            Nazwisko = new DataGridViewTextBoxColumn();
            Aktywny = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewZamówieniaDostawcy).BeginInit();
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
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
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
            inpZmienMagazyn.SelectedIndexChanged += inpZmienMagazyn_SelectedIndexChanged;
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
            btnDodajZamowienia.Click += btnDodajZamowienia_Click_1;
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
            // 
            // btnEdytujZamDost
            // 
            btnEdytujZamDost.Location = new Point(79, 6);
            btnEdytujZamDost.Name = "btnEdytujZamDost";
            btnEdytujZamDost.Size = new Size(66, 48);
            btnEdytujZamDost.TabIndex = 4;
            btnEdytujZamDost.Text = "Edytuj";
            btnEdytujZamDost.UseVisualStyleBackColor = true;
            // 
            // btnDodajZamDost
            // 
            btnDodajZamDost.Location = new Point(7, 6);
            btnDodajZamDost.Name = "btnDodajZamDost";
            btnDodajZamDost.Size = new Size(66, 48);
            btnDodajZamDost.TabIndex = 3;
            btnDodajZamDost.Text = "Dodaj";
            btnDodajZamDost.UseVisualStyleBackColor = true;
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
            // 
            // btnEdytujMagazyny
            // 
            btnEdytujMagazyny.Location = new Point(80, 9);
            btnEdytujMagazyny.Name = "btnEdytujMagazyny";
            btnEdytujMagazyny.Size = new Size(66, 48);
            btnEdytujMagazyny.TabIndex = 4;
            btnEdytujMagazyny.Text = "Edytuj";
            btnEdytujMagazyny.UseVisualStyleBackColor = true;
            // 
            // btnDodajMagazyny
            // 
            btnDodajMagazyny.Location = new Point(8, 9);
            btnDodajMagazyny.Name = "btnDodajMagazyny";
            btnDodajMagazyny.Size = new Size(66, 48);
            btnDodajMagazyny.TabIndex = 3;
            btnDodajMagazyny.Text = "Dodaj";
            btnDodajMagazyny.UseVisualStyleBackColor = true;
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
            // 
            // btnEdytujProdukty
            // 
            btnEdytujProdukty.Location = new Point(80, 9);
            btnEdytujProdukty.Name = "btnEdytujProdukty";
            btnEdytujProdukty.Size = new Size(66, 48);
            btnEdytujProdukty.TabIndex = 4;
            btnEdytujProdukty.Text = "Edytuj";
            btnEdytujProdukty.UseVisualStyleBackColor = true;
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
            // btnUsunPodmioty
            // 
            btnUsunPodmioty.Location = new Point(152, 9);
            btnUsunPodmioty.Name = "btnUsunPodmioty";
            btnUsunPodmioty.Size = new Size(66, 48);
            btnUsunPodmioty.TabIndex = 5;
            btnUsunPodmioty.Text = "Usuń";
            btnUsunPodmioty.UseVisualStyleBackColor = true;
            // 
            // btnEdytujPodmioty
            // 
            btnEdytujPodmioty.Location = new Point(80, 9);
            btnEdytujPodmioty.Name = "btnEdytujPodmioty";
            btnEdytujPodmioty.Size = new Size(66, 48);
            btnEdytujPodmioty.TabIndex = 4;
            btnEdytujPodmioty.Text = "Edytuj";
            btnEdytujPodmioty.UseVisualStyleBackColor = true;
            // 
            // btnDodajPodmioty
            // 
            btnDodajPodmioty.Location = new Point(8, 9);
            btnDodajPodmioty.Name = "btnDodajPodmioty";
            btnDodajPodmioty.Size = new Size(66, 48);
            btnDodajPodmioty.TabIndex = 3;
            btnDodajPodmioty.Text = "Dodaj";
            btnDodajPodmioty.UseVisualStyleBackColor = true;
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
            // 
            // btnEdytujStatusy
            // 
            btnEdytujStatusy.Location = new Point(80, 9);
            btnEdytujStatusy.Name = "btnEdytujStatusy";
            btnEdytujStatusy.Size = new Size(66, 48);
            btnEdytujStatusy.TabIndex = 4;
            btnEdytujStatusy.Text = "Edytuj";
            btnEdytujStatusy.UseVisualStyleBackColor = true;
            // 
            // btnDodajStatusy
            // 
            btnDodajStatusy.Location = new Point(8, 9);
            btnDodajStatusy.Name = "btnDodajStatusy";
            btnDodajStatusy.Size = new Size(66, 48);
            btnDodajStatusy.TabIndex = 3;
            btnDodajStatusy.Text = "Dodaj";
            btnDodajStatusy.UseVisualStyleBackColor = true;
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
            // 
            // btnEdytujUzytk
            // 
            btnEdytujUzytk.Location = new Point(80, 9);
            btnEdytujUzytk.Name = "btnEdytujUzytk";
            btnEdytujUzytk.Size = new Size(66, 48);
            btnEdytujUzytk.TabIndex = 4;
            btnEdytujUzytk.Text = "Edytuj";
            btnEdytujUzytk.UseVisualStyleBackColor = true;
            // 
            // btnDodajUzytk
            // 
            btnDodajUzytk.Location = new Point(8, 9);
            btnDodajUzytk.Name = "btnDodajUzytk";
            btnDodajUzytk.Size = new Size(66, 48);
            btnDodajUzytk.TabIndex = 3;
            btnDodajUzytk.Text = "Dodaj";
            btnDodajUzytk.UseVisualStyleBackColor = true;
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
            dataGridViewZamowienia.Dock = DockStyle.Fill;
            dataGridViewZamowienia.Location = new Point(3, 3);
            dataGridViewZamowienia.Name = "dataGridViewZamowienia";
            dataGridViewZamowienia.RowTemplate.Height = 25;
            dataGridViewZamowienia.Size = new Size(962, 306);
            dataGridViewZamowienia.TabIndex = 0;
            // 
            // tabZamowieniaDoDostawcowTab
            // 
            tabZamowieniaDoDostawcowTab.Controls.Add(dataGridViewZamówieniaDostawcy);
            tabZamowieniaDoDostawcowTab.Location = new Point(4, 24);
            tabZamowieniaDoDostawcowTab.Name = "tabZamowieniaDoDostawcowTab";
            tabZamowieniaDoDostawcowTab.Padding = new Padding(3);
            tabZamowieniaDoDostawcowTab.Size = new Size(968, 312);
            tabZamowieniaDoDostawcowTab.TabIndex = 1;
            tabZamowieniaDoDostawcowTab.Text = "Zamówienia do dostawców";
            tabZamowieniaDoDostawcowTab.UseVisualStyleBackColor = true;
            // 
            // dataGridViewZamówieniaDostawcy
            // 
            dataGridViewZamówieniaDostawcy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewZamówieniaDostawcy.Dock = DockStyle.Fill;
            dataGridViewZamówieniaDostawcy.Location = new Point(3, 3);
            dataGridViewZamówieniaDostawcy.Name = "dataGridViewZamówieniaDostawcy";
            dataGridViewZamówieniaDostawcy.RowTemplate.Height = 25;
            dataGridViewZamówieniaDostawcy.Size = new Size(962, 306);
            dataGridViewZamówieniaDostawcy.TabIndex = 0;
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
            dataGridViewProdukty.Dock = DockStyle.Fill;
            dataGridViewProdukty.Location = new Point(3, 3);
            dataGridViewProdukty.Name = "dataGridViewProdukty";
            dataGridViewProdukty.RowTemplate.Height = 25;
            dataGridViewProdukty.Size = new Size(962, 306);
            dataGridViewProdukty.TabIndex = 0;
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
            dataGridViewPodmioty.Dock = DockStyle.Fill;
            dataGridViewPodmioty.Location = new Point(3, 3);
            dataGridViewPodmioty.Name = "dataGridViewPodmioty";
            dataGridViewPodmioty.RowTemplate.Height = 25;
            dataGridViewPodmioty.Size = new Size(962, 306);
            dataGridViewPodmioty.TabIndex = 0;
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
            dataGridViewStatusy.Dock = DockStyle.Fill;
            dataGridViewStatusy.Location = new Point(3, 3);
            dataGridViewStatusy.Name = "dataGridViewStatusy";
            dataGridViewStatusy.RowTemplate.Height = 25;
            dataGridViewStatusy.Size = new Size(962, 306);
            dataGridViewStatusy.TabIndex = 0;
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
            dataGridViewUzytkownik.Columns.AddRange(new DataGridViewColumn[] { ID });
            dataGridViewUzytkownik.Dock = DockStyle.Fill;
            dataGridViewUzytkownik.Location = new Point(0, 0);
            dataGridViewUzytkownik.Name = "dataGridViewUzytkownik";
            dataGridViewUzytkownik.RowTemplate.Height = 25;
            dataGridViewUzytkownik.Size = new Size(968, 312);
            dataGridViewUzytkownik.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
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
            tabStatusy.ResumeLayout(false);
            tabUzytkownicy.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabZamowieniaTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewZamowienia).EndInit();
            tabZamowieniaDoDostawcowTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewZamówieniaDostawcy).EndInit();
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
        private DataGridView dataGridViewZamówieniaDostawcy;
        private DataGridView dataGridViewMagazyny;
        private DataGridView dataGridViewProdukty;
        private DataGridView dataGridViewPodmioty;
        private DataGridView dataGridViewStatusy;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lbFootMagazyn;
        private Label label1;
        private ComboBox inpZmienMagazyn;
    }
}