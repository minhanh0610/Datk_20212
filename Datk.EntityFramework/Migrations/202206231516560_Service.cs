namespace Datk.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Service : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Service",
                table => new
                {
                    Id = table.Int(nullable: false, identity: true),
                    SubServiceID = table.Int(nullable: false),
                    State = table.Int(nullable: false),
                    CreatedBy = table.Int(nullable: false),
                    Basic_Information = table.String(nullable: true),
                    Represent_Information = table.String(nullable: true),
                    Time = table.String(nullable: true)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
               "dbo.TypeService",
                table => new
                {
                    Id = table.Int(nullable: false, identity: true),
                    Type = table.String(nullable: false),
                    Description = table.String(nullable: true)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
               "dbo.State",
                table => new
                {
                    Id = table.Int(nullable: false, identity: true),
                    Type = table.String(nullable: false),
                    Description = table.String(nullable: true)
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
               "dbo.TypeSubService",
                table => new
                {
                    Id = table.Int(nullable: false, identity: true),
                    ServiceID = table.Int(nullable: false),
                    Type = table.String(nullable: false),
                    Description = table.String(nullable: true)
                })
                .PrimaryKey(t => t.Id);


        }
        
        public override void Down()
        {
            DropTable("dbo.Service");
            DropTable("dbo.TypeService");
            DropTable("dbo.TypeSubService");
            DropTable("dbo.State");
        }
    }
}
