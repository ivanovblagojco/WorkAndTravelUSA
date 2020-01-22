namespace WorkAndTravelUSA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4Migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "idClient", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "idClient");
        }
    }
}
