namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CouponLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 200),
                        Device = c.String(maxLength: 200),
                        Seller = c.String(maxLength: 200),
                        DevId = c.String(maxLength: 200),
                        FastAd = c.String(maxLength: 200),
                        AdUnit = c.String(maxLength: 200),
                        ClickedAd = c.String(maxLength: 200),
                        Coupon = c.String(maxLength: 200),
                        Status = c.String(maxLength: 200),
                        On = c.Boolean(nullable: false),
                        Updated = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CouponLists");
        }
    }
}
