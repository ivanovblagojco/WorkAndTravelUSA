namespace WorkAndTravelUSA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "IdClient", c => c.Int(nullable: false));
            AddColumn("dbo.Comments", "IdLoc", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "IdLoc");
            DropColumn("dbo.Locations", "IdClient");
        }
    }
}
