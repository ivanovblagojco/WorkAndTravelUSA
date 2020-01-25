namespace WorkAndTravelUSA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _13thMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "finalRating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "finalRating");
        }
    }
}
