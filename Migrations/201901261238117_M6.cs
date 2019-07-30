namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CouponLists", "Updated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CouponLists", "Updated", c => c.String(maxLength: 200));
        }
    }
}
