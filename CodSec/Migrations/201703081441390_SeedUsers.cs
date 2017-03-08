namespace CodSec.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'762c5d08-934d-4a77-bcde-0ab5d269754b', N'giuseppe.cristaudo@gmail.com', 0, N'AOmje39KpI/2j4EvGyZQr4ZwrDP9oXrI17ukX9z8gFQSiYRKVyNy2ivJGAi5YmMibw==', N'15413fbe-ff4d-40b1-8c8b-c38b5e18ead6', NULL, 0, 0, NULL, 1, 0, N'giuseppe.cristaudo@gmail.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4201ea5e-9969-4c2e-9027-7eb112f2024e', N'administrator')


                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'762c5d08-934d-4a77-bcde-0ab5d269754b', N'4201ea5e-9969-4c2e-9027-7eb112f2024e')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
