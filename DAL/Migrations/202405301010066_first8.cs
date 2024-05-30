namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Mun", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Mun");
        }
    }
}
