using LezizSofralar.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LezizSofralar.ViewModels.Location
{
    public class LocationViewModel : BaseViewModel
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_DisplayName), ResourceType = typeof(LocationResources))]
        public string DisplayName { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_Code), ResourceType = typeof(LocationResources))]
        public string Code { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_ParentLocationID), ResourceType = typeof(LocationResources))]
        public int ParentLocationID { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_ShortName), ResourceType = typeof(LocationResources))]
        public string ShortName { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_Description), ResourceType = typeof(LocationResources))]
        public string Description { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_MetaKeywords), ResourceType = typeof(LocationResources))]
        public string MetaKeywords { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_MetaDescription), ResourceType = typeof(LocationResources))]
        public string MetaDescription { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_FriendlyURI), ResourceType = typeof(LocationResources))]
        public string FriendlyURI { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_IsVisible), ResourceType = typeof(LocationResources))]
        public bool IsVisible { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_VisibilityStartDate), ResourceType = typeof(LocationResources))]
        public System.DateTime VisibilityStartDate { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_VisibilityEndDate), ResourceType = typeof(LocationResources))]
        public System.DateTime VisibilityEndDate { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_ShowOnTopMenu), ResourceType = typeof(LocationResources))]
        public bool ShowOnTopMenu { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_ShowFilters), ResourceType = typeof(LocationResources))]
        public bool ShowFilters { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_DisplayOrder), ResourceType = typeof(LocationResources))]
        public int DisplayOrder { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_DefaultSort), ResourceType = typeof(LocationResources))]
        public string DefaultSort { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_DefaultSortArgumentCode), ResourceType = typeof(LocationResources))]
        public string DefaultSortArgumentCode { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_ShowProducts), ResourceType = typeof(LocationResources))]
        public bool ShowProducts { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_ShowSubCategoryProducts), ResourceType = typeof(LocationResources))]
        public bool ShowSubCategoryProducts { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_ProductListingPageSize), ResourceType = typeof(LocationResources))]
        public int ProductListingPageSize { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_IsOpenNewPage), ResourceType = typeof(LocationResources))]
        public bool IsOpenNewPage { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_IsVisibleOnMobile), ResourceType = typeof(LocationResources))]
        public bool IsVisibleOnMobile { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_ShowSubCategoryOnTopView), ResourceType = typeof(LocationResources))]
        public bool ShowSubCategoryOnTopView { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_ShowOnProductFeed), ResourceType = typeof(LocationResources))]
        public bool ShowOnProductFeed { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_Latitude), ResourceType = typeof(LocationResources))]
        public string Latitude { get; set; }

        [Display(Name = nameof(LocationResources.FieldName_Longitude), ResourceType = typeof(LocationResources))]
        public string Longitude { get; set; }
    }
}