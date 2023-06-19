using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piekarnie
{
    public class PozycjaZamowienia
    {
        public Int32 Id = 0;
        public Int32 ProductId = 0;
        public Int32 ZamowienieId = 0;
        public Int32 Ilosc = 0;
        public Decimal Cena = 0;

        public BazaDanych db = null;
        public PozycjaZamowienia(BazaDanych db)
        {
            this.db = db;
        }
        public PozycjaZamowienia(Int32 Id, BazaDanych db)
        {
            this.Id = Id;
            try
            {
                this.db = db;
                this.Pobierz();
            }
            catch (Exception ex) { throw new Exception("PozycjaZamowienia" + Environment.NewLine + ex.Message); }

        }

        public void Pobierz()
        {
            String sql = "SELECT [ID], [produkt_id],[zamowienie_id] ,[ilosc] ,[cena] ";
            sql += " FROM [Zamowienie_produkty] WHERE [ID]=" + this.Id.ToString();

            try
            {
                SqlCommand cmd = new SqlCommand(sql, this.db.Polaczenie);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.Id = reader.GetInt32(0);
                    this.ProductId = reader.GetInt32(1);
                    this.ZamowienieId = reader.GetInt32(2);
                    this.Ilosc = reader.GetInt32(3);
                    this.Cena = reader.GetDecimal(4);
                }
            }
            catch (Exception ex) { throw new Exception("PozycjaZamowienia->Pobierz" + Environment.NewLine + ex.Message); }
        }

        public void Usun()
        {
            String sql = "DELETE FROM [Zamowienie_produkty] WHERE [ID]="+this.Id.ToString();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, this.db.Polaczenie);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("PozycjaZamowienia->Usun" + Environment.NewLine + ex.Message); }
        }

        public void Dodaj()
        {
            String sql = "INSERT INTO [Zamowienie_produkty] ([produkt_id], [ilosc], [cena], [zamowienie_id]) ";
            sql += " VALUES ";
            sql += "(" + this.ProductId.ToString() + ", " + this.Ilosc.ToString() + ",@p1," + this.ZamowienieId.ToString() + ")";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, this.db.Polaczenie);
                cmd.Parameters.AddWithValue("@p1", this.Cena);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("PozycjaZamowienia->Dodaj" + Environment.NewLine + ex.Message); }
        }

        public void Edytuj()
        {
            String sql = "UPDATE [Zamowienie_produkty] SET ";
            sql += "[ilosc]=" + this.Ilosc.ToString();
            sql += ", [cena]=@p1 ";
            sql += " WHERE [ID]=" + this.Id.ToString();

            try
            {
                SqlCommand cmd = new SqlCommand(sql, this.db.Polaczenie);
                cmd.Parameters.AddWithValue("@p1", this.Cena);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("PozycjaZamowienia->Edytuj" + Environment.NewLine + ex.Message); }
        }
    }
}
