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
                    ArticleTitle = "Article title for First type",
                    Type = "FirstType",
                    ArticleFirstTypeProperty = "Additional Property for First type"
                };

                var articleSecondTypeTable = new ArticleSecondTypeTable
                {
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

            using (var context = new ArticleContext())
            {
                var groupingQuery = from article in context.ArticleCommonTables
                    group article by article.Type
                    into g
                    select new
                    {
                        Key = g.Key,
                        Array = g.Select(x => x),
                        Grouping = g
                    };

                var grouping = groupingQuery.ToArray();
            }
        }
    }
}
