using Farz.CMS.Web.ViewModels.Shared;

namespace Farz.CMS.Web.Areas.PageBuilder.ViewModels.Section
{
    public class EditBackgroundImageViewModel
    {
        public int PageAssociationId { get; set; }

        public int SectionId { get; set; }

        public int BackgroundImageId { get; set; }

        public PaginationViewModel MediaLibrary { get; set; }
    }
}