namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AddSettings", "Android_Add_Mob_App_Id", c => c.String(maxLength: 200));
            AddColumn("dbo.AddSettings", "Android_Interstitial_Unit_Id_1", c => c.String(maxLength: 200));
            AddColumn("dbo.AddSettings", "Android_Bottom_banner_unit_Id", c => c.String(maxLength: 200));
            AddColumn("dbo.AddSettings", "Android_Reward_unit_Id", c => c.String(maxLength: 200));
            AddColumn("dbo.AddSettings", "Ios_Add_Mob_App_Id", c => c.String(maxLength: 200));
            AddColumn("dbo.AddSettings", "Ios_Interstitial_Unit_Id_1", c => c.String(maxLength: 200));
            AddColumn("dbo.AddSettings", "Ios_Bottom_banner_unit_Id", c => c.String(maxLength: 200));
            AddColumn("dbo.AddSettings", "Ios_Reward_unit_Id", c => c.String(maxLength: 200));
            DropColumn("dbo.AddSettings", "Add_Mob_App_Id");
            DropColumn("dbo.AddSettings", "Interstitial_Unit_Id_1");
            DropColumn("dbo.AddSettings", "Bottom_banner_unit_Id");
            DropColumn("dbo.AddSettings", "Reward_unit_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AddSettings", "Reward_unit_Id", c => c.String(maxLength: 200));
            AddColumn("dbo.AddSettings", "Bottom_banner_unit_Id", c => c.String(maxLength: 200));
            AddColumn("dbo.AddSettings", "Interstitial_Unit_Id_1", c => c.String(maxLength: 200));
            AddColumn("dbo.AddSettings", "Add_Mob_App_Id", c => c.String(maxLength: 200));
            DropColumn("dbo.AddSettings", "Ios_Reward_unit_Id");
            DropColumn("dbo.AddSettings", "Ios_Bottom_banner_unit_Id");
            DropColumn("dbo.AddSettings", "Ios_Interstitial_Unit_Id_1");
            DropColumn("dbo.AddSettings", "Ios_Add_Mob_App_Id");
            DropColumn("dbo.AddSettings", "Android_Reward_unit_Id");
            DropColumn("dbo.AddSettings", "Android_Bottom_banner_unit_Id");
            DropColumn("dbo.AddSettings", "Android_Interstitial_Unit_Id_1");
            DropColumn("dbo.AddSettings", "Android_Add_Mob_App_Id");
        }
    }
}
