namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddnewtableCashCountPeriodChangeandaddnewfieldtotableCashCountAction : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CashCountActions", "CashCount_Id", "dbo.CashCounts");
            DropIndex("dbo.CashCountActions", new[] { "CashCount_Id" });
            RenameColumn(table: "dbo.CashCountActions", name: "CashCount_Id", newName: "CashCountId");
            CreateTable(
                "dbo.CashCountPeriodChanges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        CashCountActionCategoryId = c.Int(nullable: false),
                        CashCountId = c.Int(nullable: false),
                        Sum = c.Single(nullable: false),
                        Price = c.Single(nullable: false),
                        Number = c.Int(nullable: false),
                        Comment = c.String(),
                        ChangeDate = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CashCounts", t => t.CashCountId, cascadeDelete: true)
                .ForeignKey("dbo.CashCountActionCategories", t => t.CashCountActionCategoryId, cascadeDelete: true)
                .Index(t => t.CashCountActionCategoryId)
                .Index(t => t.CashCountId);
            
            AlterColumn("dbo.CashCountActions", "CashCountId", c => c.Int(nullable: false));
            CreateIndex("dbo.CashCountActions", "CashCountId");
            AddForeignKey("dbo.CashCountActions", "CashCountId", "dbo.CashCounts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CashCountActions", "CashCountId", "dbo.CashCounts");
            DropForeignKey("dbo.CashCountPeriodChanges", "CashCountActionCategoryId", "dbo.CashCountActionCategories");
            DropForeignKey("dbo.CashCountPeriodChanges", "CashCountId", "dbo.CashCounts");
            DropIndex("dbo.CashCountPeriodChanges", new[] { "CashCountId" });
            DropIndex("dbo.CashCountPeriodChanges", new[] { "CashCountActionCategoryId" });
            DropIndex("dbo.CashCountActions", new[] { "CashCountId" });
            AlterColumn("dbo.CashCountActions", "CashCountId", c => c.Int());
            DropTable("dbo.CashCountPeriodChanges");
            RenameColumn(table: "dbo.CashCountActions", name: "CashCountId", newName: "CashCount_Id");
            CreateIndex("dbo.CashCountActions", "CashCount_Id");
            AddForeignKey("dbo.CashCountActions", "CashCount_Id", "dbo.CashCounts", "Id");
        }
    }
}
