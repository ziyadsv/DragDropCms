﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Farz.CMS.Web.Areas.Admin.ViewModels.RoleManager
{
    public class CreateViewModel
    {
        [Required]
        [DisplayName("Role Name")]
        public string RoleName { get; set; }
    }
}