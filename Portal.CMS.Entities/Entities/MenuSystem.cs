using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Farz.CMS.Entities.Entities
{
    public class MenuSystem
    {
        [Key]
        public int MenuId { get; set; }

        [Required]
        public string MenuName { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}