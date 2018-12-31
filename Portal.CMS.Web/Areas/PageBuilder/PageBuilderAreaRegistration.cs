using System.Web.Mvc;

namespace Farz.CMS.Web.Areas.PageBuilder
{
    public class PageBuilderAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "PageBuilder";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "PageBuilder_default",
                "PageBuilder/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}