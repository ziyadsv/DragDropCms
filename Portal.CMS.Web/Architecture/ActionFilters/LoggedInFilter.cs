using Farz.CMS.Web.Architecture.Helpers;
using System.Web.Mvc;
using System.Web.Routing;

namespace Farz.CMS.Web.Architecture.ActionFilters
{
    public sealed class LoggedInFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!UserHelper.IsLoggedIn)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "action", "Index" }, { "controller", "Home" }, { "area", "" } });
            }
        }
    }
}