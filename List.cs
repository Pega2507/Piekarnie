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
            catch (Exception ex) { throw new Exception("List->pobierzMagazyny " + Environment.NewLine + ex.Message); }

            return tab;
        }
    }
}
