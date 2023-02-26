using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CMDBuddyFinal.Models
{
    public class Conexao : IDisposable
    {
        public MySqlConnection conn;
        private readonly string host = "127.0.0.1";
        private readonly string port = "3306";
        private readonly string db = "cmdbuddydb";
        private readonly string user = "root";
        private readonly string pass = "@Gilberto099";

        public Conexao()
        {
            Conectar();
        }

        private void Conectar()
        {
            string StrConn = "";
            StrConn = "Server=" + host + "; Port=" + port + "; Database=" + db + "; Uid=" + user + "; Pwd=" + pass + ";  ";
            conn = new MySqlConnection(StrConn);
            try
            {
                conn.Open();
            }
            catch (Exception ec)
            {
                throw;
            }
        }

        public void Dispose()
        {
            conn.Close();
            conn.Dispose();
        }
    }
}