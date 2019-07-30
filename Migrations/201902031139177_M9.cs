namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CouponLists", "MacAddress", c => c.String(maxLength: 200));
            DropColumn("dbo.CouponLists", "UserId");
            DropColumn("dbo.CouponLists", "Seller");
            DropColumn("dbo.CouponLists", "DevId");
            DropColumn("dbo.CouponLists", "FastAd");
            DropColumn("dbo.CouponLists", "ClickedAd");
            DropColumn("dbo.CouponLists", "Status");
            DropColumn("dbo.CouponLists", "On");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CouponLists", "On", c => c.Boolean(nullable: false));
            AddColumn("dbo.CouponLists", "Status", c => c.String(maxLength: 200));
            AddColumn("dbo.CouponLists", "ClickedAd", c => c.String(maxLength: 200));
            AddColumn("dbo.CouponLists", "FastAd", c => c.String(maxLength: 200));
            AddColumn("dbo.CouponLists", "DevId", c => c.String(maxLength: 200));
            AddColumn("dbo.CouponLists", "Seller", c => c.String(maxLength: 200));
            AddColumn("dbo.CouponLists", "UserId", c => c.String(maxLength: 200));
            DropColumn("dbo.CouponLists", "MacAddress");
        }
    }
}
