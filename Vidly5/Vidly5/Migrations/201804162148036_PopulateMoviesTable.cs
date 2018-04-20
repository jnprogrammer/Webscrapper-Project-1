namespace Vidly5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieInfoes (Id,Genre,ReleaseDate,DateAdded,NumInStock) VALUES (1,'Action','20060317','20171114',5)");
            Sql("INSERT INTO MovieInfoes (Id,Genre,ReleaseDate,DateAdded,NumInStock) VALUES (2,'Action','20120921','20140104',2)");
            Sql("INSERT INTO MovieInfoes (Id,Genre,ReleaseDate,DateAdded,NumInStock) VALUES (3,'Adventure','20060317','20171114',1)");
            Sql("INSERT INTO MovieInfoes (Id,Genre,ReleaseDate,DateAdded,NumInStock) VALUES (4,'Suspense','20120317','20171114',12)");

            
        }

        public override void Down()
        {
        }
    }
}
