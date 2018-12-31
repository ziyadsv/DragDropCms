namespace Farz.CMS.Entities.Migrations
{
    using Seed;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Farz.CMS.Entities.PortalEntityModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Farz.CMS.Entities.PortalEntityModel context)
        {
            ThemeSeed.Seed(context);
            RoleSeed.Seed(context);
            SettingSeed.Seed(context);
            PostCategorySeed.Seed(context);
            PageSectionTypeSeed.Seed(context);
            PageComponentTypeSeed.Seed(context);
            MediaSeed.Seed(context);
            CopySeed.Seed(context);
            context.SaveChanges();

            MenuSeed.Seed(context);
            PageSeed.Seed(context);
            PostSeed.Seed(context);
        }
    }
}