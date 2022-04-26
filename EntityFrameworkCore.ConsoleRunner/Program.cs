using EntityFrameworkCore.Samples.DataContext;
using System.Linq;

namespace EntityFrameworkCore.ConsoleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
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
