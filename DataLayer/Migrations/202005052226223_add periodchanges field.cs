namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addperiodchangesfield : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CashCounts", "PeriodChanges", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CashCounts", "PeriodChanges");
        }
    }
}
