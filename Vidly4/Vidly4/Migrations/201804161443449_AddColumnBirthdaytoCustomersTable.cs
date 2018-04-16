namespace Vidly4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnBirthdaytoCustomersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthday", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
        }
    }
}
