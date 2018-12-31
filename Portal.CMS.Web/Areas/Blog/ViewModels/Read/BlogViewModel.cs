using Farz.CMS.Entities.Entities;
using System.Collections.Generic;

namespace Farz.CMS.Web.Areas.BlogManager.ViewModels.Read
{
    public class BlogViewModel
    {
        public Post CurrentPost { get; set; }

        public List<Post> RecentPosts { get; set; }

        public List<Post> SimiliarPosts { get; set; }

        public User Author { get; set; }
    }
}