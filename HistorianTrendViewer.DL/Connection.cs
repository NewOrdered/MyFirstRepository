using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HistorianTrendViewer.DL
{
    public class Connection
    {
        public static string GetConnectionString(string _servername, string _database, string _loginid, string _password, bool _trustedconnection, int _timeout)
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();

            sb.DataSource = _servername;
            sb.InitialCatalog = _database;
            sb.Pooling = true;
            sb.IntegratedSecurity = _trustedconnection;
            sb.UserID = _loginid;
            sb.Password = _password;
            sb.ConnectTimeout =_timeout;

            return sb.ConnectionString;
        }

        public static bool CheckConnection(string _connectionstring)
        {
            using (SqlConnection c = new SqlConnection(_connectionstring))
            {
                try
                {
                    c.Open();
                    return true;
                }

                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
