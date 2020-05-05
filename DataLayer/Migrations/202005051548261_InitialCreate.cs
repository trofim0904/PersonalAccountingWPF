namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CashCountActionCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nama = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CashCountActions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        CashCountActionCategoryId = c.Int(nullable: false),
                        Sum = c.Single(nullable: false),
                        Price = c.Single(nullable: false),
                        Number = c.Int(nullable: false),
                        Comment = c.String(),
                        CashCount_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CashCounts", t => t.CashCount_Id)
                .ForeignKey("dbo.CashCountActionCategories", t => t.CashCountActionCategoryId, cascadeDelete: true)
                .Index(t => t.CashCountActionCategoryId)
                .Index(t => t.CashCount_Id);
            
            CreateTable(
                "dbo.CashCounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AmountOfMoney = c.Single(nullable: false),
                        Valuta = c.String(),
                        Comment = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CashCountActions", "CashCountActionCategoryId", "dbo.CashCountActionCategories");
            DropForeignKey("dbo.CashCounts", "UserId", "dbo.Users");
            DropForeignKey("dbo.CashCountActions", "CashCount_Id", "dbo.CashCounts");
            DropIndex("dbo.CashCounts", new[] { "UserId" });
            DropIndex("dbo.CashCountActions", new[] { "CashCount_Id" });
            DropIndex("dbo.CashCountActions", new[] { "CashCountActionCategoryId" });
            DropTable("dbo.Users");
            DropTable("dbo.CashCounts");
            DropTable("dbo.CashCountActions");
            DropTable("dbo.CashCountActionCategories");
        }
    }
}
