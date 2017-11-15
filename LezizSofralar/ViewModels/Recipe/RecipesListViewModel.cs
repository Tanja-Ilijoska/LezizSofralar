using LezizSofralar.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LezizSofralar.ViewModels
{
    public class RecipesListViewModel : ListViewModel
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [Display(Name = nameof(RecipeResources.FieldName_DisplayName), ResourceType = typeof(RecipeResources))]
        public string DisplayName { get; set; }

        [Display(Name = nameof(RecipeResources.FieldName_Description), ResourceType = typeof(RecipeResources))]
        public string Description { get; set; }
    }
}