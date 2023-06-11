using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piekarnie
{
    public class Historia
    {
        private Int32 Id = 0;
        public Int32 ObiektId = 0;
        public Int32 ObiektTyp = 0;
        public String Opis = "";
        DateTime Data= new DateTime();

        public BazaDanych db = null;

        public Historia(BazaDanych db)
        {
            this.db = db;
        }
        public Historia(Int32 Id, BazaDanych db)
        {
            this.Id = Id;
            try
            {
                this.db = db;
                this.Pobierz();
            }
            catch (Exception ex) { throw new Exception("Historia" + Environment.NewLine + ex.Message); }

            this.db = db;
        }
        

        public void Pobierz()
        {
            if (this.Id > 0)
            {
                String sql = "SELECT [data], [obiekt_id], [obiekt_typ], [opis]";
                sql += " FROM [Historia] WHERE [ID]=" + this.Id.ToString();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, this.db.Polaczenie);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        this.Data = reader.GetDateTime(0);
                        this.ObiektId = reader.GetInt32(1);
                        this.ObiektTyp = reader.GetInt32(2);
                        this.Opis = reader.GetString(3);


                    }
                }
                catch (Exception ex) { throw new Exception("Historia->PobierzHistoriaa" + Environment.NewLine + ex.Message); }
            }
        }

        public void Dodaj()
        {
            String sql = "INSERT INTO [Historia] ([obiekt_id], [obiekt_typ], [data], [Opis]) ";
            sql += " VALUES ";
            sql += "("+this.ObiektId.ToString()+","+this.ObiektTyp.ToString()+",'"+this.Data.ToString("yyyy-MM-dd")+"','"+this.Opis+"')";

            try
            {
                SqlCommand cmd = new SqlCommand(sql,this.db.Polaczenie);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Historia->Dodaj" + Environment.NewLine + ex.Message); }
        }

        public void Edytuj()
        {
            String sql = "UPDATE [Historia] SET ";
            sql += "[obiekt_id]='" + this.ObiektId.ToString() + "', ";
            sql += "[obiekt_typ]='" + this.ObiektTyp.ToString() + "', ";
            sql += "[data]='" + this.Data.ToString("yyyy-MM-dd") + "', ";
            sql += "[Opis]='" + this.Opis + "' ";
            sql += " WHERE ID="+this.Id.ToString();
        }
    }
}
