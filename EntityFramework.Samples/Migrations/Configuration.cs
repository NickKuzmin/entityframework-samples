using System.Data.Entity.Migrations;

namespace EntityFramework.Samples.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EntityFramework.Samples.DataContext.ArticleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityFramework.Samples.DataContext.ArticleContext context)
        {
        }
    }
}
