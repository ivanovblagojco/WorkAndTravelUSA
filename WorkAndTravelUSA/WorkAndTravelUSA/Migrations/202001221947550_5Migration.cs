namespace WorkAndTravelUSA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5Migration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClientLocs", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Locations", "ClientLoc_Id", "dbo.ClientLocs");
            DropIndex("dbo.ClientLocs", new[] { "Client_Id" });
            DropIndex("dbo.Locations", new[] { "ClientLoc_Id" });
            DropColumn("dbo.Locations", "ClientLoc_Id");
            DropTable("dbo.ClientLocs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ClientLocs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Locations", "ClientLoc_Id", c => c.Int());
            CreateIndex("dbo.Locations", "ClientLoc_Id");
            CreateIndex("dbo.ClientLocs", "Client_Id");
            AddForeignKey("dbo.Locations", "ClientLoc_Id", "dbo.ClientLocs", "Id");
            AddForeignKey("dbo.ClientLocs", "Client_Id", "dbo.Clients", "Id");
        }
    }
}
