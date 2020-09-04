﻿namespace IShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3sep2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Address");
        }
    }
}
