namespace WorkAndTravelUSA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirdMigrations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "imgUrl", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "imgUrl");
        }
    }
}
