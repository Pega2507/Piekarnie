namespace Piekarnie
{
    public partial class OknoGlowne : Form
    {
        public Uzytkownik uzytkownik = null;
        public OknoGlowne()
        {
            InitializeComponent();
            try
            {
                BazaDanych db = new BazaDanych();
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
                    if(this.uzytkownik.MagazynId>0)
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
              //Co z Statusami i U�ytkownikami? Mysla�am �eby do tego tylko admin mia� dost�p

            }
            catch(Exception ex) { Environment.Exit(0); }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab==tabZamowienia)
            {
                tabControl2.SelectedTab = this.tabZamowieniaTab;
            }
            else if(tabControl1.SelectedTab == tabUzytkownicy)
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
    }
}