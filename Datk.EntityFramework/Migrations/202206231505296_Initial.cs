

namespace Datk.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
       "dbo.Authors",
        c => new
        {
            AuthorId = c.Int(nullable: false, identity: true),
            Name = c.String(maxLength: 128),
        })
        .PrimaryKey(t => t.AuthorId);

            CreateTable(
               "dbo.BlogPosts",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Title = c.String(nullable: false, maxLength: 128),
                   Message = c.String(),
                   Author_AuthorId = c.Int(),
               })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.Author_AuthorId)
                .Index(t => t.Author_AuthorId);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BlogPosts", "Author_AuthorId", "dbo.Authors");
            DropIndex("dbo.BlogPosts", new[] { "Author_AuthorId" });
            DropTable("dbo.BlogPosts");
            DropTable("dbo.Authors");
        }
    }
}
