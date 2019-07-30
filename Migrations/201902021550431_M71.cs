namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M71 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AddControls", "Interstitial_2");
            DropColumn("dbo.AddControls", "Interstitial_2_cb");
            DropColumn("dbo.AddControls", "Extra_1");
            DropColumn("dbo.AddControls", "Extra_1_cb");
            DropColumn("dbo.AddControls", "Extra_2");
            DropColumn("dbo.AddControls", "Extra_2_cb");
            DropColumn("dbo.AddSettings", "Interstitial_Unit_Id_2");
            DropColumn("dbo.AddSettings", "Extra_1_Id");
            DropColumn("dbo.AddSettings", "Extra_2_Id");
            DropTable("dbo.Groups");
            DropTable("dbo.GroupUsers");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 50),
                        UserId = c.String(maxLength: 50),
                        PhoneNo = c.String(maxLength: 50),
                        ProfilePic = c.String(maxLength: 100),
                        Password = c.String(maxLength: 50),
                        AddDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GroupUsers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GroupID = c.Int(),
                        UserID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.AddSettings", "Extra_2_Id", c => c.String(maxLength: 200));
            AddColumn("dbo.AddSettings", "Extra_1_Id", c => c.String(maxLength: 200));
            AddColumn("dbo.AddSettings", "Interstitial_Unit_Id_2", c => c.String(maxLength: 200));
            AddColumn("dbo.AddControls", "Extra_2_cb", c => c.Boolean(nullable: false));
            AddColumn("dbo.AddControls", "Extra_2", c => c.Single(nullable: false));
            AddColumn("dbo.AddControls", "Extra_1_cb", c => c.Boolean(nullable: false));
            AddColumn("dbo.AddControls", "Extra_1", c => c.Single(nullable: false));
            AddColumn("dbo.AddControls", "Interstitial_2_cb", c => c.Boolean(nullable: false));
            AddColumn("dbo.AddControls", "Interstitial_2", c => c.Single(nullable: false));
        }
    }
}
