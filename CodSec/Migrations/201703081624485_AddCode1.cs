namespace CodSec.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCode1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Codes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 255),
                        Pin = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Codes");
        }
    }
}
