using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piekarnie
{
    public class Uzytkownik
    {
        public Int32 Id = 0;
        public String Login = "";
        public String Imie = "";
        public String Nazwisko = "";
        public String Haslo = "";
        public Boolean Aktywny = false;
        
        // uprawnienia
        public Int32 MagazynId = 0;
        public Boolean Zamowienia_podglad = false;
        public Boolean Zamowienia_edycja = false;
        public Boolean Produkty_podglad = false;
        public Boolean Produkty_edycja = false;
        public Boolean Magazyn_podglad = false;
        public Boolean Magazyn_edycja = false;
        public Boolean Podmiot_podglad = false;
        public Boolean Podmiot_edycja = false;

        public BazaDanych db = null;

        public Uzytkownik(BazaDanych db)
        {
            this.db = db;
        }
        public Uzytkownik(Int32 Id, BazaDanych db)
        {
            this.Id = Id;
            try
            {
                this.db = db;
                this.Pobierz();
            }
            catch (Exception ex) { throw new Exception("Uzytkownik" + Environment.NewLine + ex.Message); }

            this.db = db;
        }
        public Uzytkownik(String Login, String haslo, BazaDanych db)
        {
            try
            {
                this.db = db;
                this.Login = Login;
                this.Haslo = haslo;
                this.Pobierz();
            }
            catch (Exception ex) { throw new Exception("Uzytkownik" + Environment.NewLine + ex.Message); }
        }

        public void Pobierz()
        {
            String sql = "SELECT [ID], [Login],[Imie] ,[Nazwisko] ,[haslo] ,[data] ,ISNULL([magazyn_id],-1) AS [magazyn_id] ,[zamowienia_podglad] ,[zamowienia_edycja] ,[produkty_podglad] ,[produkty_edycja] ,[magazyny_podglad] ,[magazyny_edycja] ,[podmiot_podglad] ,[podmiot_edycja], [aktywny] ";
            sql += " FROM [Uzytkownik] ";

            if (this.Id > 0)
                sql += " WHERE [ID]=" + this.Id.ToString();
            else if (this.Login.Trim().Length > 0 & this.Haslo != "")
                sql += " WHERE [Login]='" + this.Login + "' AND [haslo]='" + this.Haslo + "'";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, this.db.Polaczenie);
                SqlDataReader reader= cmd.ExecuteReader();
                while(reader.Read())
                {
                    this.Id = reader.GetInt32(0);
                    this.Login = reader.GetString(1);
                    this.Imie = reader.GetString(2);
                    this.Nazwisko = reader.GetString(3);
                    this.Haslo = reader.GetString(4);

                    this.MagazynId = reader.GetInt32(6);
                    this.Zamowienia_podglad = reader.GetBoolean(7);
                    this.Zamowienia_edycja = reader.GetBoolean(8);
                    this.Produkty_podglad = reader.GetBoolean(9);
                    this.Produkty_edycja = reader.GetBoolean(10);
                    this.Magazyn_podglad = reader.GetBoolean(11);
                    this.Magazyn_edycja = reader.GetBoolean(12);
                    this.Podmiot_podglad = reader.GetBoolean(13);
                    this.Podmiot_edycja = reader.GetBoolean(14);
                    this.Aktywny = reader.GetBoolean(15);
                }
            }
            catch (Exception ex) { throw new Exception("Uzytkownik->PobierzUzytkownika" + Environment.NewLine + ex.Message); }
        }

        public void Dodaj()
        {
            String sql = "INSERT INTO [Uzytkownik] ([Login],[Imie] ,[Nazwisko] ,[haslo] ,[data] ,[magazyn_id] ,[zamowienia_podglad] ,[zamowienia_edycja] ,[produkty_podglad] ,[produkty_edycja] ,[magazyny_podglad] ,[magazyny_edycja] ,[podmiot_podglad] ,[podmiot_edycja], [aktywny]) ";
            sql += " VALUES ";
            sql += "('"+this.Login+"','"+this.Imie+"','"+this.Nazwisko+"','"+this.Haslo+"',GETDATE(),"+this.MagazynId.ToString()+",";
            sql += this.Zamowienia_podglad.ToString()+", "+this.Zamowienia_edycja.ToString()+","+this.Produkty_podglad.ToString()+","+this.Produkty_edycja.ToString()+",";
            sql += this.Magazyn_podglad.ToString() + "," + this.Magazyn_edycja.ToString() + "," + this.Podmiot_podglad.ToString() + "," + this.Podmiot_edycja.ToString() + ", " + this.Aktywny.ToString() + ")";

            try
            {
                SqlCommand cmd = new SqlCommand(sql,this.db.Polaczenie);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Uzytkownik->Dodaj" + Environment.NewLine + ex.Message); }
        }

        public void Edytuj()
        {
            String sql = "UPDATE [Uzytkownik] SET ";
            sql += "[Login]='" + this.Login + "', ";
            sql += "[Imie]='" + this.Imie + "', ";
            sql += "[Nazwisko]='" + this.Nazwisko + "', ";
            sql += "[haslo]='" + this.Haslo + "', ";
            sql += "[magazyn_id]=" + this.MagazynId.ToString();
            sql += ",[zamowienia_podglad]=" + this.Zamowienia_podglad.ToString();
            sql += ",[zamowienia_edycja]=" + this.Zamowienia_edycja.ToString();
            sql += ",[produkty_podglad]=" + this.Produkty_podglad.ToString();
            sql += ",[produkty_edycja]=" + this.Produkty_edycja.ToString();
            sql += ",[magazyny_podglad]=" + this.Magazyn_podglad.ToString();
            sql += ",[produkty_edycja]=" + this.Magazyn_edycja.ToString();
            sql += ",[podmiot_podglad]=" + this.Podmiot_podglad.ToString();
            sql += ",[podmiot_edycja]=" + this.Podmiot_edycja.ToString();
            sql += ",[aktywny]=" + this.Aktywny.ToString();
            sql += " WHERE ID="+this.Id.ToString();
        }

    }
}
