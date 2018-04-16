namespace Vidly5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, IsSubscribed, BirthDay, MembershipTypeId) VALUES ('Ada Lovelace', 1,'18151210', 4)");
            Sql("INSERT INTO Customers (Name, IsSubscribed, BirthDay, MembershipTypeId) VALUES ('Josh Parker',1,'19891125', 3)");
            Sql("INSERT INTO Customers (Name, IsSubscribed, BirthDay, MembershipTypeId) VALUES ('A Pineapple in a human suit',0,'20520611', 1)");
            Sql("INSERT INTO Customers (Name, IsSubscribed, BirthDay, MembershipTypeId) VALUES ('Fizz Buzz', 1,'19721015', 2)");

        }

        public override void Down()
        {
        }
    }
}
