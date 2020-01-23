namespace WorkAndTravelUSA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7Migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "user2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "user2");
        }
    }
}
