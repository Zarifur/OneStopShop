namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        UId = c.Int(nullable: false),
                        ProductName = c.String(),
                        Address = c.String(),
                        Quntity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlacedOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        UId = c.Int(nullable: false),
                        ProductName = c.String(),
                        Address = c.String(),
                        Quntity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoginToken = c.String(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ExpDate = c.DateTime(),
                        UId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UId, cascadeDelete: true)
                .Index(t => t.UId);
            
            AddColumn("dbo.Carts", "Quntity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tokens", "UId", "dbo.Users");
            DropIndex("dbo.Tokens", new[] { "UId" });
            DropColumn("dbo.Carts", "Quntity");
            DropTable("dbo.Tokens");
            DropTable("dbo.PlacedOrders");
            DropTable("dbo.MyOrders");
        }
    }
}
