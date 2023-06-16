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
        public OknoZamowienia(BazaDanych db)
        {
            InitializeComponent();
            this.db = db;
        }
        public OknoZamowienia(Int32 Id, BazaDanych db)
        {
            InitializeComponent();
            try
            {
                this.db = db;
                this.zam = new Zamowienie(Id, this.db);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void OknoZamowienia_Shown(object sender, EventArgs e)
        {
            if(this.zam != null)
            {
                
            }
        }
    }
}
