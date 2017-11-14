using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LezizSofralar.ViewModels.Users
{
    public class UsersListViewModel : ListViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }
    }
}