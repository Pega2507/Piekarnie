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
        private Int32 Id = 0;
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
            catch (Exception ex) { throw new Exception("Uzytkownik" + Environment.NewLine + ex.Message); }

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
            catch (Exception ex) { throw new Exception("Uzytkownik->PobierzUzytkownika" + Environment.NewLine + ex.Message); }
        }
    }
}
