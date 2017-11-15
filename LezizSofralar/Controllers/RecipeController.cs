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
        // GET: Recipes
        public ActionResult Index()
        {
            List<RecipesListViewModel> model = new List<RecipesListViewModel>();
            IEnumerable<Recipe> all = Current.DbInit.Recipe.All();
            Recipe u = Current.DbInit.Recipe.Get(1);

            all.Where(x => x.DisplayName != null);

            return View(all);
        }

        // GET: Recipes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Recipes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recipes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                long uid = Current.DbInit.Recipe.Insert(
                  new
                  {
                      Name = collection.GetValue("Name").ToString(),
                      Instructions = collection.GetValue("Instructions").ToString()
                  });

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Recipes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Recipes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Recipes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Recipes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
