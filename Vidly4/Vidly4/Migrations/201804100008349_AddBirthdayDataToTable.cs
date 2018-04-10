namespace Vidly4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdayDataToTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET birthday = '18151210' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET birthday = '19891125' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET birthday = '20381124' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET birthday = '19871210' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
