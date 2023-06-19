using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piekarnie
{
    public class Magazyn
    {
        public Int32 Id = 0;
        public String Nazwa = "";
        public Int32 PiekarniaId = 0;

        public BazaDanych db = null;

        public Magazyn(BazaDanych db)
        {
            this.db = db;
        }
        public Magazyn(Int32 Id, BazaDanych db)
        {
            this.Id = Id;
            try
            {
                this.db = db;
                this.Pobierz();
            }
            catch (Exception ex) { throw new Exception("Magazyn" + Environment.NewLine + ex.Message); }

            this.db = db;
        }
       

        public void Pobierz()
        {
            if (this.Id > 0)
            {
                String sql = "SELECT [Nazwa], ISNULL([piekarnia_id], -1) AS piekarnia_id ";
                sql += " FROM [Magazyn]  WHERE [ID]=" + this.Id.ToString();

                try
                {
                    SqlCommand cmd = new SqlCommand(sql, this.db.Polaczenie);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        this.Nazwa = reader.GetString(0);
                        this.PiekarniaId = reader.GetInt32(1);
                    }
                }
                catch (Exception ex) { throw new Exception("Magazyn->PobierzMagazyn" + Environment.NewLine + ex.Message); }
            }
        }

        public void Dodaj()
        {
            String sql = "INSERT INTO [Magazyn] ([Nazwa], [piekarnia_id]) ";
            sql += " VALUES ";
            sql += "('" + this.Nazwa + "',";
            if (this.PiekarniaId > 0)
                sql += this.PiekarniaId.ToString();
            else
                sql += "NULL";
            sql += ")";
            try
            {
                SqlCommand cmd = new SqlCommand(sql,this.db.Polaczenie);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Magazyn->Dodaj" + Environment.NewLine + ex.Message); }
        }

        public void Edytuj()
        {
            String sql = "UPDATE [Magazyn] SET ";
            sql += "[Nazwa]='" + this.Nazwa + "', ";
            if (this.PiekarniaId > 0)
                sql += "[piekarnia_id]=" + this.PiekarniaId.ToString();
            else
                sql += "[piekarnia_id]=NULL";
            sql += " WHERE ID="+this.Id.ToString();
        }

        public void Usun()
        {
            String sql = "DELETE FROM [Magazyn] WHERE ID=" + this.Id.ToString();
            try
            { 
                SqlCommand cmd = new SqlCommand(sql, this.db.Polaczenie);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Magazyn -> Usun" + Environment.NewLine + ex.Message); }
        }
    }
}
