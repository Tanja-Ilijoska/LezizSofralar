using LezizSofralar.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LezizSofralar.ViewModels
{
    public class CategoryListViewModel : ListViewModel
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_DisplayName), ResourceType = typeof(CategoryResources))]
        public string DisplayName { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_Code), ResourceType = typeof(CategoryResources))]
        public string Code { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_ParentCategoryID), ResourceType = typeof(CategoryResources))]
        public int ParentLocationID { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_ShortName), ResourceType = typeof(CategoryResources))]
        public string ShortName { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_Description), ResourceType = typeof(CategoryResources))]
        public string Description { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_MetaKeywords), ResourceType = typeof(CategoryResources))]
        public string MetaKeywords { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_MetaDescription), ResourceType = typeof(CategoryResources))]
        public string MetaDescription { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_FriendlyURI), ResourceType = typeof(CategoryResources))]
        public string FriendlyURI { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_IsVisible), ResourceType = typeof(CategoryResources))]
        public bool IsVisible { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_VisibilityStartDate), ResourceType = typeof(CategoryResources))]
        public System.DateTime VisibilityStartDate { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_VisibilityEndDate), ResourceType = typeof(CategoryResources))]
        public System.DateTime VisibilityEndDate { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_ShowOnTopMenu), ResourceType = typeof(CategoryResources))]
        public bool ShowOnTopMenu { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_ShowFilters), ResourceType = typeof(CategoryResources))]
        public bool ShowFilters { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_DisplayOrder), ResourceType = typeof(CategoryResources))]
        public int DisplayOrder { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_DefaultSort), ResourceType = typeof(CategoryResources))]
        public string DefaultSort { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_DefaultSortArgumentCode), ResourceType = typeof(CategoryResources))]
        public string DefaultSortArgumentCode { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_ShowProducts), ResourceType = typeof(CategoryResources))]
        public bool ShowProducts { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_ShowSubCategoryProducts), ResourceType = typeof(CategoryResources))]
        public bool ShowSubCategoryProducts { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_ProductListingPageSize), ResourceType = typeof(CategoryResources))]
        public int ProductListingPageSize { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_IsOpenNewPage), ResourceType = typeof(CategoryResources))]
        public bool IsOpenNewPage { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_IsVisibleOnMobile), ResourceType = typeof(CategoryResources))]
        public bool IsVisibleOnMobile { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_ShowSubCategoryOnTopView), ResourceType = typeof(CategoryResources))]
        public bool ShowSubCategoryOnTopView { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_ShowOnProductFeed), ResourceType = typeof(CategoryResources))]
        public bool ShowOnProductFeed { get; set; }

        [Display(Name = nameof(CategoryResources.FieldName_ImagePath), ResourceType = typeof(CategoryResources))]
        public string ImagePath { get; set; }
    }
}