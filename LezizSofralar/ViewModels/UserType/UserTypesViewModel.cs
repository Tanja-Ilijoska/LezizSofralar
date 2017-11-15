using LezizSofralar.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LezizSofralar.ViewModels
{
    public class UserTypesViewModel : BaseViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = nameof(UserTypeResources.FieldName_Name), ResourceType = typeof(UserTypeResources))]
        public string Name { get; set; }

        [Display(Name = nameof(UserTypeResources.FieldName_ManageCategories), ResourceType = typeof(UserTypeResources))]
        public bool ManageCategories { get; set; }

        [Display(Name = nameof(UserTypeResources.FieldName_ManageLocations), ResourceType = typeof(UserTypeResources))]
        public bool ManageLocations { get; set; }

        [Display(Name = nameof(UserTypeResources.FieldName_ManageFilters), ResourceType = typeof(UserTypeResources))]
        public bool ManageFilters { get; set; }

        [Display(Name = nameof(UserTypeResources.FieldName_ManageUsers), ResourceType = typeof(UserTypeResources))]
        public bool ManageUsers { get; set; }

        [Display(Name = nameof(UserTypeResources.FieldName_ManageRecipes), ResourceType = typeof(UserTypeResources))]
        public bool ManageRecipes { get; set; }

        [Display(Name = nameof(UserTypeResources.FieldName_ManageOwnRecipes), ResourceType = typeof(UserTypeResources))]
        public bool ManageOwnRecipes { get; set; }
    }
}