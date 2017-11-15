using LezizSofralar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LezizSofralar.Controllers
{
    public abstract class StandardGenericController<TListViewModel , TViewModel, TEntity> : Controller
    {
        // GET: StandardGeneric
        public ActionResult Index()
        {
            IEnumerable<TEntity> dbItems = GetDataset();

            //filtering

            //authorisation

            //slapper mapping
            List<TListViewModel> model = new List<TListViewModel>();
            if (dbItems != null && dbItems.Count() > 0)
                model = ProjectToListViewModel(dbItems);

            return View(model);
        }

        public abstract IEnumerable<TEntity> GetDataset();

        public abstract List<TListViewModel> ProjectToListViewModel(IEnumerable<TEntity> dbItems);

        public ActionResult Read(int PageSize, int PageNumber)
        {
            return View();
        }
    }
}