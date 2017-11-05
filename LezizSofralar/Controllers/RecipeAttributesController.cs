using LezizSofralar.Models;
using LezizSofralar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LezizSofralar.Controllers
{
    public class RecipeAttributesController : Controller
    {
        // GET: RecipeAttributes
        public ActionResult Index()
        {
            IEnumerable<RecipeAttributes> dbRecipeAttributes = Current.DbInit.RecipeAttributes.All();

            //filtering

            //authorisation

            //slapper mapping
            List<RecipeAttributesViewModel> model = new List<RecipeAttributesViewModel>();
            if (dbRecipeAttributes != null && dbRecipeAttributes.Count() > 0)
                foreach (var item in dbRecipeAttributes)
                {
                    model.Add(new RecipeAttributesViewModel()
                    {
                        Id = item.Id,
                        Name = item.Name
                    });
                }

            return View(model);
        }

        // GET: RecipeAttributes/Details/5
        public ActionResult Details(int id)
        {
            RecipeAttributesViewModel model = new RecipeAttributesViewModel();
            var dbRecipeAttributes = Current.DbInit.RecipeAttributes.Get(id);
            if (dbRecipeAttributes != null)
            {
                model.Id = dbRecipeAttributes.Id;
                model.Name = dbRecipeAttributes.Name;
            }
            return View(model);
        }

        // GET: RecipeAttributes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecipeAttributes/Create
        [HttpPost]
        public ActionResult Create(RecipeAttributesViewModel collection)
        {
            try
            {
                long uid = Current.DbInit.RecipeAttributes.Insert(
                  new
                  {
                      Name = collection.Name
                  });

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: RecipeAttributes/Edit/5
        public ActionResult Edit(int id)
        {
            RecipeAttributesViewModel model = new RecipeAttributesViewModel();
            var dbRecipeAttributes = Current.DbInit.RecipeAttributes.Get(id);
            if (dbRecipeAttributes != null)
            {
                model.Id = dbRecipeAttributes.Id;
                model.Name = dbRecipeAttributes.Name;
            }
            return View(model);
        }

        // POST: RecipeAttributes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, RecipeAttributesViewModel model)
        {
            try
            {
                var dbRecipeAttributes = Current.DbInit.RecipeAttributes.Get(id);
                dbRecipeAttributes.Id = model.Id;
                dbRecipeAttributes.Name = model.Name;
                int uid = Current.DbInit.RecipeAttributes.Update(id, dbRecipeAttributes);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RecipeAttributes/Delete/5
        public ActionResult Delete(int id)
        {
            RecipeAttributesViewModel model = new RecipeAttributesViewModel();
            var dbRecipeAttributes = Current.DbInit.RecipeAttributes.Get(id);
            if (dbRecipeAttributes != null)
            {
                model.Id = dbRecipeAttributes.Id;
                model.Name = dbRecipeAttributes.Name;
            }
            return View(model);
        }

        // POST: RecipeAttributes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                bool isAnotherTrue = Current.DbInit.RecipeAttributes.Delete(new { Id = id });
                if (isAnotherTrue)
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
