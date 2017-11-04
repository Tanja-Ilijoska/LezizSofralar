using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace LezizSofralar.Models
{
    public static class Current
    {
        public static Db DbInit
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["lezizsofralarEntities3"].ConnectionString;
                var conn = new MySqlConnection("Server = localhost; Database = lezizsofralar; UID = root; Password = admin; SslMode=none");
                conn.Open();
                return Db.Init(conn, commandTimeout: 30);
            }
        }
    }
}