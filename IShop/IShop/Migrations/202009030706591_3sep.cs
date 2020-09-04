namespace IShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3sep : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "VendorId", "dbo.Vendors");
            DropIndex("dbo.Products", new[] { "VendorId" });
            AddColumn("dbo.Products", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Username", c => c.String());
            AddColumn("dbo.Users", "IsVendor", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Products", "UserId");
            AddForeignKey("dbo.Products", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
            DropColumn("dbo.Products", "VendorId");
            DropColumn("dbo.Users", "Usrname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Usrname", c => c.String());
            AddColumn("dbo.Products", "VendorId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Products", "UserId", "dbo.Users");
            DropIndex("dbo.Products", new[] { "UserId" });
            DropColumn("dbo.Users", "IsVendor");
            DropColumn("dbo.Users", "Username");
            DropColumn("dbo.Products", "UserId");
            CreateIndex("dbo.Products", "VendorId");
            AddForeignKey("dbo.Products", "VendorId", "dbo.Vendors", "VendorId", cascadeDelete: true);
        }
    }
}
