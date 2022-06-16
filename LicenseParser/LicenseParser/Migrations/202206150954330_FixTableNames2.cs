namespace LicenseParser.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixTableNames2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Feature", newName: "Features");
            RenameTable(name: "dbo.OtherLicenseUsage", newName: "OtherLicenseUsages");
            RenameTable(name: "dbo.UsageAction", newName: "UsageActions");
            RenameTable(name: "dbo.User", newName: "Users");
            RenameTable(name: "dbo.UserPC", newName: "UserPCs");
            RenameTable(name: "dbo.PDMLicenseUsage", newName: "PDMLicenseUsages");
            RenameTable(name: "dbo.SolidworksLicenseUsage", newName: "SolidworksLicenseUsages");
            RenameTable(name: "dbo.ViewerLicenseUsage", newName: "ViewerLicenseUsages");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ViewerLicenseUsages", newName: "ViewerLicenseUsage");
            RenameTable(name: "dbo.SolidworksLicenseUsages", newName: "SolidworksLicenseUsage");
            RenameTable(name: "dbo.PDMLicenseUsages", newName: "PDMLicenseUsage");
            RenameTable(name: "dbo.UserPCs", newName: "UserPC");
            RenameTable(name: "dbo.Users", newName: "User");
            RenameTable(name: "dbo.UsageActions", newName: "UsageAction");
            RenameTable(name: "dbo.OtherLicenseUsages", newName: "OtherLicenseUsage");
            RenameTable(name: "dbo.Features", newName: "Feature");
        }
    }
}
