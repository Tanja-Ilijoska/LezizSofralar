using LezizSofralar.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LezizSofralar.ViewModels.ProductStatusCodes
{
    public class ProductStatusCodesViewModel : BaseViewModel
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [Display(Name = nameof(ProductStatusCodeResources.FieldName_Status), ResourceType = typeof(ProductStatusCodeResources))]
        public string Status { get; set; }
    }
}