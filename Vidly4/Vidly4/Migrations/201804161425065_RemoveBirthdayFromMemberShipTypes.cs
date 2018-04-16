namespace Vidly4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveBirthdayFromMemberShipTypes : DbMigration
    {
        public override void Up()
        {
            DropColumn("MembershipTypes", "birthday");
        }
        
        public override void Down()
        {
        }
    }
}
