﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Farz.CMS.Web.Areas.Profile.ViewModels.Manage
{
    public class AvatarViewModel
    {
        [DisplayName("Avatar")]
        [Required]
        public HttpPostedFileBase AttachedImage { get; set; }
    }
}