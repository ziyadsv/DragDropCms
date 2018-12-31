using Farz.CMS.Entities.Entities;
using System.Collections.Generic;

namespace Farz.CMS.Web.Areas.Admin.ViewModels.UserManager
{
    public class UsersViewModel
    {
        public IEnumerable<User> Users { get; set; }
    }
}