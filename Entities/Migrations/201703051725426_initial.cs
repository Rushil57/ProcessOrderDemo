namespace Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        City = c.String(nullable: false),
                        State = c.String(nullable: false),
                        Zip = c.Int(nullable: false),
                        Phone = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        CardNumber = c.Int(nullable: false),
                        CardExpirationMonth = c.Int(nullable: false),
                        CardExpirationYear = c.Int(nullable: false),
                        CardSecurityCode = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
