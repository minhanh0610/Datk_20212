namespace Datk.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Service1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubServiceID = c.Int(nullable: false),
                        CreatedBy = c.Int(),
                        Basic_Information = c.String(),
                        Represent_Information = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        State = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeSubServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceId = c.Int(nullable: false),
                        Type = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TypeSubServices");
            DropTable("dbo.TypeServices");
            DropTable("dbo.Services");
        }
    }
}
