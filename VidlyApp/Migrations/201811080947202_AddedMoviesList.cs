namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMoviesList : DbMigration
    {
        public override void Up()
        {          
            Sql($"INSERT INTO Movies (Name, ReleaseDate, DateAdded, Genre_Id, Price) VALUES ('Hangover', '{new DateTime(2009, 11, 6).ToString()}', '{DateTime.Now.ToString()}', 5, 100)");
            Sql($"INSERT INTO Movies (Name, ReleaseDate, DateAdded, Genre_Id, Price) VALUES ('Die Hard', '{new DateTime(1998, 7, 15).ToString()}', '{DateTime.Now.ToString()}', 1, 150)");
        }
        
        public override void Down()
        {
        }
    }
}
