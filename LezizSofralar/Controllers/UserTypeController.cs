using LezizSofralar.Models;
using LezizSofralar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LezizSofralar.Controllers
{
    public class UserTypeController : StandardGenericController<UserTypeListViewModel, UserTypeViewModel, UserType>
    {
        public override IEnumerable<UserType> GetDataset()
        {
            IEnumerable<Models.UserType> dbItems = Current.DbInit.UserType.All();
            return dbItems;
        }

        public override UserType GetItem(int id)
        {
            return Current.DbInit.UserType.Get(id);
        }

        public override bool ProjectDeleteToEntity(int ID)
        {
            return Current.DbInit.UserType.Delete(new { Id = ID });
        }

        public override long ProjectInsertToEntity(UserTypeViewModel model)
        {
            return
                Current.DbInit.UserType.Insert(
                new
                {
                    Name = model.Name,
                    ManageCategories = model.ManageCategories,
                    ManageLocations = model.ManageLocations,
                    ManageFilters = model.ManageFilters,
                    ManageUsers = model.ManageUsers,
                    ManageRecipes = model.ManageRecipes,
                    ManageOwnRecipes = model.ManageOwnRecipes
                });
        }

        public override List<UserTypeListViewModel> ProjectToListViewModel(IEnumerable<UserType> dbItems)
        {
            List<UserTypeListViewModel> model = new List<UserTypeListViewModel>();
            if (dbItems != null && dbItems.Count() > 0)
                foreach (var item in dbItems)
                {
                    model.Add(new UserTypeListViewModel()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        ManageCategories = item.ManageCategories,
                        ManageFilters = item.ManageFilters,
                        ManageLocations = item.ManageLocations,
                        ManageOwnRecipes = item.ManageOwnRecipes,
                        ManageRecipes = item.ManageRecipes,
                        ManageUsers = item.ManageUsers
                    });
                }

            return model;
        }

        public override UserTypeViewModel ProjectToViewModel(UserType dbItem)
        {
            UserTypeViewModel model = new UserTypeViewModel();
            model.Id = dbItem.Id;
            model.Name = dbItem.Name;
            model.ManageCategories = dbItem.ManageCategories;
            model.ManageFilters = dbItem.ManageFilters;
            model.ManageLocations = dbItem.ManageLocations;
            model.ManageOwnRecipes = dbItem.ManageOwnRecipes;
            model.ManageRecipes = dbItem.ManageRecipes;
            model.ManageUsers = dbItem.ManageUsers;
            return model;
        }

        public override long ProjectUpdateToEntity(UserType dbItem, UserTypeViewModel model)
        {
            dbItem.Id = model.Id;
            dbItem.Name = model.Name;
            dbItem.ManageCategories = model.ManageCategories;
            dbItem.ManageFilters = model.ManageFilters;
            dbItem.ManageLocations = model.ManageLocations;
            dbItem.ManageOwnRecipes = model.ManageOwnRecipes;
            dbItem.ManageRecipes = model.ManageRecipes;
            dbItem.ManageUsers = model.ManageUsers;
            return Current.DbInit.UserType.Update(dbItem.Id, dbItem);

        }        
    }
}
