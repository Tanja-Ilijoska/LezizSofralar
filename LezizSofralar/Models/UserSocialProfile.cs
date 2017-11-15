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

    }
}