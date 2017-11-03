using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace LezizSofralar.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Instructions { get; set; }
    }

    public class Db : Database<Db>
    {
        public Table<Recipe> Recipes { get; set; }
    }



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
  


