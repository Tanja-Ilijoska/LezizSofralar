using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.ViewModels.LogChange
{
    public class LogChangeViewModel : BaseViewModel
    {
        public int Id { get; set; }

        public int UserID { get; set; }

        public string Entity { get; set; }

        public string Operation { get; set; }

        public System.DateTime EventDate { get; set; }
    }
}