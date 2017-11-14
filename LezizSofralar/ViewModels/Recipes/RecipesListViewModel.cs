using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.ViewModels
{
    public class RecipesListViewModel : ListViewModel
    {
        public int ID { get; set; }

        public string DescriptionName { get; set; }

        public string Instructions { get; set; }
    }
}