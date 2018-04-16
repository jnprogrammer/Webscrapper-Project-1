namespace Vidly4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editMovieDataBase : DbMigration
    {
        public override void Up()
        {
            DropColumn("Movies", "MovieDetailId");
        }
        
        public override void Down()
        {
        }
    }
}
