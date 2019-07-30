namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Questions", "GameID", "dbo.Games");
            DropForeignKey("dbo.UserGames", "GameID", "dbo.Games");
            DropIndex("dbo.Questions", new[] { "GameID" });
            DropIndex("dbo.UserGames", new[] { "GameID" });
            CreateTable(
                "dbo.AddControls",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Interstitial_1 = c.Single(nullable: false),
                        Interstitial_1_cb = c.Boolean(nullable: false),
                        Interstitial_2 = c.Single(nullable: false),
                        Interstitial_2_cb = c.Boolean(nullable: false),
                        Bottom_banner = c.Single(nullable: false),
                        Bottom_banner_cb = c.Boolean(nullable: false),
                        RewardVideo = c.Single(nullable: false),
                        RewardVideo_cb = c.Single(nullable: false),
                        Extra_1 = c.Single(nullable: false),
                        Extra_1_cb = c.Boolean(nullable: false),
                        Extra_2 = c.Single(nullable: false),
                        Extra_2_cb = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Games");
            DropTable("dbo.Questions");
            DropTable("dbo.UserGames");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserGames",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GameResult = c.String(maxLength: 50),
                        Device = c.String(maxLength: 50),
                        Cash = c.Int(),
                        EmailId = c.String(maxLength: 50),
                        GameID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Mcq = c.String(maxLength: 500),
                        Option1 = c.String(maxLength: 500),
                        Option2 = c.String(maxLength: 500),
                        Option3 = c.String(maxLength: 500),
                        Atrue = c.Boolean(nullable: false),
                        Btrue = c.Boolean(nullable: false),
                        Ctrue = c.Boolean(nullable: false),
                        Explanation = c.String(maxLength: 500),
                        GameID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Prize = c.Int(),
                        Date = c.DateTime(nullable: false),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.AddControls");
            CreateIndex("dbo.UserGames", "GameID");
            CreateIndex("dbo.Questions", "GameID");
            AddForeignKey("dbo.UserGames", "GameID", "dbo.Games", "ID");
            AddForeignKey("dbo.Questions", "GameID", "dbo.Games", "ID");
        }
    }
}
