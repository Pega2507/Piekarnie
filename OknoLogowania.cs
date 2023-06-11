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
    public partial class OknoLogowania : Form
    {
        private BazaDanych db = null;
        public Uzytkownik uzytkownik  = null;
        public OknoLogowania(BazaDanych db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(this.inpLogin.Text.Trim().Length== 0 ) 
            { 
                this.inpLogin.Focus();
                return;
            }
            if(this.inpHaslo.Text.Trim().Length== 0 ) 
            {
                this.inpHaslo.Focus();
                return;
            }

            try
            {
                this.uzytkownik = new Uzytkownik(this.inpLogin.Text, this.inpHaslo.Text, this.db);
                if(uzytkownik.Id>0 ) 
                {
                    this.DialogResult= DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Niepoprawne logowanie","Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            catch(Exception ex) { }

        }
    }
}
