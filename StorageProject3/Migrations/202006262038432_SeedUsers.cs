namespace StorageProject3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'042d3d20-2c79-4b09-9562-783779ea6d56', N'admin@gmail.com', 0, N'AJvMWls/w8zgFTElL/DYUQqId0lNadFzK03WQKz5S30boao0kh5IEQsjUDDvUVoTsA==', N'ff68d45c-f8a2-44ef-af6f-c2916eb6e304', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b3c591f1-3049-4613-b546-100fdc62b406', N'guest@gmail.com', 0, N'ACwBVHBoAbi7ERYmmiB+DZYhe8tjL5RXMTA1YUIo2000JdQO9yC+KEcZl9Jkp353jw==', N'04e06870-fba0-40fd-8736-ccbb8a64c76d', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6ff5fff0-57ab-4158-9827-d556f96eed02', N'CanStoreProduct')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'042d3d20-2c79-4b09-9562-783779ea6d56', N'6ff5fff0-57ab-4158-9827-d556f96eed02')

");
        }
        
        public override void Down()
        {
        }
    }
}
