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
        public Boolean Status_podglad = false;
        public Boolean Status_edycja = false;
        public Boolean Uzytkownik_podglad = false;
        public Boolean Uzytkownik_edycja = false;
        public Boolean Historia_podglad = false;

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
            String sql = "SELECT [ID], [Login],[Imie] ,[Nazwisko] ,[haslo] ,[data] ,ISNULL([magazyn_id],-1) AS [magazyn_id] ,[zamowienia_podglad] ,[zamowienia_edycja] ,[produkty_podglad] ,[produkty_edycja] ,[magazyny_podglad] ,[magazyny_edycja] ,[podmiot_podglad] ,[podmiot_edycja], [aktywny], [statusy_podglad], [statusy_edycja], [uzytkownicy_podglad], [uzytkownicy_edycja], [historia_podglad] ";
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
                    this.Status_podglad= reader.GetBoolean(16);
                    this.Status_edycja= reader.GetBoolean(17);
                    this.Uzytkownik_podglad= reader.GetBoolean(18);
                    this.Uzytkownik_edycja =reader.GetBoolean(19);
                    this.Historia_podglad= reader.GetBoolean(20);
                }
            }
            catch (Exception ex) { throw new Exception("Uzytkownik->PobierzUzytkownika" + Environment.NewLine + ex.Message); }
        }

        public void Dodaj()
        {
            String sql = "INSERT INTO [Uzytkownik] ([Login],[Imie] ,[Nazwisko] ,[haslo] ,[data] ,[magazyn_id] ,[zamowienia_podglad] ,[zamowienia_edycja] ,[produkty_podglad] ,[produkty_edycja] ,[magazyny_podglad] ,[magazyny_edycja] ,[podmiot_podglad] ,[podmiot_edycja], [aktywny], [statusy_podglad], [statusy_edycja], [uzytkownicy_podglad], [uzytkownicy_edycja], [historia_podglad]) ";
            sql += " VALUES ";
            sql += "('" + this.Login + "','" + this.Imie + "','" + this.Nazwisko + "','" + this.Haslo + "',GETDATE(),";
            if (this.MagazynId > 0)
                sql += this.MagazynId.ToString() + ",";
            else
                sql += "NULL,";
            sql += "@p1, @p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)";


            try
            {
                SqlCommand cmd = new SqlCommand(sql,this.db.Polaczenie);
                cmd.Parameters.AddWithValue("@p1", this.Zamowienia_podglad);
                cmd.Parameters.AddWithValue("@p2", this.Zamowienia_edycja);
                cmd.Parameters.AddWithValue("@p3", this.Produkty_podglad);
                cmd.Parameters.AddWithValue("@p4", this.Produkty_edycja);
                cmd.Parameters.AddWithValue("@p5", this.Magazyn_podglad);
                cmd.Parameters.AddWithValue("@p6", this.Magazyn_edycja);
                cmd.Parameters.AddWithValue("@p7", this.Podmiot_podglad);
                cmd.Parameters.AddWithValue("@p8", this.Podmiot_edycja);
                cmd.Parameters.AddWithValue("@p9", this.Aktywny);
                cmd.Parameters.AddWithValue("@p10", this.Status_podglad);
                cmd.Parameters.AddWithValue("@p11", this.Status_edycja);
                cmd.Parameters.AddWithValue("@p12", this.Uzytkownik_podglad);
                cmd.Parameters.AddWithValue("@p13", this.Uzytkownik_edycja);
                cmd.Parameters.AddWithValue("@p14", this.Historia_podglad);

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
            if (this.MagazynId > 0)
                sql += "[magazyn_id]=" + this.MagazynId.ToString();
            else
                sql += "[magazyn_id]=NULL";
            sql += ",[zamowienia_podglad]=@p1";
            sql += ",[zamowienia_edycja]=@p2";
            sql += ",[produkty_podglad]=@p3";
            sql += ",[produkty_edycja]=@p4";
            sql += ",[magazyny_podglad]=@p5";
            sql += ",[produkty_edycja]=@p6";
            sql += ",[podmiot_podglad]=@p7";
            sql += ",[podmiot_edycja]=@p8";
            sql += ",[aktywny]=@p9";
            sql += ",[statusy_podglad]=@p10";
            sql += ",[statusy_edycja]=@p11";
            sql += ",[uzytkownicy_podglad]=@p12";
            sql += ",[uzytkownicy_edycja]=@p13";
            sql += ",[historia_podglad]=@p14";
            sql += " WHERE ID="+this.Id.ToString();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, this.db.Polaczenie);
                cmd.Parameters.AddWithValue("@p1", this.Zamowienia_podglad);
                cmd.Parameters.AddWithValue("@p2", this.Zamowienia_edycja);
                cmd.Parameters.AddWithValue("@p3", this.Produkty_podglad);
                cmd.Parameters.AddWithValue("@p4", this.Produkty_edycja);
                cmd.Parameters.AddWithValue("@p5", this.Magazyn_podglad);
                cmd.Parameters.AddWithValue("@p6", this.Magazyn_edycja);
                cmd.Parameters.AddWithValue("@p7", this.Podmiot_podglad);
                cmd.Parameters.AddWithValue("@p8", this.Podmiot_edycja);
                cmd.Parameters.AddWithValue("@p9", this.Aktywny);
                cmd.Parameters.AddWithValue("@p10", this.Status_podglad);
                cmd.Parameters.AddWithValue("@p11", this.Status_edycja);
                cmd.Parameters.AddWithValue("@p12", this.Uzytkownik_podglad);
                cmd.Parameters.AddWithValue("@p13", this.Uzytkownik_edycja);
                cmd.Parameters.AddWithValue("@p14", this.Historia_podglad);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Uzytkownik->Edytuj" + Environment.NewLine + ex.Message); }
        }

        public void Usun()
        {
            String sql = "DELETE FROM [Uzytkownik] WHERE [ID]=" + this.Id.ToString();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, this.db.Polaczenie);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Uzytkownik->Usuń" + Environment.NewLine + ex.Message); }
        }

    }
}
