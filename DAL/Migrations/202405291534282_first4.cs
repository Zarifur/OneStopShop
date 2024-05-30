namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "Variations", c => c.String());
            AddColumn("dbo.Customers", "Address", c => c.String());
            AddColumn("dbo.Tokens", "UserType", c => c.String());
            DropColumn("dbo.Carts", "Ram");
            DropColumn("dbo.Carts", "Storage");
            DropColumn("dbo.Carts", "Color");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carts", "Color", c => c.String());
            AddColumn("dbo.Carts", "Storage", c => c.String());
            AddColumn("dbo.Carts", "Ram", c => c.String());
            DropColumn("dbo.Tokens", "UserType");
            DropColumn("dbo.Customers", "Address");
            DropColumn("dbo.Carts", "Variations");
        }
    }
}
