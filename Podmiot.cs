using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piekarnie
{
    public class Podmiot
    {
        public Int32 Id = 0;
        public String Nazwa = "";
        public String Adres = "";
        public String Telefon = "";
        public Int32 Typ = 0;

        public BazaDanych db = null;

        public Podmiot(BazaDanych db)
        {
            this.db = db;
        }
        public Podmiot(Int32 Id, BazaDanych db)
        {
            this.Id = Id;
            try
            {
                this.db = db;
                this.Pobierz();
            }
            catch (Exception ex) { throw new Exception("Podmiot" + Environment.NewLine + ex.Message); }

            this.db = db;
        }

        public void Pobierz()
        {
            if (this.Id > 0)
            {
                String sql = "SELECT [ID], [Nazwa],[Adres] ,[Telefon] ,[Typ]";
                sql += " FROM [Podmiot] WHERE [ID]=" + this.Id.ToString();

                try
                {
                    SqlCommand cmd = new SqlCommand(sql, this.db.Polaczenie);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        this.Id = reader.GetInt32(0);
                        this.Nazwa = reader.GetString(1);
                        this.Adres = reader.GetString(2);
                        this.Telefon = reader.GetString(3);
                        this.Typ = reader.GetInt32(4);
                    }
                }
                catch (Exception ex) { throw new Exception("Podmiot->PobierzPodmiot" + Environment.NewLine + ex.Message); }
            }
        }

        public void Dodaj()
        {
            String sql = "INSERT INTO [Podmiot] ([Nazwa],[Adres],[Telefon],[Typ]) ";
            sql += " VALUES ";
            sql += "('" + this.Nazwa + "','" + this.Adres + "','" + this.Telefon + "'," + this.Typ.ToString() + ")";
           
            try
            {
                SqlCommand cmd = new SqlCommand(sql,this.db.Polaczenie);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Podmiot->Dodaj" + Environment.NewLine + ex.Message); }
        }

        public void Edytuj()
        {
            String sql = "UPDATE [Podmiot] SET ";
            sql += "[Nazwa]='" + this.Nazwa + "', ";
            sql += "[Adres]='" + this.Adres + "', ";
            sql += "[Telefon]='" + this.Telefon + "', ";
            sql += "[Typ]=" + this.Typ.ToString();
            sql += " WHERE ID="+this.Id.ToString();
        }

        public void Usun()
        {
            String sql = "DELETE FROM [Podmiot] WHERE ID=" + this.Id.ToString();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, this.db.Polaczenie);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Magazyn -> Usun" + Environment.NewLine + ex.Message); }
        }
    }
}
