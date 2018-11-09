namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteMovies_4 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Movies");
            Sql("TRUNCATE TABLE Movies");
        }
        
        public override void Down()
        {
        }
    }
}
