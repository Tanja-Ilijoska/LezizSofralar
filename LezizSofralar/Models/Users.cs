using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.Models
{
    public class Users
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string UserTypeID { get; set; }

        public virtual IEnumerable<UserTypes> UserTypes { get; set; }
    }
}