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
    public partial class OknoMagazyn : Form
    {
        private Magazyn magazyn = null;
        private BazaDanych db = null;

        public OknoMagazyn(BazaDanych db)
        {
            InitializeComponent();
            this.db = db;
        }
        public OknoMagazyn(Int32 Id, BazaDanych db)
        {
            InitializeComponent();
            this.db = db;
            try
            {
                this.magazyn = new Magazyn(Id, this.db);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void OknoMagazyn_Shown(object sender, EventArgs e)
        {
            if (this.magazyn!= null)
            {
                this.inpNazwa.Text = this.magazyn.Nazwa;
                Podmiot pd = new Podmiot(this.magazyn.PiekarniaId, this.db);
                this.inpPiekarnie.Items.Add(new PozycjaListyRozwijanej(pd.Id, pd.Nazwa));
                this.inpPiekarnie.SelectedIndex= 0;
            }
            foreach (DataRow pod in List.pobierzPodmioty((int)TypPodmiotu.Piekarnia, this.db).Rows)
            {
                this.inpPiekarnie.Items.Add(new PozycjaListyRozwijanej((int)pod["ID"], pod["Nazwa"].ToString()));
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (this.inpNazwa.Text.Trim().Length == 0)
            {
                if (MessageBox.Show("Wypełnij pole Nazwa", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)

                    this.inpNazwa.Focus();
            }
            if(this.magazyn==null)
                this.magazyn = new Magazyn(this.db);
            this.magazyn.Nazwa = this.inpNazwa.Text;
            this.magazyn.PiekarniaId = -1;
            try 
            {
                this.magazyn.PiekarniaId = (this.inpPiekarnie.SelectedItem as PozycjaListyRozwijanej).Identyfikator;

            }
            catch { }
            

            if (this.magazyn.Id == 0)
                this.magazyn.Dodaj();
            else
                this.magazyn.Edytuj();

            this.DialogResult= DialogResult.OK;
        }

        private void OknoMagazyn_Load(object sender, EventArgs e)
        {

        }
    }
}
