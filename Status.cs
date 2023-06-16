using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piekarnie
{
    public class Status
    {
        public Int32 Id = 0;
        public String Nazwa = "";

        public BazaDanych db = null;

        public Status(BazaDanych db)
        {
            this.db = db;
        }
        public Status(Int32 Id, BazaDanych db)
        {
            this.Id = Id;
            try
            {
                this.db = db;
                this.Pobierz();
            }
            catch (Exception ex) { throw new Exception("Status" + Environment.NewLine + ex.Message); }

            this.db = db;
        }
       

        public void Pobierz()
        {
            if (this.Id > 0)
            {
                String sql = "SELECT [Nazwa]";
                sql += " FROM [Status]  WHERE [ID]=" + this.Id.ToString();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, this.db.Polaczenie);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        this.Nazwa = reader.GetString(0);
                    }
                }
                catch (Exception ex) { throw new Exception("Status->PobierzStatus" + Environment.NewLine + ex.Message); }
            }
        }

        public void Dodaj()
        {
            String sql = "INSERT INTO [Status] ([Nazwa])";
            sql += " VALUES ";
            sql += "('" + this.Nazwa + "')";
            try
            {
                SqlCommand cmd = new SqlCommand(sql,this.db.Polaczenie);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Status->Dodaj" + Environment.NewLine + ex.Message); }
        }

        public void Edytuj()
        {
            String sql = "UPDATE [Status] SET ";
            sql += "[Nazwa]='" + this.Nazwa + "' ";
            sql += " WHERE ID="+this.Id.ToString();
        }
    }
}
