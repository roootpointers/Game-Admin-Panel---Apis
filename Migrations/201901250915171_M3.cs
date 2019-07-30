namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddSettings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Add_Mob_App_Id = c.String(maxLength: 200),
                        Interstitial_Unit_Id_1 = c.String(maxLength: 200),
                        Interstitial_Unit_Id_2 = c.String(maxLength: 200),
                        Bottom_banner_unit_Id = c.String(maxLength: 200),
                        Reward_unit_Id = c.String(maxLength: 200),
                        Extra_1_Id = c.String(maxLength: 200),
                        Extra_2_Id = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AddSettings");
        }
    }
}
