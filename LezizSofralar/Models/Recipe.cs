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

        public string DisplayName { get; set; }

        public int DisplayOrder { get; set; }

        public string Description { get; set; }

        public string FeaturedImage { get; set; }

        public string FriendlyURI { get; set; }

        //?
        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        public int ProductStatusCodeID { get; set; } //TO DO implement relation

        public int CreateUserID { get; set; }

        public System.DateTime CreateTime { get; set; }

        public System.DateTime UpdateTime { get; set; }

        public int UpdateUserID { get; set; }

        public bool IsActive { get; set; }
        //stavki
        public virtual IEnumerable<RecipeAttribute> RecipeAttributes { get; set; }
        //  public virtual IEnumerable<RecipeLinks> RecipeLinks { get; set; }
        //  public virtual IEnumerable<RecipeTags> RecipeTags { get; set; }

    }
}
  


