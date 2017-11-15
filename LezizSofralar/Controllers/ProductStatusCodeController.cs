using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LezizSofralar.Controllers
{
    public class ProductStatusCodeController : Controller
    {
        // GET: ProductStatusCode
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductStatusCode/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductStatusCode/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductStatusCode/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductStatusCode/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductStatusCode/Edit/5
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

        // GET: ProductStatusCode/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductStatusCode/Delete/5
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
