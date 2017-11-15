using LezizSofralar.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LezizSofralar.ViewModels
{
    public class RecipesViewModel : BaseViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = nameof(RecipeResources.FieldName_DisplayName), ResourceType = typeof(RecipeResources))]
        public string DisplayName { get; set; }

        [Display(Name = nameof(RecipeResources.FieldName_Description), ResourceType = typeof(RecipeResources))]
        public string Description { get; set; }

        [Display(Name = nameof(RecipeResources.FieldName_DisplayOrder), ResourceType = typeof(RecipeResources))]
        public int DisplayOrder { get; set; }

        [Display(Name = nameof(RecipeResources.FieldName_FeaturedImage), ResourceType = typeof(RecipeResources))]
        public string FeaturedImage { get; set; }

        [Display(Name = nameof(RecipeResources.FieldName_FriendlyURI), ResourceType = typeof(RecipeResources))]
        public string FriendlyURI { get; set; }

        [Display(Name = nameof(RecipeResources.FieldName_MetaKeywords), ResourceType = typeof(RecipeResources))]
        public string MetaKeywords { get; set; }

        [Display(Name = nameof(RecipeResources.FieldName_MetaDescription), ResourceType = typeof(RecipeResources))]
        public string MetaDescription { get; set; }

        [Display(Name = nameof(RecipeResources.FieldName_ProductStatusCodeID), ResourceType = typeof(RecipeResources))]
        public int ProductStatusCodeID { get; set; } //TO DO implement relation
      
    }
}