using LezizSofralar.Models;
using LezizSofralar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LezizSofralar.Controllers
{
    public class UserTypesController : Controller
    {
        // GET: UserTypes
        public ActionResult Index()
        {
            IEnumerable<UserType> dbUserTypes = Current.DbInit.UserType.All();

            //filtering

            //authorisation

            //slapper mapping
            List<UserTypesViewModel> model = new List<UserTypesViewModel>();
            if (dbUserTypes != null && dbUserTypes.Count() > 0)
                foreach (var item in dbUserTypes)
                {
                    model.Add(new UserTypesViewModel()
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

            return View(model);
        }

        // GET: UserTypes/Details/5
        public ActionResult Details(int id)
        {
            UserTypesViewModel model = new UserTypesViewModel();
            var dbUserTypes = Current.DbInit.UserType.Get(id);
            if (dbUserTypes != null)
            {
                model.Id = dbUserTypes.Id;
                model.Name = dbUserTypes.Name;
                model.ManageCategories = dbUserTypes.ManageCategories;
                model.ManageFilters = dbUserTypes.ManageFilters;
                model.ManageLocations = dbUserTypes.ManageLocations;
                model.ManageOwnRecipes = model.ManageOwnRecipes;
                model.ManageRecipes = model.ManageRecipes;
                model.ManageUsers = dbUserTypes.ManageUsers;
            }
            return View(model);
        }

        // GET: UserTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserTypes/Create
        [HttpPost]
        public ActionResult Create(UserTypesViewModel collection)
        {
            try
            {
                long uid = Current.DbInit.UserType.Insert(
                  new
                  {
                      Name = collection.Name,
                      ManageCategories = collection.ManageCategories,
                      ManageLocations = collection.ManageLocations,
                      ManageFilters = collection.ManageFilters,
                      ManageUsers = collection.ManageUsers,
                      ManageRecipes = collection.ManageRecipes,
                      ManageOwnRecipes = collection.ManageOwnRecipes
                  });

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: UserTypes/Edit/5
        public ActionResult Edit(int id)
        {
            UserTypesViewModel model = new UserTypesViewModel();
            var dbUserTypes = Current.DbInit.UserType.Get(id);
            if (dbUserTypes != null)
            {
                model.Id = dbUserTypes.Id;
                model.Name = dbUserTypes.Name;
                model.ManageCategories = dbUserTypes.ManageCategories;
                model.ManageFilters = dbUserTypes.ManageFilters;
                model.ManageLocations = dbUserTypes.ManageLocations;
                model.ManageOwnRecipes = dbUserTypes.ManageOwnRecipes;
                model.ManageRecipes = dbUserTypes.ManageRecipes;
                model.ManageUsers = dbUserTypes.ManageUsers;
            }
            return View(model);
        }

        // POST: UserTypes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, UserTypesViewModel model)
        {
            try
            {
                var dbUserTypes = Current.DbInit.UserType.Get(id);
                dbUserTypes.Id = model.Id;
                dbUserTypes.Name =  model.Name;
                dbUserTypes.ManageCategories= model.ManageCategories;
                dbUserTypes.ManageFilters  =  model.ManageFilters;
                dbUserTypes.ManageLocations = model.ManageLocations ;
                dbUserTypes.ManageOwnRecipes = model.ManageOwnRecipes ;
                dbUserTypes.ManageRecipes   =  model.ManageRecipes ;
                dbUserTypes.ManageUsers =  model.ManageUsers;
                int uid = Current.DbInit.UserType.Update(id, dbUserTypes);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserTypes/Delete/5
        public ActionResult Delete(int id)
        {
            UserTypesViewModel model = new UserTypesViewModel();
            var dbUserTypes = Current.DbInit.UserType.Get(id);
            if (dbUserTypes != null)
            {
                model.Id = dbUserTypes.Id;
                model.Name = dbUserTypes.Name;
                model.ManageCategories = dbUserTypes.ManageCategories;
                model.ManageFilters = dbUserTypes.ManageFilters;
                model.ManageLocations = dbUserTypes.ManageLocations;
                model.ManageOwnRecipes = model.ManageOwnRecipes;
                model.ManageRecipes = model.ManageRecipes;
                model.ManageUsers = dbUserTypes.ManageUsers;
            }
            return View(model);
        }

        // POST: UserTypes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                bool isAnotherTrue = Current.DbInit.UserType.Delete(new { Id = id });
                if(isAnotherTrue)
                    return RedirectToAction("Index");
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
