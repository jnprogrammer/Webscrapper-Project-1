namespace Vidly5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribed");
        }
    }
}
