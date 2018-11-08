namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropMoviesGenresTables : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Movies");
            DropTable("dbo.Genres");
        }
        
        public override void Down()
        {
        }
    }
}
