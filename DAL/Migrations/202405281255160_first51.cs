﻿namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first51 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "Ram", c => c.String());
            AddColumn("dbo.Carts", "Storage", c => c.String());
            AddColumn("dbo.Carts", "Color", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Carts", "Color");
            DropColumn("dbo.Carts", "Storage");
            DropColumn("dbo.Carts", "Ram");
        }
    }
}
