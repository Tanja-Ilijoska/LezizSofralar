using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.Models
{
    public class RecipeLocation
    {
        public int Id { get; set; }

        public int RecipeID { get; set; }

        public int LocationID { get; set; }
    }
}