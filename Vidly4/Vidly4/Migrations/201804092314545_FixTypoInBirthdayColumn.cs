namespace Vidly4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixTypoInBirthdayColumn : DbMigration
    {
        public override void Up()
        {
           // AddColumn("dbo.MembershipTypes", "Birthday", c => c.DateTime(nullable: true));
           //This migration was an attempt to rename the birthday column to Birthday
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "birthday");
        }
    }
}
