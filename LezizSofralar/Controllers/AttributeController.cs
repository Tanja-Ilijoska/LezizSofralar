using LezizSofralar.Models;
using LezizSofralar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LezizSofralar.Controllers
{
    public class AttributeController : Controller //: StandardGenericController<AttributesListViewModel, AttributesViewModel, Models.Attribute>
    {
        // GET: Attributes
        public ActionResult Index()
        {
            IEnumerable<Models.Attribute> dbAttributes = Current.DbInit.Attribute.All();

            //filtering

            //authorisation

            //slapper mapping
            List<AttributesViewModel> model = new List<AttributesViewModel>();
            if (dbAttributes != null && dbAttributes.Count() > 0)
                foreach (var item in dbAttributes)
                {
                    model.Add(new AttributesViewModel()
                    {
                        Id = item.Id,
                        Name = item.Name
                    });
                }

            return View(model);
        }

        // GET: Attributes/Details/5
        public ActionResult Details(int id)
        {
            AttributesViewModel model = new AttributesViewModel();
            var dbAttributes = Current.DbInit.Attribute.Get(id);
            if (dbAttributes != null)
            {
                model.Id = dbAttributes.Id;
                model.Name = dbAttributes.Name;
            }
            return View(model);
        }

        // GET: Attributes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Attributes/Create
        [HttpPost]
        public ActionResult Create(AttributesViewModel collection)
        {
            try
            {
                long uid = Current.DbInit.Attribute.Insert(
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

        // GET: Attributes/Edit/5
        public ActionResult Edit(int id)
        {
            AttributesViewModel model = new AttributesViewModel();
            var dbAttributes = Current.DbInit.Attribute.Get(id);
            if (dbAttributes != null)
            {
                model.Id = dbAttributes.Id;
                model.Name = dbAttributes.Name;
            }
            return View(model);
        }

        // POST: Attributes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, AttributesViewModel model)
        {
            try
            {
                var dbAttributes = Current.DbInit.Attribute.Get(id);
                dbAttributes.Id = model.Id;
                dbAttributes.Name = model.Name;
                int uid = Current.DbInit.Attribute.Update(id, dbAttributes);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Attributes/Delete/5
        public ActionResult Delete(int id)
        {
            AttributesViewModel model = new AttributesViewModel();
            var dbAttributes = Current.DbInit.Attribute.Get(id);
            if (dbAttributes != null)
            {
                model.Id = dbAttributes.Id;
                model.Name = dbAttributes.Name;
            }
            return View(model);
        }

        // POST: Attributes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                bool isTrue = Current.DbInit.Attribute.Delete(new { Id = id });
                if (isTrue)
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
