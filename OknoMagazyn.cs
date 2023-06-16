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

            }


        }
    }
}
