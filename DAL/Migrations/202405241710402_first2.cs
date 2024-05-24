namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductDetailsPhones", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "UserId", "dbo.Users");
            DropForeignKey("dbo.Admins", "UId", "dbo.Users");
            DropForeignKey("dbo.Customers", "UId", "dbo.Users");
            DropIndex("dbo.Admins", new[] { "UId" });
            DropIndex("dbo.Customers", new[] { "UId" });
            DropIndex("dbo.ProductDetailsPhones", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "UserId" });
            DropPrimaryKey("dbo.Admins");
            DropPrimaryKey("dbo.Users");
            DropPrimaryKey("dbo.Customers");
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Admins", "UId", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "UId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Carts", "UId", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "UId", c => c.Int(nullable: false));
            AlterColumn("dbo.ProductDetailsPhones", "ProductId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "ProductId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Products", "UserId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Admins", "UId");
            AddPrimaryKey("dbo.Users", "UId");
            AddPrimaryKey("dbo.Customers", "UId");
            AddPrimaryKey("dbo.Products", "ProductId");
            CreateIndex("dbo.Admins", "UId");
            CreateIndex("dbo.Customers", "UId");
            CreateIndex("dbo.ProductDetailsPhones", "ProductId");
            CreateIndex("dbo.Products", "UserId");
            AddForeignKey("dbo.ProductDetailsPhones", "ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
            AddForeignKey("dbo.Products", "UserId", "dbo.Users", "UId", cascadeDelete: true);
            AddForeignKey("dbo.Admins", "UId", "dbo.Users", "UId");
            AddForeignKey("dbo.Customers", "UId", "dbo.Users", "UId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "UId", "dbo.Users");
            DropForeignKey("dbo.Admins", "UId", "dbo.Users");
            DropForeignKey("dbo.Products", "UserId", "dbo.Users");
            DropForeignKey("dbo.ProductDetailsPhones", "ProductId", "dbo.Products");
            DropIndex("dbo.Products", new[] { "UserId" });
            DropIndex("dbo.ProductDetailsPhones", new[] { "ProductId" });
            DropIndex("dbo.Customers", new[] { "UId" });
            DropIndex("dbo.Admins", new[] { "UId" });
            DropPrimaryKey("dbo.Products");
            DropPrimaryKey("dbo.Customers");
            DropPrimaryKey("dbo.Users");
            DropPrimaryKey("dbo.Admins");
            AlterColumn("dbo.Products", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Products", "ProductId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ProductDetailsPhones", "ProductId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Customers", "UId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Carts", "UId", c => c.String());
            AlterColumn("dbo.Users", "UId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Admins", "UId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Products", "ProductId");
            AddPrimaryKey("dbo.Customers", "UId");
            AddPrimaryKey("dbo.Users", "UId");
            AddPrimaryKey("dbo.Admins", "UId");
            CreateIndex("dbo.Products", "UserId");
            CreateIndex("dbo.Products", "ProductId", unique: true);
            CreateIndex("dbo.ProductDetailsPhones", "ProductId");
            CreateIndex("dbo.Customers", "UId");
            CreateIndex("dbo.Admins", "UId");
            AddForeignKey("dbo.Customers", "UId", "dbo.Users", "UId");
            AddForeignKey("dbo.Admins", "UId", "dbo.Users", "UId");
            AddForeignKey("dbo.Products", "UserId", "dbo.Users", "UId");
            AddForeignKey("dbo.ProductDetailsPhones", "ProductId", "dbo.Products", "ProductId");
        }
    }
}
