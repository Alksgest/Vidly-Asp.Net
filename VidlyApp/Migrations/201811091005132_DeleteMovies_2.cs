namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteMovies_2 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Movies");
        }
        
        public override void Down()
        {
        }
    }
}
