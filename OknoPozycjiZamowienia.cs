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
    public partial class OknoPozycjiZamowienia : Form
    {
        BazaDanych db = null;
        PozycjaZamowienia poz = null;
        Int32 zamId = 0;
        public OknoPozycjiZamowienia(BazaDanych db, int zamId)
        {
            InitializeComponent();
            this.db = db;
            this.zamId = zamId;

            foreach(DataRow prod in List.pobierzProdukty(this.db).Rows)
            {
                this.inpProdukt.Items.Add(new PozycjaListyRozwijanej((int)prod["ID"], prod["Nazwa"].ToString()));
            }

        }
        public OknoPozycjiZamowienia(Int32 id, BazaDanych db)
        {
            InitializeComponent();
            this.db = db;
            try
            {
                this.poz = new PozycjaZamowienia(id, this.db);
                Produkt prod = new Produkt(this.poz.ProductId, this.db);
                this.inpProdukt.Items.Clear();
                this.inpProdukt.Items.Add(prod.Nazwa);
                this.inpCena.Text = this.poz.Cena.ToString();
                this.inpIlosc.Text = this.poz.Ilosc.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("OknoPozycjiZamowienia" + Environment.NewLine + ex.Message);
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (this.poz == null)
            {
                this.poz = new PozycjaZamowienia(this.db);
                this.poz.ProductId = (this.inpProdukt.SelectedItem as PozycjaListyRozwijanej).Identyfikator;
                this.poz.ZamowienieId = this.zamId;
            }
            Int32 ilosc = 0;
            Int32.TryParse(this.inpIlosc.Text, out ilosc);
            if(ilosc == 0)
            {
                MessageBox.Show("Ilość musi być większa od 0");
                this.inpIlosc.Focus();
                return;
            }
            decimal cena = 0;
            decimal.TryParse(this.inpCena.Text, out cena);
            if (cena == 0)
            {
                MessageBox.Show("Cena musi być większa od 0");
                this.inpCena.Focus();
                return;
            }
            this.poz.Ilosc = ilosc;
            this.poz.Cena = cena;
            if(this.poz.Id == 0)
            {
                this.poz.Dodaj();
            }
            else
            {
                this.poz.Edytuj();
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
