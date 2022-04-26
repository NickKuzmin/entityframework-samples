using EntityFrameworkCore.Samples.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Samples.DataContext
{
    public class ArticleContext : DbContext
    {
        public virtual DbSet<ArticleCommonTable> ArticleCommonTables { get; set; }

        public virtual DbSet<ArticleFirstTypeTable> ArticleFirstTypes { get; set; }

        public virtual DbSet<ArticleSecondTypeTable> ArticleSecondTypes { get; set; }
    }
}