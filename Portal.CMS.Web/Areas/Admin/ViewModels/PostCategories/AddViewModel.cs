using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Farz.CMS.Web.Areas.Admin.ViewModels.PostCategories
{
    public class AddViewModel
    {
        [Required]
        [DisplayName("Name")]
        public string PostCategoryName { get; set; }
    }
}