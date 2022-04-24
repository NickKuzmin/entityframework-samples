using System.Linq;
using EntityFramework.Samples.DataContext;
using EntityFramework.Samples.Entities;

namespace EntityFramework.Samples.ConsoleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ArticleContext())
            {
                var articleFirstTypeTable = new ArticleFirstTypeTable
                {
                    Id = 1,
                    ArticleTitle = "Article title for First type",
                    Type = "FirstType",
                    ArticleFirstTypeProperty = "Additional Property for First type"
                };

                var articleSecondTypeTable = new ArticleSecondTypeTable
                {
                    Id = 1,
                    ArticleTitle = "Article title for Second type",
                    Type = "SecondType",
                    ArticleSecondTypeProperty = "Additional Property for Second type"
                };

                context.ArticleFirstTypes.Add(articleFirstTypeTable);
                context.ArticleSecondTypes.Add(articleSecondTypeTable);
                context.SaveChanges();
            }

            using (var context = new ArticleContext())
            {
                var articleCommonTables = context.ArticleCommonTables.ToArray();
                var articleFirstTypes = context.ArticleFirstTypes.ToArray();
                var articleSecondTypes = context.ArticleSecondTypes.ToArray();
            }
        }
    }
}
