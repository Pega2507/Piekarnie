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
    public partial class OknoProdukt : Form
    {
        private Produkt produkt = null;
        private BazaDanych db = null;

        public OknoProdukt(BazaDanych db)
        {
            InitializeComponent();
            this.db = db;
        }
        public OknoProdukt(Int32 Id, BazaDanych db)
        {
            InitializeComponent();
            this.db = db;
            try
            {
                this.produkt = new Produkt(Id, this.db);   
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    
        private void OknoProdukt_Shown(object sender, EventArgs e)
        {
            if (this.produkt != null)
            {
                this.inpNazwa.Text = this.produkt.Nazwa;
                this.inpOpis.Text= this.produkt.Opis;

            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (this.inpNazwa.Text.Trim().Length == 0) 
            {
                if (MessageBox.Show("Wypełnij pole Nazwa", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)

                    this.inpNazwa.Focus();
            }
            this.produkt = new Produkt(this.db);
            this.produkt.Nazwa= this.inpNazwa.Text;
            this.produkt.Opis= this.inpOpis.Text;

            if (this.produkt.Id == 0)
                this.produkt.Dodaj();
            else
                this.produkt.Edytuj();

            this.DialogResult = DialogResult.OK;
        }

        


    }
}
