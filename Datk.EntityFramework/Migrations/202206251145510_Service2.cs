namespace Datk.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Service2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "TypeSubServiceID", c => c.Int(nullable: false));
            AddColumn("dbo.Services", "RootServiceID", c => c.Int(nullable: false));
            DropColumn("dbo.Services", "SubServiceID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "SubServiceID", c => c.Int(nullable: false));
            DropColumn("dbo.Services", "RootServiceID");
            DropColumn("dbo.Services", "TypeSubServiceID");
        }
    }
}
