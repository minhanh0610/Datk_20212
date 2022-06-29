namespace Datk.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_Column_Service : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Services", "RootServiceID", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Services", "RootServiceID", c => c.Int(nullable: false));
        }
    }
}
