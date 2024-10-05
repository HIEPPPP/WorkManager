namespace WorkManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delete : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.NewRequest");
        }
        
        public override void Down()
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
    }
}
