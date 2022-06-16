namespace LicenseParser.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Feature",
                c => new
                    {
                        FeatureId = c.Int(nullable: false, identity: true),
                        FeatureName = c.String(),
                    })
                .PrimaryKey(t => t.FeatureId);
            
            CreateTable(
                "dbo.OtherLicenseUsage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedAt = c.DateTime(nullable: false),
                        CurrentlyOccupiedLicense = c.Int(nullable: false),
                        Feature_FeatureId = c.Int(),
                        UsageAction_UsageActionId = c.Int(),
                        User_UserId = c.Int(),
                        UserPC_UserPCId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Feature", t => t.Feature_FeatureId)
                .ForeignKey("dbo.UsageAction", t => t.UsageAction_UsageActionId)
                .ForeignKey("dbo.User", t => t.User_UserId)
                .ForeignKey("dbo.UserPC", t => t.UserPC_UserPCId)
                .Index(t => t.Feature_FeatureId)
                .Index(t => t.UsageAction_UsageActionId)
                .Index(t => t.User_UserId)
                .Index(t => t.UserPC_UserPCId);
            
            CreateTable(
                "dbo.UsageAction",
                c => new
                    {
                        UsageActionId = c.Int(nullable: false, identity: true),
                        Action = c.String(),
                    })
                .PrimaryKey(t => t.UsageActionId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.UserPC",
                c => new
                    {
                        UserPCId = c.Int(nullable: false, identity: true),
                        PCName = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.UserPCId)
                .Index(t => t.PCName, unique: true);
            
            CreateTable(
                "dbo.PDMLicenseUsage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedAt = c.DateTime(nullable: false),
                        CurrentlyOccupiedLicense = c.Int(nullable: false),
                        Feature_FeatureId = c.Int(),
                        UsageAction_UsageActionId = c.Int(),
                        User_UserId = c.Int(),
                        UserPC_UserPCId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Feature", t => t.Feature_FeatureId)
                .ForeignKey("dbo.UsageAction", t => t.UsageAction_UsageActionId)
                .ForeignKey("dbo.User", t => t.User_UserId)
                .ForeignKey("dbo.UserPC", t => t.UserPC_UserPCId)
                .Index(t => t.Feature_FeatureId)
                .Index(t => t.UsageAction_UsageActionId)
                .Index(t => t.User_UserId)
                .Index(t => t.UserPC_UserPCId);
            
            CreateTable(
                "dbo.SolidworksLicenseUsage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedAt = c.DateTime(nullable: false),
                        CurrentlyOccupiedLicense = c.Int(nullable: false),
                        Feature_FeatureId = c.Int(),
                        UsageAction_UsageActionId = c.Int(),
                        User_UserId = c.Int(),
                        UserPC_UserPCId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Feature", t => t.Feature_FeatureId)
                .ForeignKey("dbo.UsageAction", t => t.UsageAction_UsageActionId)
                .ForeignKey("dbo.User", t => t.User_UserId)
                .ForeignKey("dbo.UserPC", t => t.UserPC_UserPCId)
                .Index(t => t.Feature_FeatureId)
                .Index(t => t.UsageAction_UsageActionId)
                .Index(t => t.User_UserId)
                .Index(t => t.UserPC_UserPCId);
            
            CreateTable(
                "dbo.ViewerLicenseUsage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedAt = c.DateTime(nullable: false),
                        CurrentlyOccupiedLicense = c.Int(nullable: false),
                        Feature_FeatureId = c.Int(),
                        UsageAction_UsageActionId = c.Int(),
                        User_UserId = c.Int(),
                        UserPC_UserPCId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Feature", t => t.Feature_FeatureId)
                .ForeignKey("dbo.UsageAction", t => t.UsageAction_UsageActionId)
                .ForeignKey("dbo.User", t => t.User_UserId)
                .ForeignKey("dbo.UserPC", t => t.UserPC_UserPCId)
                .Index(t => t.Feature_FeatureId)
                .Index(t => t.UsageAction_UsageActionId)
                .Index(t => t.User_UserId)
                .Index(t => t.UserPC_UserPCId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ViewerLicenseUsage", "UserPC_UserPCId", "dbo.UserPC");
            DropForeignKey("dbo.ViewerLicenseUsage", "User_UserId", "dbo.User");
            DropForeignKey("dbo.ViewerLicenseUsage", "UsageAction_UsageActionId", "dbo.UsageAction");
            DropForeignKey("dbo.ViewerLicenseUsage", "Feature_FeatureId", "dbo.Feature");
            DropForeignKey("dbo.SolidworksLicenseUsage", "UserPC_UserPCId", "dbo.UserPC");
            DropForeignKey("dbo.SolidworksLicenseUsage", "User_UserId", "dbo.User");
            DropForeignKey("dbo.SolidworksLicenseUsage", "UsageAction_UsageActionId", "dbo.UsageAction");
            DropForeignKey("dbo.SolidworksLicenseUsage", "Feature_FeatureId", "dbo.Feature");
            DropForeignKey("dbo.PDMLicenseUsage", "UserPC_UserPCId", "dbo.UserPC");
            DropForeignKey("dbo.PDMLicenseUsage", "User_UserId", "dbo.User");
            DropForeignKey("dbo.PDMLicenseUsage", "UsageAction_UsageActionId", "dbo.UsageAction");
            DropForeignKey("dbo.PDMLicenseUsage", "Feature_FeatureId", "dbo.Feature");
            DropForeignKey("dbo.OtherLicenseUsage", "UserPC_UserPCId", "dbo.UserPC");
            DropForeignKey("dbo.OtherLicenseUsage", "User_UserId", "dbo.User");
            DropForeignKey("dbo.OtherLicenseUsage", "UsageAction_UsageActionId", "dbo.UsageAction");
            DropForeignKey("dbo.OtherLicenseUsage", "Feature_FeatureId", "dbo.Feature");
            DropIndex("dbo.ViewerLicenseUsage", new[] { "UserPC_UserPCId" });
            DropIndex("dbo.ViewerLicenseUsage", new[] { "User_UserId" });
            DropIndex("dbo.ViewerLicenseUsage", new[] { "UsageAction_UsageActionId" });
            DropIndex("dbo.ViewerLicenseUsage", new[] { "Feature_FeatureId" });
            DropIndex("dbo.SolidworksLicenseUsage", new[] { "UserPC_UserPCId" });
            DropIndex("dbo.SolidworksLicenseUsage", new[] { "User_UserId" });
            DropIndex("dbo.SolidworksLicenseUsage", new[] { "UsageAction_UsageActionId" });
            DropIndex("dbo.SolidworksLicenseUsage", new[] { "Feature_FeatureId" });
            DropIndex("dbo.PDMLicenseUsage", new[] { "UserPC_UserPCId" });
            DropIndex("dbo.PDMLicenseUsage", new[] { "User_UserId" });
            DropIndex("dbo.PDMLicenseUsage", new[] { "UsageAction_UsageActionId" });
            DropIndex("dbo.PDMLicenseUsage", new[] { "Feature_FeatureId" });
            DropIndex("dbo.UserPC", new[] { "PCName" });
            DropIndex("dbo.OtherLicenseUsage", new[] { "UserPC_UserPCId" });
            DropIndex("dbo.OtherLicenseUsage", new[] { "User_UserId" });
            DropIndex("dbo.OtherLicenseUsage", new[] { "UsageAction_UsageActionId" });
            DropIndex("dbo.OtherLicenseUsage", new[] { "Feature_FeatureId" });
            DropTable("dbo.ViewerLicenseUsage");
            DropTable("dbo.SolidworksLicenseUsage");
            DropTable("dbo.PDMLicenseUsage");
            DropTable("dbo.UserPC");
            DropTable("dbo.User");
            DropTable("dbo.UsageAction");
            DropTable("dbo.OtherLicenseUsage");
            DropTable("dbo.Feature");
        }
    }
}
