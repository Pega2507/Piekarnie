using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piekarnie
{
    public class Produkt
    {
        public Int32 Id = 0;
        public String Nazwa = "";
        public String Opis = "";
        
        public BazaDanych db = null;

        public Produkt(BazaDanych db)
        {
            this.db = db;
        }
        public Produkt(Int32 Id, BazaDanych db)
        {
            this.Id = Id;
            try
            {
                this.db = db;
                this.Pobierz();
            }
            catch (Exception ex) { throw new Exception("Produkt" + Environment.NewLine + ex.Message); }

            this.db = db;
        }

        public void Pobierz()
        {
            if (this.Id > 0)
            {
                String sql = "SELECT [ID], [Nazwa], [Opis] ";
                sql += " FROM [Produkt]  WHERE [ID]=" + this.Id.ToString();

                try
                {
                    SqlCommand cmd = new SqlCommand(sql, this.db.Polaczenie);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        this.Id = reader.GetInt32(0);
                        this.Nazwa = reader.GetString(1);
                        this.Opis = reader.GetString(2);
                    }
                }
                catch (Exception ex) { throw new Exception("Produkt->PobierzProdukt" + Environment.NewLine + ex.Message); }
            }
        }

        public void Dodaj()
        {
            String sql = "INSERT INTO [Produkt] ([Nazwa],[Opis]) ";
            sql += " VALUES ";
            sql += "('" + this.Nazwa + "','" + this.Opis + "')";
            try
            {
                SqlCommand cmd = new SqlCommand(sql,this.db.Polaczenie);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Produkt->Dodaj" + Environment.NewLine + ex.Message); }
        }

        public void Edytuj()
        {
            String sql = "UPDATE [Produkt] SET ";
            sql += "[Nazwa]='" + this.Nazwa + "', ";
            sql += "[Opis]='" + this.Opis + "' ";
            sql += " WHERE ID="+this.Id.ToString();
        }
    }
}
