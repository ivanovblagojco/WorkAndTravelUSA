namespace WorkAndTravelUSA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12thMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "NumOfRatings", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "NumOfRatings");
        }
    }
}
