namespace Vidly4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdayColumnInCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET birthday = '18151210' WHERE Id = 1");
            Sql("UPDATE Customers SET birthday = '19891125' WHERE Id = 2");
            Sql("UPDATE Customers SET birthday = '20381124' WHERE Id = 3");
            Sql("UPDATE Customers SET birthday = '19871210' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
