using System.Data;

namespace Piekarnie
{
    public partial class OknoGlowne : Form
    {
        public Uzytkownik uzytkownik = null;
        private BazaDanych db = null;
        private Int32 MagId = 0;
        private Int32 typPodmiotu = 1;
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

                this.MagId = this.uzytkownik.MagazynId;
                if (this.MagId == -1)
                    this.MagId = 1;

                Magazyn mag = new Magazyn(this.MagId, this.db);
                this.inpZmienMagazyn.Items.Add(new PozycjaListyRozwijanej(this.MagId, mag.Nazwa));
                this.inpZmienMagazyn.SelectedIndex = 0;

                this.inpZmienMagazyn.Items.Clear();

                foreach (DataRow magazyn in List.pobierzMagazyny(this.db).Rows)
                {
                    Int32 id = 0;
                    Int32.TryParse(magazyn["ID"].ToString(), out id);
                    this.inpZmienMagazyn.Items.Add(new PozycjaListyRozwijanej(id, magazyn["Nazwa"].ToString()));
                }

                this.inpTypPodmiotu.Items.Add(new PozycjaListyRozwijanej((int)TypPodmiotu.Piekarnia, "Piekarnia"));
                this.inpTypPodmiotu.SelectedIndex = 0;
                this.inpTypPodmiotu.Items.Add(new PozycjaListyRozwijanej((int)TypPodmiotu.Dostawca, "Dostawca"));

