using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.ViewModels
{
    public class UserTypesViewModel : BaseViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool ManageCategories { get; set; }

        public bool ManageLocations { get; set; }

        public bool ManageFilters { get; set; }

        public bool ManageUsers { get; set; }

        public bool ManageRecipes { get; set; }

        public bool ManageOwnRecipes { get; set; }
    }
}