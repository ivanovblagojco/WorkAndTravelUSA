namespace WorkAndTravelUSA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _8Migration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clients", "user2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "user2", c => c.String());
        }
    }
}
