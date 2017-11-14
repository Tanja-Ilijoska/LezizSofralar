using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.ViewModels
{
    public class BaseViewModel
    {
        public int CreatedByUserID { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int UpdatedByUserID { get; set; }

        public System.DateTime DateUpdated { get; set; }

        public bool IsActive { get; set; }
    }
}