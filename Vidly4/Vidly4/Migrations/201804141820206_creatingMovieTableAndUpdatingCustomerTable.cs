namespace Vidly4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creatingMovieTableAndUpdatingCustomerTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        MovieDetailId = c.Byte(nullable: false),
                        MovieDetailModel_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovieDetailModels", t => t.MovieDetailModel_Id)
                .Index(t => t.MovieDetailModel_Id);
            
            CreateTable(
                "dbo.MovieDetailModels",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Genre = c.String(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        AddDate = c.DateTime(nullable: false),
                        UnitsInStock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MovieDetailModel_Id", "dbo.MovieDetailModels");
            DropIndex("dbo.Movies", new[] { "MovieDetailModel_Id" });
            DropTable("dbo.MovieDetailModels");
            DropTable("dbo.Movies");
        }
    }
}
