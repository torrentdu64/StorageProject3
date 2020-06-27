namespace StorageProject3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProduct1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MyProperty = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.LocationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "LocationId", "dbo.Locations");
            DropIndex("dbo.Products", new[] { "LocationId" });
            DropTable("dbo.Products");
        }
    }
}
