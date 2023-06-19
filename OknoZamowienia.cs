using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piekarnie
{
    public partial class OknoZamowienia : Form
    {
        BazaDanych db = null;
        Zamowienie zam = null;
        Int32 magId = 0;
        Int32 typPodmiotu = (int)TypPodmiotu.Piekarnia;
        public OknoZamowienia(Int32 Typ, BazaDanych db, Int32 magId)
        {
            InitializeComponent();
            this.db = db;
            this.typPodmiotu = Typ;
            this.magId = magId;
        }
        public OknoZamowienia(Int32 Typ, Int32 Id, BazaDanych db)
        {
            InitializeComponent();
            try
            {
                this.db = db;
                this.typPodmiotu = Typ;
                this.zam = new Zamowienie(Id, this.db);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void OknoZamowienia_Shown(object sender, EventArgs e)
        {
            try
            {
                this.inpPodmiot.Items.Clear();
                if (this.zam != null)
                {
                    Podmiot pd = new Podmiot(this.zam.PodmiotId, this.db);
                    this.inpPodmiot.Items.Add(new PozycjaListyRozwijanej(this.zam.PodmiotId, pd.Nazwa));
                    Status stat = new Status(this.zam.StatusId, this.db);
                    this.inpStatus.Items.Add(new PozycjaListyRozwijanej(this.zam.StatusId, stat.Nazwa));

                    this.inpData.Value = this.zam.Data;

                    this.odswierzPozycje();
                }
                else
                {
                    Status stat = new Status(1, this.db);
                    this.inpStatus.Items.Add(new PozycjaListyRozwijanej(1, stat.Nazwa));
                    this.inpStatus.SelectedIndex = 0;

                    this.inpData.Value = DateTime.Now;

                }
                this.inpPodmiot.SelectedIndex = 0;


            }
            catch (Exception ex) { }



        }

        private void inpPodmiot_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (this.inpPodmiot.Items.Count <= 1)
                {
                    foreach (DataRow pod in List.pobierzPodmioty(this.typPodmiotu, this.db).Rows)
                    {
                        this.inpPodmiot.Items.Add(new PozycjaListyRozwijanej((int)pod["ID"], pod["Nazwa"].ToString()));
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void inpStatus_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (this.inpStatus.Items.Count <= 1 && this.zam != null)
                {
                    foreach (DataRow pod in List.pobierzStatusy(this.db).Rows)
                    {
                        this.inpStatus.Items.Add(new PozycjaListyRozwijanej((int)pod["ID"], pod["Nazwa"].ToString()));
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewProdukty.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Czy napewno chcesz usunąć pozycję zamówienia?", "Usuwanie pozycji zamówienia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        //pobieramy id zaznaczonej pozycji
                        Int32 id = 0;
                        Int32.TryParse(this.dataGridViewProdukty.SelectedRows[0].Cells[0].ToString(), out id);

                        PozycjaZamowienia poz = new PozycjaZamowienia(id, this.db);
                        poz.Usun();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Zaznacz pozycję do usunięcia");
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            if (this.zam == null)
            {
                if ((this.inpPodmiot.SelectedItem as PozycjaListyRozwijanej).Identyfikator > 0)
                {
                    this.zam = new Zamowienie(this.db);
                    this.zam.MagazynId = this.magId;
                    this.zam.Typ = this.typPodmiotu;
                    this.zam.Data = this.inpData.Value;
                    this.zam.PodmiotId = (this.inpPodmiot.SelectedItem as PozycjaListyRozwijanej).Identyfikator;
                    this.zam.Dodaj();
                }
                else
                {
                    MessageBox.Show("Przed dodniem pozycji wybierz podmiot");
                    this.inpPodmiot.Focus();
                }
            }

            OknoPozycjiZamowienia poz = new OknoPozycjiZamowienia(this.db, this.zam.Id);
            if (poz.ShowDialog() == DialogResult.OK)
            {
                this.dataGridViewProdukty.Refresh();
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewProdukty.SelectedRows.Count == 1)
            {
                Int32 id = 0;
                Int32.TryParse(this.dataGridViewProdukty.SelectedRows[0].Cells[0].ToString(), out id);

                OknoPozycjiZamowienia poz = new OknoPozycjiZamowienia(id, this.db);
                if (poz.ShowDialog() == DialogResult.OK)
                {
                    this.odswierzPozycje();
                }
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                this.zam.Data = (DateTime)this.inpData.Value;
                this.zam.StatusId = (this.inpStatus.SelectedItem as PozycjaListyRozwijanej).Identyfikator;
                this.zam.PodmiotId = (this.inpPodmiot.SelectedItem as PozycjaListyRozwijanej).Identyfikator;

                if (this.zam.Id == 0)
                    this.zam.Dodaj();
                else
                    this.zam.Edytuj();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void odswierzPozycje()
        {
            try
            {
                this.dataGridViewProdukty.DataSource = List.pobierzPozycjeZam(this.zam.Id, this.db);
                this.dataGridViewProdukty.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
