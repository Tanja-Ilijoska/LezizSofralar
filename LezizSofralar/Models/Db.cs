using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.Models
{
    public class Db : Database<Db>
    {
        public Table<Recipe> Recipe { get; set; }
        public Table<Attribute> Attribute { get; set; }
        public Table<RecipeAttribute> RecipeAttribute { get; set; }
        public Table<User> User { get; set; }
        public Table<UserType> UserType {get; set;}
        public Table<CookingLevel> CookingLevel { get; set; }
        public Table<ProductStatusCode> ProductStatusCode { get; set; }
        public Table<Category> Category { get; set; }
        public Table<Location> Location { get; set; }
        public Table<LogChange> LogChange { get; set; }
        public Table<RecipeCategory> RecipeCategorie { get; set; }
        public Table<RecipeLocation> RecipeLocation { get; set; }
        public Table<UserFavouriteAuthor> UserFavouriteAuthor { get; set; }
        public Table<UserFavouriteRecipe> UserFavouriteRecipe { get; set; }
        public Table<UserFollower> UserFollower { get; set; }
        public Table<UserReputation> UserReputation { get; set; }
        public Table<UserSocialProfile> UserSocialProfile { get; set; }
    }

}