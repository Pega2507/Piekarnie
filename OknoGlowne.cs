namespace Piekarnie
{
    public partial class OknoGlowne : Form
    {
        public Uzytkownik uzytkownik = null;
        private BazaDanych db = null;
        public OknoGlowne()
        {
            InitializeComponent();
            try
            {
                this.db = new BazaDanych();
                OknoLogowania logowanie = new OknoLogowania(db);
                if (logowanie.ShowDialog() == DialogResult.Cancel)
                    Environment.Exit(0);
                else
                    this.uzytkownik = logowanie.uzytkownik;
                this.lbFootUzytkownik.Text = "[" + this.uzytkownik.Login + "] " + this.uzytkownik.Imie + " " + this.uzytkownik.Nazwisko;
                if (!this.uzytkownik.Zamowienia_podglad)
                {
                    this.tabControl1.TabPages.Remove(this.tabZamowienia);
                    this.tabControl1.TabPages.Remove(this.tabZamowieniaDoDostawcow);
                }
                else
                {
                    if (this.uzytkownik.MagazynId > 0)
                        this.tabControl1.TabPages.Remove(this.tabZamowieniaDoDostawcow);
                }
                if (!this.uzytkownik.Produkty_podglad)
                {
                    this.tabControl1.TabPages.Remove(this.tabProdukty);
                }
                if (!this.uzytkownik.Magazyn_podglad)
                {
                    this.tabControl1.TabPages.Remove(this.tabMagazyny);
                }
                if (!this.uzytkownik.Podmiot_podglad)
                {
                    this.tabControl1.TabPages.Remove(this.tabPodmioty);
                }
                if (!this.uzytkownik.Status_podglad)
                {
                    this.tabControl1.TabPages.Remove(this.tabStatusy);
                }
                if (!this.uzytkownik.Uzytkownik_podglad)
                {
                    this.tabControl1.TabPages.Remove(this.tabUzytkownicy);
                }

            }
            catch (Exception ex) { Environment.Exit(0); }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabZamowienia)
            {
                tabControl2.SelectedTab = this.tabZamowieniaTab;
            }
            else if (tabControl1.SelectedTab == tabUzytkownicy)
            {
                tabControl2.SelectedTab = this.tabUzytkownikTab;
            }
            else if (tabControl1.SelectedTab == tabMagazyny)
            {
                tabControl2.SelectedTab = this.tabMagazynTab;
            }
            else if (tabControl1.SelectedTab == tabPodmioty)
            {
                tabControl2.SelectedTab = this.tabPodmiotyTab;
            }
            else if (tabControl1.SelectedTab == tabProdukty)
            {
                tabControl2.SelectedTab = this.tabProduktyTab;
            }
            else if (tabControl1.SelectedTab == tabStatusy)
            {
                tabControl2.SelectedTab = this.tabStatusyTab;
            }
            else if (tabControl1.SelectedTab == tabZamowieniaDoDostawcow)
            {
                tabControl2.SelectedTab = this.tabZamowieniaDoDostawcowTab;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajUzytk_Click(object sender, EventArgs e)
        {
            OknoUzytkownika okno = new OknoUzytkownika(this.db);
            if (okno.ShowDialog() == DialogResult.OK)
            {
                this.dataGridViewUzytkownik.Refresh();
            }
        }

        private void btnEdytujUzytk_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewUzytkownik.SelectedRows.Count == 1)
            {
                Int32 id = 0;
                Int32.TryParse(this.dataGridViewUzytkownik.SelectedRows[0].Cells[0].ToString(), out id);
                if (id > 0)
                {
                    OknoUzytkownika okno = new OknoUzytkownika(id, this.db);
                    if (okno.ShowDialog() == DialogResult.OK)
                    {
                        this.dataGridViewUzytkownik.Refresh();
                    }
                }
            }
        }

        private void btnUsunUzytk_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewUzytkownik.SelectedRows.Count == 1)
            {
                Int32 id = 0;
                Int32.TryParse(this.dataGridViewUzytkownik.SelectedRows[0].Cells[0].ToString(), out id);
                if (id > 0)
                {
                    try
                    {
                        Uzytkownik uzyt = new Uzytkownik(id, this.db);
                        uzyt.Usun();
                        this.dataGridViewUzytkownik.Refresh();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void btnDodajZamowienia_Click(object sender, EventArgs e)
        {
            OknoZamowienia okno = new OknoZamowienia((int)TypPodmiotu.Piekarnia, this.db);
            if(okno.ShowDialog()==DialogResult.OK)
            {
                this.dataGridViewZamowienia.Refresh();
            }
        }
    }
}