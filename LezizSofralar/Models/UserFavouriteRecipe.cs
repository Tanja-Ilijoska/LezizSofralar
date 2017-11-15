using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.Models
{
    public class UserFavouriteRecipe
    {
        public int Id { get; set; }

        public int UserID { get; set; }

        public int RecipeID { get; set; }
    }
}