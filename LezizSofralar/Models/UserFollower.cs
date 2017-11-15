using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.Models
{
    public class UserFollower
    {
        public int Id { get; set; }

        public int UserID { get; set; }

        public int FollowerID { get; set; }
    }
}