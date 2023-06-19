using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piekarnie
{
    public class Zamowienie
    {
        public Int32 Id = 0;
        public Int32 PodmiotId = 0;
        public Int32 Typ = 0;
        public Int32 StatusId = 0;
        public Int32 MagazynId = 0;
        public DateTime Data = new DateTime();

        public BazaDanych db = null;

        public Zamowienie(BazaDanych db)
        {
            this.db = db;
        }
        public Zamowienie(Int32 Id, BazaDanych db)
        {
            this.Id = Id;
            try
            {
                this.db = db;
                this.Pobierz();
            }
            catch (Exception ex) { throw new Exception("Zamowienia" + Environment.NewLine + ex.Message); }

            this.db = db;
        }
       

        public void Pobierz()
        {
            String sql = "SELECT [Data], [podmiot_id], [typ], [status_id], [magazyn_id]";
            sql += " FROM [Zamowienia] WHERE [ID]=" + this.Id.ToString();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, this.db.Polaczenie);
                SqlDataReader reader= cmd.ExecuteReader();
                while(reader.Read())
                {
                    this.Data = reader.GetDateTime(0);
                    this.PodmiotId = reader.GetInt32(1);
                    this.Typ = reader.GetInt32(2);
                    this.StatusId = reader.GetInt32(3);
                    this.MagazynId = reader.GetInt32(4);
                }
            }
            catch (Exception ex) { throw new Exception("Zamowienia->PobierzZamowienie" + Environment.NewLine + ex.Message); }
        }

        public void Dodaj()
        {
            String sql = "INSERT INTO [Zamowienia] ([Data], [podmiot_id], [typ], [status_id], [magazyn_id]) ";
            sql += " VALUES ";
            sql += "('" + this.Data.ToString("yyyy-MM-dd") + "'," + this.PodmiotId.ToString() + ", " + this.Typ.ToString() + ", " + this.StatusId.ToString() + ", "+this.MagazynId.ToString()+")";
            try
            {
                SqlCommand cmd = new SqlCommand(sql,this.db.Polaczenie);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Zamowienia->Dodaj" + Environment.NewLine + ex.Message); }
        }

        public void Edytuj()
        {
            String sql = "UPDATE [Zamowienia] SET ";
            sql += "[data]='" + this.Data.ToString("yyyy-MM-dd") + "'";
            sql += "[podmiot_id]=" + this.PodmiotId.ToString() + ", ";
            sql += "[typ]=" + this.Typ.ToString() + ", ";
            sql += "[status_id]=" + this.StatusId.ToString();
            sql += " WHERE ID="+this.Id.ToString();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, this.db.Polaczenie);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Zamowienia->Edytuj" + Environment.NewLine + ex.Message); }
        }

        public void Usun()
        {
            String sql = "DELETE FROM [Zamowienia] WHERE ID=" + this.Id.ToString();
            try
            {
                DataTable pozycje = List.pobierzPozycjeZam(this.Id, this.db);
                foreach (DataRow pozycja in pozycje.Rows)
                {
                    Int32 id = 0;
                    Int32.TryParse(pozycja["ID"].ToString(), out id);
                    PozycjaZamowienia poz = new PozycjaZamowienia(id, this.db);
                }

                SqlCommand cmd = new SqlCommand(sql, this.db.Polaczenie);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Zamowienia->Edytuj" + Environment.NewLine + ex.Message); }
        }
    }
}
