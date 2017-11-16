using LezizSofralar.Models;
using LezizSofralar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LezizSofralar.Controllers
{
    public class UserController : StandardGenericController<UserListViewModel, UsersViewModel, Models.User>
    {
        public override IEnumerable<User> GetDataset()
        {
            IEnumerable<Models.User> dbitems = Current.DbInit.User.All();
            return dbitems;
        }

        public override User GetItem(int id)
        {
            return Current.DbInit.User.Get(id);
        }

        public override bool ProjectDeleteToEntity(int ID)
        {
            return Current.DbInit.User.Delete(new { Id = ID });
        }

        public override long ProjectInsertToEntity(UsersViewModel model)
        {
            return
                Current.DbInit.Attribute.Insert(
                new
                {
                    Name = model.Name,
                    UserName = model.UserName,
                    LastName = model.LastName,
                    UserTypeID = model.UserTypeID,
                    LastUserVisit = model.LastUserVisit,
                    LocationID = model.LocationID,
                    UserWebsiteURL = model.UserWebsiteURL,
                    RegistrationDate = model.RegistrationDate,
                    ReputationScore = model.ReputationScore,
                    About = model.About,
                    Avatar = model.Avatar,
                    CookingLevelID = model.CookingLevelID
                });
        }

        public override List<UserListViewModel> ProjectToListViewModel(IEnumerable<User> dbItems)
        {
            List<UserListViewModel> model = new List<UserListViewModel>();
            if (dbItems != null && dbItems.Count() > 0)
                foreach (var item in dbItems)
                {
                    model.Add(new UserListViewModel()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        UserName = item.UserName,
                        LastName = item.LastName,
                        UserTypeID = item.UserTypeID,
                        LastUserVisit = item.LastUserVisit,
                        LocationID = item.LocationID,
                        UserWebsiteURL = item.UserWebsiteURL,
                        RegistrationDate = item.RegistrationDate,
                        ReputationScore = item.ReputationScore,
                        About = item.About,
                        Avatar = item.Avatar,
                        CookingLevelID = item.CookingLevelID
                    });
                }

            return model;
        }

        public override UsersViewModel ProjectToViewModel(User dbItem)
        {

            UsersViewModel model = new UsersViewModel();
            model.Id = dbItem.Id;
            model.Name = dbItem.Name;
            model.UserName = dbItem.UserName;
            model.LastName = dbItem.LastName;
            model.UserTypeID = dbItem.UserTypeID;
            model.LastUserVisit = dbItem.LastUserVisit;
            model.LocationID = dbItem.LocationID;
            model.UserWebsiteURL = dbItem.UserWebsiteURL;
            model.RegistrationDate = dbItem.RegistrationDate;
            model.ReputationScore = dbItem.ReputationScore;
            model.About = dbItem.About;
            model.Avatar = dbItem.Avatar;
            model.CookingLevelID = dbItem.CookingLevelID;
            return model;
        }

        public override long ProjectUpdateToEntity(User dbItem, UsersViewModel model)
        {
            dbItem.Id = model.Id;
            dbItem.Name = model.Name;
            dbItem.UserName = model.UserName;
            dbItem.LastName = model.LastName;
            dbItem.UserTypeID = model.UserTypeID;
            dbItem.LastUserVisit = model.LastUserVisit;
            dbItem.LocationID = model.LocationID;
            dbItem.UserWebsiteURL = model.UserWebsiteURL;
            dbItem.RegistrationDate = model.RegistrationDate;
            dbItem.ReputationScore = model.ReputationScore;
            dbItem.About = model.About;
            dbItem.Avatar = model.Avatar;
            dbItem.CookingLevelID = model.CookingLevelID;
            return Current.DbInit.User.Update(dbItem.Id, dbItem);
        }
    }
}
