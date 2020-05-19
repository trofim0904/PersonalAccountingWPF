namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetableCashCountPeriodChange : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CashCountPeriodChanges", "Date");
            DropColumn("dbo.CashCountPeriodChanges", "Price");
            DropColumn("dbo.CashCountPeriodChanges", "Number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CashCountPeriodChanges", "Number", c => c.Int(nullable: false));
            AddColumn("dbo.CashCountPeriodChanges", "Price", c => c.Single(nullable: false));
            AddColumn("dbo.CashCountPeriodChanges", "Date", c => c.String());
        }
    }
}
