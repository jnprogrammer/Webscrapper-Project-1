namespace Vidly4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdayToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "birthday", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "birthday");
        }
    }
}
