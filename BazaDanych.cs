using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Piekarnie
{
    public class BazaDanych
    {
        private String serwer = @"localhost\SQLEXPRESS";
        private String uzytkownik = "sa";
        private String haslo = "";
        private Boolean authWin = true;
        private String baza = "Piekarnia";

        public SqlConnection Polaczenie = null;

        public BazaDanych() 
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.ApplicationName = "Piekarnia";
            sb.DataSource = serwer;
            sb.InitialCatalog = baza;
            sb.IntegratedSecurity = authWin;
            sb.Password = haslo;
            sb.UserID = uzytkownik;
            sb.MultipleActiveResultSets = true;

            Polaczenie = new SqlConnection(sb.ConnectionString);
            Polaczenie.Open();
        }


    }
}
