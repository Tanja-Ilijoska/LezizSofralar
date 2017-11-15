using LezizSofralar.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LezizSofralar.ViewModels.Users
{
    public class UsersListViewModel : ListViewModel
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
        public int UserTypeID { get; set; }

        [Display(Name = nameof(UserResources.FieldName_LastUserVisit), ResourceType = typeof(UserResources))]
        public System.DateTime LastUserVisit { get; set; }

        [Display(Name = nameof(UserResources.FieldName_LocationID), ResourceType = typeof(UserResources))]
        public int LocationID { get; set; }

        [Display(Name = nameof(UserResources.FieldName_UserWebsiteURL), ResourceType = typeof(UserResources))]
        public string UserWebsiteURL { get; set; }

        [Display(Name = nameof(UserResources.FieldName_RegistrationDate), ResourceType = typeof(UserResources))]
        public System.DateTime RegistrationDate { get; set; }

        [Display(Name = nameof(UserResources.FieldName_ReputationScore), ResourceType = typeof(UserResources))]
        public decimal ReputationScore { get; set; }

        [Display(Name = nameof(UserResources.FieldName_About), ResourceType = typeof(UserResources))]
        public string About { get; set; }

        [Display(Name = nameof(UserResources.FieldName_Avatar), ResourceType = typeof(UserResources))]
        public string Avatar { get; set; }

        [Display(Name = nameof(UserResources.FieldName_CookingLevelID), ResourceType = typeof(UserResources))]
        public int CookingLevelID { get; set; }
    }
}