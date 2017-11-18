using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public Nullable<int> UserTypeID { get; set; }
        
        public Nullable<System.DateTime> LastUserVisit { get; set; }

        public Nullable<int> LocationID { get; set; }
        
        public string UserWebsiteURL { get; set; }
        
        public Nullable<System.DateTime> RegistrationDate { get; set; }

        public Nullable<decimal> ReputationScore { get; set; }

        public string About { get; set; }
        
        public string Avatar { get; set; }

        public Nullable<int> CookingLevelID { get; set; }

        public Nullable<int> CreateUserID { get; set; }

        public System.DateTime CreateTime { get; set; }

        public System.DateTime UpdateTime { get; set; }

        public int UpdateUserID { get; set; }

        public bool IsActive { get; set; }
        public virtual IEnumerable<UserType> UserTypes { get; set; }
    }
}