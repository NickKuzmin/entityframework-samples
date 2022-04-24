namespace EntityFramework.Samples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ArticleContextDBVersion1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.articlecommontable",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        articletitle = c.String(),
                        type = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.articlefirsttypetable",
                c => new
                    {
                        id = c.Int(nullable: false),
                        articlefirsttypeproperty = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.articlecommontable", t => t.id)
                .Index(t => t.id);
            
            CreateTable(
                "dbo.articlesecondtypetable",
                c => new
                    {
                        id = c.Int(nullable: false),
                        articlesecondtypeproperty = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.articlecommontable", t => t.id)
                .Index(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.articlesecondtypetable", "id", "dbo.articlecommontable");
            DropForeignKey("dbo.articlefirsttypetable", "id", "dbo.articlecommontable");
            DropIndex("dbo.articlesecondtypetable", new[] { "id" });
            DropIndex("dbo.articlefirsttypetable", new[] { "id" });
            DropTable("dbo.articlesecondtypetable");
            DropTable("dbo.articlefirsttypetable");
            DropTable("dbo.articlecommontable");
        }
    }
}
