using LezizSofralar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LezizSofralar.Models;

namespace LezizSofralar.Controllers
{
    public class CookingLevelController : StandardGenericController<CookingLevelsListViewModel, CookingLevelsViewModel, Models.CookingLevel>
    {
        public override IEnumerable<CookingLevel> GetDataset()
        {
            IEnumerable<Models.CookingLevel> dbItems = Current.DbInit.CookingLevel.All();
            return dbItems;
        }

        public override CookingLevel GetItem(int id)
        {
            return Current.DbInit.CookingLevel.Get(id);
        }

        public override bool ProjectDeleteToEntity(int ID)
        {
            return Current.DbInit.CookingLevel.Delete(new { Id = ID });
        }

        public override long ProjectInsertToEntity(CookingLevelsViewModel model)
        {
            return
               Current.DbInit.Attribute.Insert(
               new
               {
                   Name = model.Name,
                   Description = model.Description,
                   Level = model.Level
               });
        }

        public override List<CookingLevelsListViewModel> ProjectToListViewModel(IEnumerable<CookingLevel> dbItems)
        {
            List<CookingLevelsListViewModel> model = new List<CookingLevelsListViewModel>();
            if (dbItems != null && dbItems.Count() > 0)
                foreach (var item in dbItems)
                {
                    model.Add(new CookingLevelsListViewModel()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Description = item.Description,
                        Level = item.Level
                    });
                }

            return model;
        }

        public override CookingLevelsViewModel ProjectToViewModel(CookingLevel dbItem)
        {
            CookingLevelsViewModel model = new CookingLevelsViewModel();
            model.Id = dbItem.Id;
            model.Name = dbItem.Name;
            model.Description = dbItem.Description;
            model.Level = dbItem.Level;
            return model;
        }

        public override long ProjectUpdateToEntity(CookingLevel dbItem, CookingLevelsViewModel model)
        {
            dbItem.Id = model.Id;
            dbItem.Name = model.Name;
            dbItem.Description = model.Description;
            dbItem.Level = model.Level;
            return Current.DbInit.Attribute.Update(dbItem.Id, dbItem);
        }
    }
}
