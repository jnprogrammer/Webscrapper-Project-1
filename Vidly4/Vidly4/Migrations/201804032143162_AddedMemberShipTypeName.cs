namespace Vidly4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMemberShipTypeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "MembershipTitle", c => c.String());
          //  Sql("INSERT INTO MembershipTypes (MemberShipTitle) VALUE(")
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "MembershipTitle");
        }
    }
}
