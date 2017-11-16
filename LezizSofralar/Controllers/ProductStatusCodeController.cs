using LezizSofralar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LezizSofralar.Models;

namespace LezizSofralar.Controllers
{
    public class ProductStatusCodeController : StandardGenericController<ProductStatusCodesListViewModel, ProductStatusCodesViewModel, Models.ProductStatusCode>
    {
        public override IEnumerable<Models.ProductStatusCode> GetDataset()
        {
            IEnumerable<Models.ProductStatusCode> dbItems = Current.DbInit.ProductStatusCode.All();
            return dbItems;
        }

        public override Models.ProductStatusCode GetItem(int id)
        {
            return Current.DbInit.ProductStatusCode.Get(id);
        }

        public override bool ProjectDeleteToEntity(int ID)
        {
            return Current.DbInit.ProductStatusCode.Delete(new { Id = ID });
        }

        public override List<ProductStatusCodesListViewModel> ProjectToListViewModel(IEnumerable<Models.ProductStatusCode> dbItems)
        {
            List<ProductStatusCodesListViewModel> model = new List<ProductStatusCodesListViewModel>();
            if (dbItems != null && dbItems.Count() > 0)
                foreach (var item in dbItems)
                {
                    model.Add(new ProductStatusCodesListViewModel()
                    {
                        ID = item.Id,
                        Status = item.Status
                    });
                }

            return model;
        }

        public override ProductStatusCodesViewModel ProjectToViewModel(Models.ProductStatusCode dbItem)
        {
            ProductStatusCodesViewModel model = new ProductStatusCodesViewModel();
            model.ID = dbItem.Id;
            model.Status = dbItem.Status;
            return model;
        }

        public override long ProjectInsertToEntity(ProductStatusCodesViewModel model)
        {
            return
                  Current.DbInit.ProductStatusCode.Insert(
                  new
                  {
                      Status = model.Status
                  });
        }

        public override long ProjectUpdateToEntity(Models.ProductStatusCode dbItem, ProductStatusCodesViewModel model)
        {
            dbItem.Id = model.ID;
            dbItem.Status = model.Status;
            return Current.DbInit.ProductStatusCode.Update(dbItem.Id, dbItem);

        }
    }
}
