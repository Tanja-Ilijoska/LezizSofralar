using LezizSofralar.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LezizSofralar.ViewModels
{
    public class CookingLevelsListViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = nameof(CookingLevelResources.FieldName_Name), ResourceType = typeof(CookingLevelResources))]
        public string Name { get; set; }

        [Display(Name = nameof(CookingLevelResources.FieldName_Description), ResourceType = typeof(CookingLevelResources))]
        public string Description { get; set; }

        [Display(Name = nameof(CookingLevelResources.FieldName_Level), ResourceType = typeof(CookingLevelResources))]
        public int Level { get; set; }
    }
}