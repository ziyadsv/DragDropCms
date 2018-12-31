using Farz.CMS.Entities.Entities;
using System.Collections.Generic;

namespace Farz.CMS.Web.Areas.Admin.ViewModels.ThemeManager
{
    public class AppDrawerViewModel
    {
        public IEnumerable<CustomTheme> Themes { get; set; }

        public List<Font> Fonts { get; set; }
    }
}