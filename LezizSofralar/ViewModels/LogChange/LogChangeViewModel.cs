using LezizSofralar.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LezizSofralar.ViewModels.LogChange
{
    public class LogChangeViewModel : BaseViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = nameof(LogChangeResources.FieldName_UserID), ResourceType = typeof(LogChangeResources))]
        public int UserID { get; set; }

        [Display(Name = nameof(LogChangeResources.FieldName_Entity), ResourceType = typeof(LogChangeResources))]
        public string Entity { get; set; }

        [Display(Name = nameof(LogChangeResources.FieldName_Operation), ResourceType = typeof(LogChangeResources))]
        public string Operation { get; set; }

        [Display(Name = nameof(LogChangeResources.FieldName_EventDate), ResourceType = typeof(LogChangeResources))]
        public System.DateTime EventDate { get; set; }
    }
}