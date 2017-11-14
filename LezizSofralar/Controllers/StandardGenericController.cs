using LezizSofralar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LezizSofralar.Controllers
{
    public class StandardGenericController<TListViewModel , TViewModel, TEntity> : Controller
    {
        // GET: StandardGeneric
        public ActionResult Index()
        {
            //IEnumerable<TEntity> dbAttributes = Current.DbInit.TEntity.All();

            ////filtering

            ////authorisation

            ////slapper mapping
            //List<TListViewModel> model = new List<TListViewModel>();
            //if (dbAttributes != null && dbAttributes.Count() > 0)
            //    foreach (var item in dbAttributes)
            //    {
            //        model.Add(new TListViewModel()
            //        {
            //            Id = item.Id,
            //            Name = item.Name
            //        });
            //    }

            return View();
        }

        public ActionResult Read(int PageSize, int PageNumber)
        {
            return View();
        }
    }
}