namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeddUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9136b144-3868-4f0f-a368-2a1e7dd03a72', N'admin@vidly.com', 0, N'AEl6SwsGTAI8fZbwT9PPNSUU/knGNFbHTAsfyTidNGSiiA3TAuaSbo/knhaVUvxs6Q==', N'f1984af3-fb76-4502-b059-f5ce397c67ab', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'96c234b4-2ef4-4c71-b213-8baa87c88b14', N'guest@domain.com', 0, N'APmw1yKAEkgjDq64/gARNkNDoelv1A5ICWB7H1NrFDVi2slzzDrCR38GztoOfAjWVg==', N'0e02cfd5-30f4-4d28-bfa6-8b55ebf8bc4b', NULL, 0, 0, NULL, 1, 0, N'guest@domain.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6ff95c67-7e93-4503-9da6-0ffa7737a7be', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9136b144-3868-4f0f-a368-2a1e7dd03a72', N'6ff95c67-7e93-4503-9da6-0ffa7737a7be')   
");
        }
        
        public override void Down()
        {
        }
    }
}
