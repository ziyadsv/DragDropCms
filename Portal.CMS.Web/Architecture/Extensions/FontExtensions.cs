using Farz.CMS.Entities.Entities;
using Farz.CMS.Web.Architecture.Helpers;

namespace Farz.CMS.Web.Architecture.Extensions
{
    public static class FontExtensions
    {
        public static string CDNFontPath(this Font font)
        {
            var cdnAddress = SettingHelper.Get("CDN Address");

            if (string.IsNullOrWhiteSpace(cdnAddress))
            {
                return font.FontPath;
            }

            return $"{cdnAddress}{font.FontPath}";
        }
    }
}