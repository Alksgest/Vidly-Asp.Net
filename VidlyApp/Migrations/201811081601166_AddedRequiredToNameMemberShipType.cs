namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRequiredToNameMemberShipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "DurationInMonths", c => c.Byte(nullable: false));
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
            DropColumn("dbo.MembershipTypes", "DurationInMonth");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "DurationInMonth", c => c.Byte(nullable: false));
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String());
            DropColumn("dbo.MembershipTypes", "DurationInMonths");
        }
    }
}
