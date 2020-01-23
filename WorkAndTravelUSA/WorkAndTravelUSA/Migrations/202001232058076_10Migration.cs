namespace WorkAndTravelUSA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10Migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "oduser", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "oduser");
        }
    }
}
