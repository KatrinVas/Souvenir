namespace Souvenir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Souvenirs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Souvenirs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        RegisterOn = c.DateTime(nullable: false),
                        SouvenirTypesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SouvenirTypes", t => t.SouvenirTypesId, cascadeDelete: true)
                .Index(t => t.SouvenirTypesId);
            
            CreateTable(
                "dbo.SouvenirTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Souvenirs", "SouvenirTypesId", "dbo.SouvenirTypes");
            DropIndex("dbo.Souvenirs", new[] { "SouvenirTypesId" });
            DropTable("dbo.SouvenirTypes");
            DropTable("dbo.Souvenirs");
        }
    }
}
