namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenres : DbMigration
    {
        public override void Up()
        {
            Sql($"INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, Genre_Id) VALUES (1, Hangover, 6/11/2009, {DateTime.Now.ToShortDateString()}, 1)");
        }
        
        public override void Down()
        {
        }
    }
}
