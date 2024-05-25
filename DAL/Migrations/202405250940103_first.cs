namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        UId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        Gender = c.String(),
                    })
                .PrimaryKey(t => t.UId)
                .ForeignKey("dbo.Users", t => t.UId)
                .Index(t => t.UId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UId = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        UserType = c.String(),
                    })
                .PrimaryKey(t => t.UId);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        ProductName = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categoties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        UId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        Gender = c.String(),
                    })
                .PrimaryKey(t => t.UId)
                .ForeignKey("dbo.Users", t => t.UId)
                .Index(t => t.UId);
            
            CreateTable(
                "dbo.ProductDetailsPhones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ModelName = c.String(),
                        OperatingSystem = c.String(),
                        Tag = c.String(),
                        Description = c.String(),
                        Variations = c.String(),
                        Quntity = c.Int(nullable: false),
                        Img1 = c.Binary(),
                        Img2 = c.Binary(),
                        Img3 = c.Binary(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Name = c.String(),
                        Title = c.String(),
                        CategoryId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Tag = c.String(),
                        Brand = c.String(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categoties", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.ProductTypes", t => t.TypeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.CategoryId)
                .Index(t => t.TypeId);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDetailsPhones", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "UserId", "dbo.Users");
            DropForeignKey("dbo.Products", "TypeId", "dbo.ProductTypes");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categoties");
            DropForeignKey("dbo.Customers", "UId", "dbo.Users");
            DropForeignKey("dbo.Admins", "UId", "dbo.Users");
            DropIndex("dbo.Products", new[] { "TypeId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.Products", new[] { "UserId" });
            DropIndex("dbo.ProductDetailsPhones", new[] { "ProductId" });
            DropIndex("dbo.Customers", new[] { "UId" });
            DropIndex("dbo.Admins", new[] { "UId" });
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
            DropTable("dbo.ProductDetailsPhones");
            DropTable("dbo.Customers");
            DropTable("dbo.Categoties");
            DropTable("dbo.Carts");
            DropTable("dbo.Users");
            DropTable("dbo.Admins");
        }
    }
}
