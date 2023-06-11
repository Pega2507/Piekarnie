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
        }
    }
}