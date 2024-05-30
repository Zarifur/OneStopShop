namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fiest62 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlacedOrders", "Variations", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PlacedOrders", "Variations");
        }
    }
}
