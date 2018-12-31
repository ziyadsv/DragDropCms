using Farz.CMS.Services.Themes;
using Farz.CMS.Web.Architecture.Helpers;
using Farz.CMS.Web.Areas.PageBuilder.ViewModels.Theme;
using System.Web.Mvc;
using System.Web.SessionState;

namespace Farz.CMS.Web.Areas.PageBuilder.Controllers
{
    [SessionState(SessionStateBehavior.ReadOnly)]
    public class ThemeController : Controller
    {
        readonly IThemeService _themeService;

        public ThemeController(IThemeService themeService)
        {
            _themeService = themeService;
        }

        public ActionResult Render()
        {
            var model = new ThemeViewModel
            {
                Theme = AsyncHelpers.RunSync(() => _themeService.GetDefaultAsync())
            };

            return View(model);
        }
    }
}