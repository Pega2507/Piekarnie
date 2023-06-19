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
    public partial class OknoPodmiot : Form
    {
        private Podmiot podmiot = null;
        private BazaDanych db = null;

        public OknoPodmiot(BazaDanych db)
        {
            InitializeComponent();
            this.db = db;
        }

        public OknoPodmiot(Int32 Id, BazaDanych db)
        {
            InitializeComponent();
            this.db = db;
            try
            {
                this.podmiot = new Podmiot(Id, this.db);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void OknoPodmiot_Shown(object sender, EventArgs e)
        {
            this.inpTyp.Items.Add(new PozycjaListyRozwijanej((int)TypPodmiotu.Piekarnia, "Piekarnia"));
            this.inpTyp.Items.Add(new PozycjaListyRozwijanej((int)TypPodmiotu.Dostawca, "Dostawca"));
            this.inpTyp.SelectedIndex = 0;

            if (this.podmiot != null)
            {
                this.inpNazwa.Text = this.podmiot.Nazwa;
                this.inpAdres.Text = this.podmiot.Adres;
                this.inpTelefon.Text = this.podmiot.Telefon;
                if (this.podmiot.Typ == (int)TypPodmiotu.Piekarnia)
                    this.inpTyp.SelectedIndex = 0;
                else
                    this.inpTyp.SelectedIndex = 1;
            }
        }

        private void inpTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.inpTyp.SelectedIndex == 0)
            {
                this.inpNowyMagazyn.Visible = true;
            }
            else
                this.inpNowyMagazyn.Visible = false;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (this.inpAdres.Text.Trim().Length == 0)
            {
                if (MessageBox.Show("Wypełnij pole Adres", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)

                    this.inpAdres.Focus();
            }
            if (this.inpNazwa.Text.Trim().Length == 0)
            {
                if (MessageBox.Show("Wypełnij pole Nazwa", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)

                    this.inpNazwa.Focus();
            }
            if (this.inpTelefon.Text.Trim().Length == 0)
            {
                if (MessageBox.Show("Wypełnij pole Telefon", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)

                    this.inpTelefon.Focus();
            }
            if (this.inpTyp.Text.Trim().Length == 0)
            {
                if (MessageBox.Show("Wypełnij pole Typ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)

                    this.inpTyp.Focus();
            }
            try
            {
                this.podmiot = new Podmiot(this.db);
                this.podmiot.Adres = this.inpAdres.Text;
                this.podmiot.Nazwa = this.inpNazwa.Text;
                this.podmiot.Telefon = this.inpTelefon.Text;
                this.podmiot.Typ = (this.inpTyp.SelectedItem as PozycjaListyRozwijanej).Identyfikator;

                if (this.podmiot.Id == 0)
                {
                    this.podmiot.Dodaj();
                    if (this.podmiot.Typ == (int)TypPodmiotu.Piekarnia)
                    {
                        Magazyn mag = new Magazyn(this.db);
                        mag.Nazwa = this.podmiot.Nazwa;
                        mag.PiekarniaId = this.podmiot.Id;
                        mag.Dodaj();
                    }
                }
                else
                    this.podmiot.Edytuj();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
