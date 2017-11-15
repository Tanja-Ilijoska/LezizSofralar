using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.Models
{
    public class RecipeAttribute
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int AttributeId { get; set; }
    }
}