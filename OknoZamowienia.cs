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
        Int32 typPodmiotu = (int)TypPodmiotu.Piekarnia;
        public OknoZamowienia(Int32 Typ, BazaDanych db)
        {
            InitializeComponent();
            this.db = db;
            this.typPodmiotu = Typ;
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
                    foreach(DataRow pozycja in List.pobierzPozycjeZam(this.zam.Id, this.db).Rows)
                    {
                        
                    }
                }
                else
                {
                    this.inpPodmiot.Items.Add(new PozycjaListyRozwijanej(-1, "Wybiera"));
                    Status stat = new Status(1, this.db);
                    this.inpStatus.Items.Add(new PozycjaListyRozwijanej(1, stat.Nazwa));

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
                if (this.inpStatus.Items.Count <= 1)
                {
                    foreach (DataRow pod in List.pobierzStatusy(this.db).Rows)
                    {
                        this.inpStatus.Items.Add(new PozycjaListyRozwijanej((int)pod["ID"], pod["Nazwa"].ToString()));
                    }
                }
            }
            catch (Exception ex) { }
        }
    }
}
