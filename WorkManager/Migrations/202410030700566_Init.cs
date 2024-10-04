namespace WorkManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Request", "ResquestBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Request", "ResquestBy");
        }
    }
}
