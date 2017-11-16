using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LezizSofralar.ViewModels;
using LezizSofralar.Models;

namespace LezizSofralar.Controllers
{
    public class RecipeController : StandardGenericController<RecipesListViewModel, RecipesViewModel, Recipe>
    {
        public override IEnumerable<Recipe> GetDataset()
        {
            IEnumerable<Recipe> all = Current.DbInit.Recipe.All();
            return all;
        }

        public override Recipe GetItem(int id)
        {
            return Current.DbInit.Recipe.Get(id);
        }

        public override List<RecipesListViewModel> ProjectToListViewModel(IEnumerable<Recipe> dbItems)
        {
            List<RecipesListViewModel> model = new List<RecipesListViewModel>();
            foreach (var item in dbItems)
            {
                model.Add(new RecipesListViewModel
                {
                    ID = item.Id,
                    DisplayName = item.DisplayName,
                    Description = item.Description
                });
            }
            return model;
        }

        public override RecipesViewModel ProjectToViewModel(Recipe dbItem)
        {
            RecipesViewModel model = new RecipesViewModel();
            model.Id = dbItem.Id;
            model.DisplayName = dbItem.DisplayName;
            model.DisplayOrder = dbItem.DisplayOrder;
            model.Description = dbItem.Description;
            model.FeaturedImage = dbItem.FeaturedImage;
            model.FriendlyURI = dbItem.FriendlyURI;
            model.MetaKeywords = dbItem.MetaKeywords;
            model.MetaDescription = dbItem.MetaDescription;
            model.ProductStatusCodeID = dbItem.ProductStatusCodeID;
            return model;
        }

        public override long ProjectInsertToEntity(RecipesViewModel model)
        {
            return
              Current.DbInit.Recipe.Insert(
              new
              {
                    DisplayName = model.DisplayName,
                    DisplayOrder = model.DisplayOrder,
                    Description = model.Description,
                    FeaturedImage = model.FeaturedImage,
                    FriendlyURI = model.FriendlyURI,
                    MetaKeywords = model.MetaKeywords,
                    MetaDescription = model.MetaDescription,
                    ProductStatusCodeID = model.ProductStatusCodeID
            });
        }

        public override long ProjectUpdateToEntity(Recipe dbItem, RecipesViewModel model)
        {
            dbItem.Id = model.Id;
            dbItem.Id = model.Id;
            dbItem.DisplayName = model.DisplayName;
            dbItem.DisplayOrder = model.DisplayOrder;
            dbItem.Description = model.Description;
            dbItem.FeaturedImage = model.FeaturedImage;
            dbItem.FriendlyURI = model.FriendlyURI;
            dbItem.MetaKeywords = model.MetaKeywords;
            dbItem.MetaDescription = model.MetaDescription;
            dbItem.ProductStatusCodeID = model.ProductStatusCodeID;
            return Current.DbInit.Recipe.Update(dbItem.Id, dbItem);

        }

        public override bool ProjectDeleteToEntity(int ID)
        {
            return Current.DbInit.Recipe.Delete(new { Id = ID });

        }


    }
}
