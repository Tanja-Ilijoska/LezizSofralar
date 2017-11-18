using LezizSofralar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LezizSofralar.Models;

namespace LezizSofralar.Controllers
{
    public class LogChangeController : StandardGenericController<LogChangeListViewModel, LogChangeViewModel, Models.LogChange>
    {
        public override string EntityName()
        {
            return "LogChange";
        }

        public override IEnumerable<Models.LogChange> GetDataset()
        {
            IEnumerable<Models.LogChange> dbItems = Current.DbInit.LogChange.All();
            return dbItems;
        }

        public override Models.LogChange GetItem(int id)
        {
            return Current.DbInit.LogChange.Get(id);
        }

        //noone can delete logs
        public override bool ProjectDeleteToEntity(int ID)
        {
            throw new NotImplementedException();
        }

        //noone can insert logs
        public override long ProjectInsertToEntity(LogChangeViewModel model)
        {
            throw new NotImplementedException();
        }

        public override List<LogChangeListViewModel> ProjectToListViewModel(IEnumerable<Models.LogChange> dbItems)
        {
            List<LogChangeListViewModel> model = new List<LogChangeListViewModel>();
            if (dbItems != null && dbItems.Count() > 0)
                foreach (var item in dbItems)
                {
                    model.Add(new LogChangeListViewModel()
                    {
                        Id = item.Id,
                        UserID = item.UserID,
                        Entity = item.Entity,
                        Operation = item.Operation,
                        EventDate = item.EventDate
                    });
                }

            return model;
        }


        public override LogChangeViewModel ProjectToViewModel(Models.LogChange dbItem)
        {
            throw new NotImplementedException();
        }

        //noone can update logs
        public override long ProjectUpdateToEntity(Models.LogChange dbItem, LogChangeViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}