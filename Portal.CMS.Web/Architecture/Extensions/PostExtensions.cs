using Farz.CMS.Entities.Entities;
using Farz.CMS.Entities.Enumerators;
using Farz.CMS.Web.Architecture.Helpers;
using System.Linq;

namespace Farz.CMS.Web.Architecture.Extensions
{
    public static class PostExtensions
    {
        public const string DEFAULT_IMAGE_PATH = "/Areas/PageBuilder/Content/Images/Sample/Sample-1.jpg";

        public static string BannerImageUrl(this Post post)
        {
            if (post.PostImages.Any(x => x.PostImageType == PostImageType.Banner))
            {
                var cdnAddress = SettingHelper.Get("CDN Address");

                var imagePath = post.PostImages.First(x => x.PostImageType == PostImageType.Banner).Image.ImagePath;

                if (string.IsNullOrWhiteSpace(cdnAddress))
                {
                    return imagePath;
                }

                return $"{cdnAddress}{imagePath}";
            }

            return DEFAULT_IMAGE_PATH;
        }
    }
}