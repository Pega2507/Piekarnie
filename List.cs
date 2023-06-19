using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piekarnie
{
    public static class List
    {
        public static DataTable pobierzMagazyny(BazaDanych db)
        {
            DataTable tab= new DataTable();

            try
            {
                String sql = "SELECT m.[ID], m.[Nazwa], m.[piekarnia_id], p.[Nazwa] AS Piekarnia FROM [Magazyn] m";
                sql += " LEFT JOIN [Podmiot] p ON (p.[ID]=m.[piekarnia_id])";
                SqlCommand cmd = new SqlCommand(sql, db.Polaczenie);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tab);
            }
            catch(Exception ex) { throw new Exception("List->pobierzMagazyny " + Environment.NewLine + ex.Message); }

            return tab;
        }

        public static DataTable pobierzUzytkownikow(BazaDanych db)
        {
            DataTable tab = new DataTable();

            try
            {
                String sql = "SELECT [ID], [Login], [Imie], [Nazwisko], [aktywny] FROM [Uzytkownik]";
                SqlCommand cmd = new SqlCommand(sql, db.Polaczenie);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tab);
            }
            catch (Exception ex) { throw new Exception("List->pobierzUzytkownikow " + Environment.NewLine + ex.Message); }

            return tab;
        }
        public static DataTable pobierzPodmioty(Int32 Typ, BazaDanych db)
        {
            DataTable tab = new DataTable();

            try
            {
                String sql = "SELECT [ID], [Nazwa],[Adres] ,[Telefon] FROM [Podmiot] WHERE [Typ]=" + Typ.ToString() + " ORDER BY [Nazwa] ASC";
                SqlCommand cmd = new SqlCommand(sql, db.Polaczenie);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tab);
            }
            catch (Exception ex) { throw new Exception("List->pobierzPodmioty " + Environment.NewLine + ex.Message); }

            return tab;
        }
        public static DataTable pobierzStatusy(BazaDanych db)
        {
            DataTable tab = new DataTable();

            try
            {
                String sql = "SELECT [ID], [Nazwa] FROM [Statusy]  ORDER BY [Nazwa] ASC";
                SqlCommand cmd = new SqlCommand(sql, db.Polaczenie);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tab);
            }
            catch (Exception ex) { throw new Exception("List->pobierzStatusy " + Environment.NewLine + ex.Message); }

            return tab;
        }
        public static DataTable pobierzPozycjeZam(Int32 zamId, BazaDanych db)
        {
            DataTable tab = new DataTable();

            try
            {
                String sql = "SELECT p.[ID], pr.[Nazwa] ,p.[ilosc] ,p.[cena], (p.[ilosc]*p.[cena]) AS wartosc FROM [Zamowienie_produkty] p";
                sql += " LEFT JOIN [Produkt] pr ON (pr.[ID]=p.[produkt_id]) ";
                sql += " WHERE [zamowienie_id]=" + zamId.ToString();
                SqlCommand cmd = new SqlCommand(sql, db.Polaczenie);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tab);
            }
            catch (Exception ex) { throw new Exception("List->pobierzPozycjeZam " + Environment.NewLine + ex.Message); }

            return tab;
        }
    }
}
