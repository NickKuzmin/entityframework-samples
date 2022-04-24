using System.Data.Entity;
using EntityFramework.Samples.Entities;

namespace EntityFramework.Samples.DataContext
{
    public class ArticleContext : DbContext
    {
        public ArticleContext()
            : base("name=ArticleContext")
        {
        }

        public virtual DbSet<ArticleCommonTable> ArticleCommonTables { get; set; }

        public virtual DbSet<ArticleFirstTypeTable> ArticleFirstTypes { get; set; }

        public virtual DbSet<ArticleSecondTypeTable> ArticleSecondTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            base.OnModelCreating(modelBuilder);
        }
    }
}