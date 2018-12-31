﻿using Farz.CMS.Entities.Enumerators;
using System.ComponentModel;

namespace Farz.CMS.Web.Areas.PageBuilder.ViewModels.Component
{
    public class ContainerViewModel
    {
        public int SectionId { get; set; }

        public string ElementId { get; set; }

        [DisplayName("Animation")]
        public Animation Animation { get; set; }
    }
}