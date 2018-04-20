namespace Vidly5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddatatoMovieTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, MovieInfoId) VALUES ('V for Vendetta',1)");
            Sql("INSERT INTO Movies (Name, MovieInfoId) VALUES ('Dredd',2)");
            Sql("INSERT INTO Movies (Name, MovieInfoId) VALUES ('Dr. Strange',3)");
            Sql("INSERT INTO Movies (Name, MovieInfoId) VALUES ('The Dark Knight',4)");
        }
        
        public override void Down()
        {
        }
    }
}
