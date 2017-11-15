using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.Models
{
    public class UserFavouriteAuthor
    {
        public int Id { get; set; }

        public int UserID { get; set; }

        public int AuthorID { get; set; }
    }
}