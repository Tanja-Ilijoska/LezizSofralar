using LezizSofralar.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LezizSofralar.ViewModels
{
    public class AttributesListViewModel : ListViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = nameof(AttributeResources.FieldName_Name), ResourceType = typeof(AttributeResources))]
        public string Name { get; set; }
    }
}