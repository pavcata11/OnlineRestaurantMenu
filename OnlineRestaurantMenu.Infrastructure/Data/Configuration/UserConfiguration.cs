using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineRestaurantMenu.Infrastructure.Data.Entity;

namespace OnlineRestaurantMenu.Infrastructure.Data.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<IdentityUser> CreateUsers()
        {
            var users = new List<IdentityUser>();

            var hasher = new PasswordHasher<IdentityUser>();

            var user = new IdentityUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "user1",
                NormalizedUserName = "user1@mail.com",
                Email = "user1t@mail.com",
                NormalizedEmail = "user1@mail.com",
            };

            user.PasswordHash = hasher.HashPassword(user, "user123");
            users.Add(user);

            user = new IdentityUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "user2",
                NormalizedUserName = "user2@mail.com",
                Email = "user2@mail.com",
                NormalizedEmail = "user2@mail.com",
            };

            user.PasswordHash = hasher.HashPassword(user, "user123");
            users.Add(user);

            user = new IdentityUser()
            {
                Id = "cab25823-7170-4e85-96b8-ac84c7acf0c7",
                UserName = "user3",
                NormalizedUserName = "user3@mail.com",
                Email = "user3@mail.com",
                NormalizedEmail = "user3@mail.com",
            };

            user.PasswordHash = hasher.HashPassword(user, "user123");
            users.Add(user);

            user = new IdentityUser()
            {
                Id = "6c91f1cd-c671-4fb5-a802-541ddad67cf4",
                UserName = "user4",
                NormalizedUserName = "user4@mail.com",
                Email = "user4@mail.com",
                NormalizedEmail = "user4@mail.com",
            };

            user.PasswordHash = hasher.HashPassword(user, "user123");
            users.Add(user);

            user = new IdentityUser()
            {
                Id = "635a6ee6-f1de-4ce5-af5e-5af83b6d307d",
                UserName = "user5",
                NormalizedUserName = "user5@mail.com",
                Email = "user5@mail.com",
                NormalizedEmail = "user5@mail.com",
            };

            user.PasswordHash = hasher.HashPassword(user, "user123");
            users.Add(user);

            return users;
        }
    }
}