                this.lbFootUzytkownik.Text = "[" + this.uzytkownik.Login + "] " + this.uzytkownik.Imie + " " + this.uzytkownik.Nazwisko;
                if (!this.uzytkownik.Zamowienia_podglad)
                {
                    this.tabControl1.TabPages.Remove(this.tabZamowienia);
                    this.tabControl1.TabPages.Remove(this.tabZamowieniaDoDostawcow);
                }
                else
                {
                    this.odswierzListeZamowien((int)TypPodmiotu.Piekarnia);
                    if (this.uzytkownik.MagazynId > 0)
                        this.tabControl1.TabPages.Remove(this.tabZamowieniaDoDostawcow);
                }
                if (!this.uzytkownik.Produkty_podglad)
                {
                    this.tabControl1.TabPages.Remove(this.tabProdukty);
                }
                else
                    this.odswiezListeProduktow();
                if (!this.uzytkownik.Magazyn_podglad)
                {
                    this.tabControl1.TabPages.Remove(this.tabMagazyny);
                }
                else
                    this.odswiezListeMagazynow();
                if (!this.uzytkownik.Podmiot_podglad)
                {
                    this.tabControl1.TabPages.Remove(this.tabPodmioty);
                }
                else
                {
                    if (this.uzytkownik.MagazynId > 0)
                        this.inpTypPodmiotu.Visible = false;
                    this.odswiezListePodmiotow();
                }
                if (!this.uzytkownik.Status_podglad)
                {
                    this.tabControl1.TabPages.Remove(this.tabStatusy);
                }
                else
                    this.odswiezListeStatusow();
                if (!this.uzytkownik.Uzytkownik_podglad)
                {
                    this.tabControl1.TabPages.Remove(this.tabUzytkownicy);
                }
                else
                    this.odswiezListeUzytkownikow();

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
                this.odswiezListeUzytkownikow();
            }
        }

        private void btnEdytujUzytk_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewUzytkownik.SelectedRows.Count == 1)
            {
                Int32 id = 0;
                Int32.TryParse(this.dataGridViewUzytkownik.SelectedRows[0].Cells[0].Value.ToString(), out id);
                if (id > 0)
                {
                    OknoUzytkownika okno = new OknoUzytkownika(id, this.db);
                    if (okno.ShowDialog() == DialogResult.OK)
                    {
                        this.odswiezListeUzytkownikow();
                    }
                }
            }
        }

        private void btnUsunUzytk_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewUzytkownik.SelectedRows.Count == 1)
            {
                Int32 id = 0;
                Int32.TryParse(this.dataGridViewUzytkownik.SelectedRows[0].Cells[0].Value.ToString(), out id);
                if (id > 0)
                {
                    try
                    {
                        Uzytkownik uzyt = new Uzytkownik(id, this.db);
                        uzyt.Usun();
                        this.odswiezListeUzytkownikow();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void btnDodajZamowienia_Click(object sender, EventArgs e)
        {
            OknoZamowienia okno = new OknoZamowienia((int)TypPodmiotu.Piekarnia, this.db, this.MagId);
            if (okno.ShowDialog() == DialogResult.OK)
            {
                this.odswierzListeZamowien((int)TypPodmiotu.Piekarnia);
            }
        }

        private void btnDodajProdukty_Click(object sender, EventArgs e)
        {
            OknoProdukt produkt = new OknoProdukt(this.db);
            if (produkt.ShowDialog() == DialogResult.OK)
            {
                this.odswiezListeProduktow();
            }
        }

        private void btnDodajZamowienia_Click_1(object sender, EventArgs e)
        {
            OknoZamowienia okno = new OknoZamowienia((int)TypPodmiotu.Piekarnia, this.db, this.MagId);
            if (okno.ShowDialog() == DialogResult.OK)
            {
                this.odswierzListeZamowien((int)TypPodmiotu.Piekarnia);
            }
        }

        private void btnEdytujZamowienie_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewZamowienia.SelectedRows.Count == 1)
            {
                Int32 id = 0;
                Int32.TryParse(this.dataGridViewZamowienia.SelectedRows[0].Cells[0].Value.ToString(), out id);

                OknoZamowienia okno = new OknoZamowienia((int)TypPodmiotu.Piekarnia, id, this.db);
                if (okno.ShowDialog() == DialogResult.OK)
                {
                    this.odswierzListeZamowien((int)TypPodmiotu.Piekarnia);
                }
            }
        }

        private void btnUsunZamowienie_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewZamowienia.SelectedRows.Count == 1)
            {
                Int32 id = 0;
                Int32.TryParse(this.dataGridViewZamowienia.SelectedRows[0].Cells[0].Value.ToString(), out id);

                try
                {
                    Zamowienie zam = new Zamowienie(id, this.db);
                    zam.Usun();
                    this.odswierzListeZamowien((int)TypPodmiotu.Piekarnia);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void inpZmienMagazyn_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MagId = (this.inpZmienMagazyn.SelectedItem as PozycjaListyRozwijanej).Identyfikator;
        }

        private void btnDodajMagazyny_Click(object sender, EventArgs e)
        {
            OknoMagazyn okno = new OknoMagazyn(this.db);
            if (okno.ShowDialog() == DialogResult.OK)
            {
                this.odswiezListeMagazynow();
            }
        }

        private void btnEdytujMagazyny_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewMagazyny.SelectedRows.Count == 1)
            {
                Int32 id = 0;
                Int32.TryParse(this.dataGridViewMagazyny.SelectedRows[0].Cells[0].Value.ToString(), out id);

                OknoMagazyn okno = new OknoMagazyn(id, this.db);
                if (okno.ShowDialog() == DialogResult.OK)
                {
                    this.odswiezListeMagazynow();
                }
            }
        }

        private void btnUsunMagazyny_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewMagazyny.SelectedRows.Count == 1)
            {
                Int32 id = 0;
                Int32.TryParse(this.dataGridViewMagazyny.SelectedRows[0].Cells[0].Value.ToString(), out id);
                try
                {
                    Magazyn mag = new Magazyn(id, this.db);
                    mag.Usun();
                    this.odswiezListeMagazynow();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnEdytujProdukty_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewProdukty.SelectedRows.Count == 1)
            {
                Int32 id = 0;
                Int32.TryParse(this.dataGridViewProdukty.SelectedRows[0].Cells[0].Value.ToString(), out id);

                OknoProdukt okno = new OknoProdukt(id, this.db);
                if (okno.ShowDialog() == DialogResult.OK)
                {
                    this.odswiezListeProduktow();
                }
            }
        }

        private void btnUsunProdukty_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewProdukty.SelectedRows.Count == 1)
            {
                Int32 id = 0;
                Int32.TryParse(this.dataGridViewProdukty.SelectedRows[0].Cells[0].Value.ToString(), out id);
                try
                {
                    Produkt prod = new Produkt(id, this.db);
                    prod.Usun();
                    this.odswiezListeProduktow();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnDodajPodmioty_Click(object sender, EventArgs e)
        {
            OknoPodmiot okno = new OknoPodmiot(this.db);
            if (okno.ShowDialog() == DialogResult.OK)
            {
                this.odswiezListePodmiotow();
            }
        }

        private void btnEdytujPodmioty_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewPodmioty.SelectedRows.Count == 1)
            {
                Int32 id = 0;
                Int32.TryParse(this.dataGridViewPodmioty.SelectedRows[0].Cells[0].Value.ToString(), out id);

                OknoPodmiot okno = new OknoPodmiot(id, this.db);
                if (okno.ShowDialog() == DialogResult.OK)
                {
                    this.odswiezListePodmiotow();
                }
            }
        }

        private void btnUsunPodmioty_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewPodmioty.SelectedRows.Count == 1)
            {
                Int32 id = 0;
                Int32.TryParse(this.dataGridViewPodmioty.SelectedRows[0].Cells[0].Value.ToString(), out id);
                try
                {
                    Podmiot pod = new Podmiot(id, this.db);
                    pod.Usun();
                    this.odswiezListePodmiotow(); ;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnDodajStatusy_Click(object sender, EventArgs e)
        {
            OknoStatus okno = new OknoStatus(this.db);
            if (okno.ShowDialog() == DialogResult.OK)
            {
                this.odswiezListeStatusow();
            }
        }

        private void btnEdytujStatusy_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewStatusy.SelectedRows.Count == 1)
            {
                Int32 id = 0;
                Int32.TryParse(this.dataGridViewStatusy.SelectedRows[0].Cells[0].Value.ToString(), out id);

                OknoStatus okno = new OknoStatus(id, this.db);
                if (okno.ShowDialog() == DialogResult.OK)
                {
                    this.odswiezListeStatusow();
                }
            }
        }

        private void btnUsunStatusy_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewStatusy.SelectedRows.Count == 1)
            {
                Int32 id = 0;
                Int32.TryParse(this.dataGridViewStatusy.SelectedRows[0].Cells[0].Value.ToString(), out id);
                try
                {
                    Status st = new Status(id, this.db);
                    st.Usun();
                    this.odswiezListeStatusow();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void odswierzListeZamowien(Int32 typZamowienia)
        {
            if (typZamowienia == (int)TypPodmiotu.Piekarnia)
            {
                this.dataGridViewZamowienia.DataSource = List.pobierzZamowienia(typZamowienia, this.MagId, this.db);
                this.dataGridViewZamowienia.Refresh();
            }
            else
            {
                this.dataGridViewZamowieniaDostawcy.DataSource = List.pobierzZamowienia(typZamowienia, this.MagId, this.db);
                this.dataGridViewZamowieniaDostawcy.Refresh();
            }
        }

        private void btnDodajZamDost_Click(object sender, EventArgs e)
        {
            OknoZamowienia okno = new OknoZamowienia((int)TypPodmiotu.Dostawca, this.db, this.MagId);
            if (okno.ShowDialog() == DialogResult.OK)
            {
                this.odswierzListeZamowien((int)TypPodmiotu.Dostawca);
            }
        }

        private void btnEdytujZamDost_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewZamowieniaDostawcy.SelectedRows.Count == 1)
            {
                Int32 id = 0;
                Int32.TryParse(this.dataGridViewZamowieniaDostawcy.SelectedRows[0].Cells[0].Value.ToString(), out id);

                OknoZamowienia okno = new OknoZamowienia((int)TypPodmiotu.Dostawca, id, this.db);
                if (okno.ShowDialog() == DialogResult.OK)
                {
                    this.odswierzListeZamowien((int)TypPodmiotu.Dostawca);
                }
            }
        }

        private void btnUsunZamDost_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewZamowieniaDostawcy.SelectedRows.Count == 1)
            {
                Int32 id = 0;
                Int32.TryParse(this.dataGridViewZamowieniaDostawcy.SelectedRows[0].Cells[0].Value.ToString(), out id);

                try
                {
                    Zamowienie zam = new Zamowienie(id, this.db);
                    zam.Usun();
                    this.odswierzListeZamowien((int)TypPodmiotu.Dostawca);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        private void odswiezListeUzytkownikow()
        {
            this.dataGridViewUzytkownik.DataSource = List.pobierzUzytkownikow(this.db);
            this.dataGridViewUzytkownik.Refresh();
        }
        private void odswiezListeStatusow()
        {
            this.dataGridViewStatusy.DataSource = List.pobierzStatusy(this.db);
            this.dataGridViewStatusy.Refresh();
        }
        private void odswiezListePodmiotow()
        {
            this.dataGridViewPodmioty.DataSource = List.pobierzPodmioty(this.typPodmiotu, this.db);
            this.dataGridViewPodmioty.Refresh();
        }
        private void odswiezListeProduktow()
        {
            this.dataGridViewProdukty.DataSource = List.pobierzProdukty(this.db);
            this.dataGridViewProdukty.Refresh();
        }
        private void odswiezListeMagazynow()
        {
            this.dataGridViewMagazyny.DataSource = List.pobierzMagazyny(this.db);
            this.dataGridViewMagazyny.Refresh();
        }

        private void inpTypPodmiotu_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.typPodmiotu = (this.inpTypPodmiotu.SelectedItem as PozycjaListyRozwijanej).Identyfikator;
            this.odswiezListePodmiotow();
        }
    }
}