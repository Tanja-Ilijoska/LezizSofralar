using LezizSofralar.Models;
using LezizSofralar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LezizSofralar.Controllers
{
    public class AttributeController : StandardGenericController<AttributesListViewModel, AttributesViewModel, Models.Attribute>
    {
        public override string EntityName()
        {
            return "Attrbute";
        }

        public override IEnumerable<Models.Attribute> GetDataset()
        {
            IEnumerable<Models.Attribute> dbAttributes = Current.DbInit.Attribute.All();
            return dbAttributes;
        }

        public override Models.Attribute GetItem(int id)
        {
            return Current.DbInit.Attribute.Get(id);
        }

        public override bool ProjectDeleteToEntity(int ID)
        {
            return Current.DbInit.Attribute.Delete(new { Id = ID });
        }

        public override List<AttributesListViewModel> ProjectToListViewModel(IEnumerable<Models.Attribute> dbItems)
        {
            List<AttributesListViewModel> model = new List<AttributesListViewModel>();
            if (dbItems != null && dbItems.Count() > 0)
                foreach (var item in dbItems)
                {
                    model.Add(new AttributesListViewModel()
                    {
                        Id = item.Id,
                        Name = item.Name
                    });
                }

            return model;
        }

        public override AttributesViewModel ProjectToViewModel(Models.Attribute dbItem)
        {
            AttributesViewModel model = new AttributesViewModel();
            model.Id = dbItem.Id;
            model.Name = dbItem.Name;
            return model;
        }

        public override long ProjectInsertToEntity(AttributesViewModel model)
        {
           return
                Current.DbInit.Attribute.Insert(
                new
                {
                    Name = model.Name
                });
        }

        public override long ProjectUpdateToEntity(Models.Attribute dbAttributes, AttributesViewModel model)
        {
            dbAttributes.Id = model.Id;
            dbAttributes.Name = model.Name;
            //dbAttributes.CreatedByUserID = model.CreatedByUserID;
            //dbAttributes.DateCreated = model.DateCreated;
            //dbAttributes.IsActive = true;
            //dbAttributes.UpdatedByUserID = model.UpdatedByUserID;
            //dbAttributes.DateUpdated = model.DateUpdated;
            return Current.DbInit.Attribute.Update(dbAttributes.Id, dbAttributes);
        }
    }
}
