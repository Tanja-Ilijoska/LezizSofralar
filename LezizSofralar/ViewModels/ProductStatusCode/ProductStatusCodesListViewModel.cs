using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.ViewModels.ProductStatusCodes
{
    public class ProductStatusCodesListViewModel : ListViewModel
    {
        public int Id { get; set; }

        public string Status { get; set; }
    }
}