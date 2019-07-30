namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AddControls", "RewardVideo_cb", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AddControls", "RewardVideo_cb", c => c.Single(nullable: false));
        }
    }
}
