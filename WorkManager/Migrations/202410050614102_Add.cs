namespace WorkManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewRequest",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestType = c.String(),
                        Department = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        IsHandled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewRequest");
        }
    }
}
