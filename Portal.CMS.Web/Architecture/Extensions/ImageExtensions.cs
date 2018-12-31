using Farz.CMS.Entities.Entities;
using Farz.CMS.Web.Architecture.Helpers;

namespace Farz.CMS.Web.Architecture.Extensions
{
    public static class ImageExtensions
    {
        public static string CDNImagePath(this Image image)
        {
            var cdnAddress = SettingHelper.Get("CDN Address");

            if (string.IsNullOrWhiteSpace(cdnAddress))
            {
                return image.ImagePath;
            }

            return $"{cdnAddress}{image.ImagePath}";
        }
    }
}