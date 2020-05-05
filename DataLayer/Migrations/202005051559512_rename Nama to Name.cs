namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameNamatoName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CashCountActionCategories", "Name", c => c.String());
            DropColumn("dbo.CashCountActionCategories", "Nama");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CashCountActionCategories", "Nama", c => c.String());
            DropColumn("dbo.CashCountActionCategories", "Name");
        }
    }
}
