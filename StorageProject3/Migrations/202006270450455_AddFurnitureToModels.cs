namespace StorageProject3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFurnitureToModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Furnitures",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DepotId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Depots", t => t.DepotId, cascadeDelete: true)
                .Index(t => t.DepotId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Furnitures", "DepotId", "dbo.Depots");
            DropIndex("dbo.Furnitures", new[] { "DepotId" });
            DropTable("dbo.Furnitures");
        }
    }
}
