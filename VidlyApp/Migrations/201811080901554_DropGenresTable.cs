namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Genres Where Id = 1");
            Sql("DELETE FROM Genres Where Id = 2");
            Sql("DELETE FROM Genres Where Id = 3");
            Sql("DELETE FROM Genres Where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
