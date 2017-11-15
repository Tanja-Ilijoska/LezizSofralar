using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.Models
{
    public class UserReputation
    {
        public int ID { get; set; }

        public int UserID { get; set; }
        public int ReviewerID { get; set; }

        public decimal ReputationNumber { get; set; }
    }
}