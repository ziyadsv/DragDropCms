﻿using Farz.CMS.Entities.Enumerators;
using System.ComponentModel.DataAnnotations;

namespace Farz.CMS.Entities.Entities
{
    public class PageSectionType
    {
        [Key]
        public int PageSectionTypeId { get; set; }

        [Required]
        public string PageSectionTypeName { get; set; }

        [Required]
        public string PageSectionTypeBody { get; set; }

        public PageSectionTypeCategory PageSectionTypeCategory { get; set; }

        public int PageSectionTypeOrder { get; set; }
    }
}