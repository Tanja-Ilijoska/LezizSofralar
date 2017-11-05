using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.Models
{
    public class Db : Database<Db>
    {
        public Table<Recipe> Recipes { get; set; }
        public Table<Users> Users { get; set; }
        public Table<UserTypes> UserTypes {get; set;}
    }

}