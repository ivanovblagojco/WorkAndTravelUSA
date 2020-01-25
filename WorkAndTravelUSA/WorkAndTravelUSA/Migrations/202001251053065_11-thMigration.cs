namespace WorkAndTravelUSA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11thMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "Raiting", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "Raiting");
        }
    }
}
