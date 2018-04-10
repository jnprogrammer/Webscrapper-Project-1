namespace Vidly4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerTableWithData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('Ada Lovelace', 1, 4)");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('Josh Parker', 1, 3)");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('A Pineapple in a human suit', 0, 1)");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('Fizz Buzz', 1, 2)");
            //Sql("UPDATE Customers SET Name = 'Ada Lovelace', IsSubscribedToNewsletter = True, MembershipTypeId = 4 WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
