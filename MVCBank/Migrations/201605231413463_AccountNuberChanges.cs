namespace MVCBank.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountNuberChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CheckingAccounts", "AccountingNumber", c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CheckingAccounts", "AccountingNumber", c => c.String(nullable: false));
        }
    }
}
