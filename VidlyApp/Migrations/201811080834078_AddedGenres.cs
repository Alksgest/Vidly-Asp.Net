namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenres : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Genres SET Name = 'Comedy' WHERE Id = 1");
            Sql("UPDATE Genres SET Name = 'Action' WHERE Id = 2");
            Sql("UPDATE Genres SET Name = 'Family' WHERE Id = 3");
            Sql("UPDATE Genres SET Name = 'Romance' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
