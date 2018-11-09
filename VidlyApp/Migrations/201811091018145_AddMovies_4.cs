namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies_4 : DbMigration
    {
        public override void Up()
        {
            Sql($"INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId) VALUES ('Hangover', {new DateTime(2009, 11, 6).ToShortDateString()}, {DateTime.Now.ToShortDateString()}, 5)");
            Sql($"INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId) VALUES ('Die Hard', {new DateTime(1988, 7, 15).ToShortDateString()}, {DateTime.Now.ToShortDateString()}, 1)");
            Sql($"INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId) VALUES ('Die Hard 3', {new DateTime(1990, 4, 7).ToShortDateString()}, {DateTime.Now.ToShortDateString()}, 1)");
        }

        public override void Down()
        {
        }
    }
}
