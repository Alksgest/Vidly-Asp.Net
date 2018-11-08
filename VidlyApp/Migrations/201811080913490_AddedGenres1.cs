namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenres1 : DbMigration
    {
        public override void Up()
        {
            // Sql("ALTER TABLE Genres AUTO_INCREMENT VALUES(1)");
            //Sql("TRUNCATE TABLE Genres");
            //Sql("insert into genres (id, name) values (1, 'action')");
            //Sql("insert into genres (id, name) values (2, 'thriller')");
            //Sql("insert into genres (id, name) values (3, 'family')");
            //Sql("insert into genres (id, name) values (4, 'romance')");
            //Sql("insert into genres (id, name) values (5, 'comedy')");

            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Thriller')");
            Sql("INSERT INTO Genres (Name) VALUES ('Family')");
            Sql("INSERT INTO Genres (Name) VALUES ('Romance')");
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
