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
    public partial class OknoStatus : Form
    {
        private Status status;
        private BazaDanych db = null;
        public OknoStatus(BazaDanych db)
        {
            InitializeComponent();
            this.db = db;
        }

        public OknoStatus(Int32 Id, BazaDanych db)
        {
            InitializeComponent();
            this.db = db;
            try
            {
                this.status = new Status(Id, this.db);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void OknoStatus_Shown(object sender, EventArgs e)
        {
            if (this.status != null)
            {
                this.inpZapisz.Text = this.status.Nazwa;
            }

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (this.inpZapisz.Text.Trim().Length == 0)
            {
                if (MessageBox.Show("Wypełnij pole Nazwa", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)

                    this.inpZapisz.Focus();
            }
            this.status = new Status(this.db);
            this.status.Nazwa = this.inpZapisz.Text;

            if (this.status.Id == 0)
                this.status.Dodaj();
            else
                this.status.Edytuj();

            this.DialogResult = DialogResult.OK;
        }
    }
}
