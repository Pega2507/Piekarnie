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
    public partial class OknoUzytkownika : Form
    {
        private Uzytkownik uzyt = null;
        private BazaDanych db = null;
        public OknoUzytkownika(BazaDanych db)
        {
            InitializeComponent();
            this.db = db;
        }
        public OknoUzytkownika(Int32 Id, BazaDanych db)
        {
            InitializeComponent();
            this.db = db;
            try
            {
                this.uzyt = new Uzytkownik(Id, this.db);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void OknoUzytkownika_Shown(object sender, EventArgs e)
        {
            Int32 mag_id = 0;
            if (this.uzyt != null)
            {
                this.inpLogin.Text = this.uzyt.Login;
                this.inpImie.Text = this.uzyt.Imie;
                this.inpNazwisko.Text = this.uzyt.Nazwisko;
                this.inpAktywny.Checked = this.uzyt.Aktywny;
                if (this.uzyt.MagazynId > 0)
                    mag_id = this.uzyt.MagazynId;

                this.inpZamPodglad.Checked = this.uzyt.Zamowienia_podglad;
                this.inpZamEdycja.Checked = this.uzyt.Zamowienia_edycja;
                this.inpProdPodglad.Checked = this.uzyt.Produkty_podglad;
                this.inpProdEdycja.Checked = this.uzyt.Produkty_edycja;
                this.inpMagPodglad.Checked = this.uzyt.Magazyn_podglad;
                this.inpMagEdycja.Checked = this.uzyt.Magazyn_edycja;
                this.inpPodmiotPodglad.Checked = this.uzyt.Podmiot_podglad;
                this.inpPodmiotEdycja.Checked = this.uzyt.Podmiot_edycja;
                this.inpUzytkownikPodglad.Checked = this.uzyt.Uzytkownik_podglad;
                this.inpUzytkownikEytuj.Checked = this.uzyt.Uzytkownik_edycja;
                this.inpHistoriaPodglad.Checked = this.uzyt.Historia_podglad;
            }
            inpMagazyn.Items.Add(new PozycjaListyRozwijanej(-1, "Wybierz"));
            foreach (DataRow magazyn in List.pobierzMagazyny(this.db).Rows)
            {
                Int32 tmpId = 0;
                Int32.TryParse(magazyn["ID"].ToString(), out tmpId);
                this.inpMagazyn.Items.Add(new PozycjaListyRozwijanej(tmpId, magazyn["Nazwa"].ToString()));
                if (tmpId == mag_id)
                {
                    this.inpMagazyn.SelectedIndex = this.inpMagazyn.Items.Count - 1;
                }
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (this.inpLogin.Text.Trim().Length == 0)
            {
                if(MessageBox.Show("Wypełnij pole Login", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning)==DialogResult.OK)
              
                    this.inpLogin.Focus();
            }

            if (this.inpImie.Text.Trim().Length == 0)
            {
                if (MessageBox.Show("Wypełnij pole Imie", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    this.inpImie.Focus();
            }

            if (this.inpNazwisko.Text.Trim().Length == 0)
            {
                if (MessageBox.Show("Wypełnij pole Nazwisko", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    this.inpNazwisko.Focus();
            }
            if (this.inpHaslo.Text.Trim().Length == 0)
            {
                if (MessageBox.Show("Hasło jest wymagane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    this.inpHaslo.Focus();
            }
            if (this.inpHaslo2.Text.Trim().Length == 0 || this.inpHaslo.Text!= this.inpHaslo2.Text)
            {
                if (MessageBox.Show("Hasło się nie zgadza", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    this.inpHaslo2.Focus();
            }

            Boolean newUzytkownik = false;
            if (this.uzyt != null)
            {
                this.uzyt = new Uzytkownik(this.db);
                newUzytkownik = true;
            }

            this.uzyt.Login = this.inpLogin.Text;
            this.uzyt.Imie = this.inpImie.Text;
            this.uzyt.Nazwisko = this.inpNazwisko.Text;
            this.uzyt.Haslo = this.inpHaslo.Text;

            this.uzyt.Aktywny = this.inpAktywny.Checked;
            Int32 magId = -1;
            try
            {
                magId = (this.inpMagazyn.SelectedItem as PozycjaListyRozwijanej).Identyfikator;
            }
            catch { }
            this.uzyt.MagazynId = magId;

            this.uzyt.Zamowienia_podglad = this.inpZamPodglad.Checked;
            this.uzyt.Zamowienia_edycja = this.inpZamEdycja.Checked;
            this.uzyt.Produkty_podglad = this.inpProdPodglad.Checked;
            this.uzyt.Produkty_edycja = this.inpProdEdycja.Checked;
            this.uzyt.Magazyn_podglad = this.inpMagPodglad.Checked;
            this.uzyt.Magazyn_edycja = this.inpMagEdycja.Checked;
            this.uzyt.Podmiot_podglad = this.inpPodmiotPodglad.Checked;
            this.uzyt.Podmiot_edycja = this.inpPodmiotEdycja.Checked;
            this.uzyt.Uzytkownik_podglad = this.inpUzytkownikPodglad.Checked;
            this.uzyt.Uzytkownik_edycja = this.inpUzytkownikEytuj.Checked;
            this.uzyt.Historia_podglad = this.inpHistoriaPodglad.Checked;

            if (newUzytkownik)
                this.uzyt.Dodaj();
            else
                this.uzyt.Edytuj();

            this.DialogResult = DialogResult.OK;
        }
    }
}
