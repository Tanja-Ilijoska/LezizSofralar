using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.Models
{
    public class UserSocialProfile
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int UserID { get; set; }

        public string SocialURL { get; set; }

        public int CreateUserID { get; set; }

        public System.DateTime CreateTime { get; set; }

        public System.DateTime UpdateTime { get; set; }

        public int UpdateUserID { get; set; }

        public bool IsActive { get; set; }

    }
}