﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.Models
{
    public class UserType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool ManageCategories { get; set; }

        public bool ManageLocations { get; set; }

        public bool ManageFilters { get; set; }
       
        public bool ManageUsers { get; set; }

        public bool ManageRecipes { get; set; }

        public bool ManageOwnRecipes { get; set; }

        public int CreateUserID { get; set; }

        public System.DateTime CreateTime { get; set; }

        public System.DateTime UpdateTime { get; set; }

        public int UpdateUserID { get; set; }

        public bool IsActive { get; set; }
    }
}