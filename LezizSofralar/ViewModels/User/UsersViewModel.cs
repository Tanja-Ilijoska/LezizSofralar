using LezizSofralar.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LezizSofralar.ViewModels
{
    public class UsersViewModel : BaseViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = nameof(UserResources.FieldName_UserName), ResourceType = typeof(UserResources))]
        public string UserName { get; set; }

        [Display(Name = nameof(UserResources.FieldName_Name), ResourceType = typeof(UserResources))]
        public string Name { get; set; }

        [Display(Name = nameof(UserResources.FieldName_LastName), ResourceType = typeof(UserResources))]
        public string LastName { get; set; }

        [Display(Name = nameof(UserResources.FieldName_UserTypeID), ResourceType = typeof(UserResources))]
        public Nullable<int> UserTypeID { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = nameof(UserResources.FieldName_LastUserVisit), ResourceType = typeof(UserResources))]
        public Nullable<System.DateTime> LastUserVisit { get; set; }

        [Display(Name = nameof(UserResources.FieldName_LocationID), ResourceType = typeof(UserResources))]
        public Nullable<int> LocationID { get; set; }

        [Display(Name = nameof(UserResources.FieldName_UserWebsiteURL), ResourceType = typeof(UserResources))]
        public string UserWebsiteURL { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = nameof(UserResources.FieldName_RegistrationDate), ResourceType = typeof(UserResources))]
        public Nullable<System.DateTime> RegistrationDate { get; set; }

        [Display(Name = nameof(UserResources.FieldName_ReputationScore), ResourceType = typeof(UserResources))]
        public Nullable<decimal> ReputationScore { get; set; }

        [Display(Name = nameof(UserResources.FieldName_About), ResourceType = typeof(UserResources))]
        public string About { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = nameof(UserResources.FieldName_Avatar), ResourceType = typeof(UserResources))]
        public string Avatar { get; set; }

        [Display(Name = nameof(UserResources.FieldName_CookingLevelID), ResourceType = typeof(UserResources))]
        public Nullable<int> CookingLevelID { get; set; }

        //izvedeni
        public int NumberProfileViews { get; set; }
    }
}