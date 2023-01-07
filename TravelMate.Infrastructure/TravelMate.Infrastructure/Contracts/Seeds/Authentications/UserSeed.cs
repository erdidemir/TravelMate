using Microsoft.AspNetCore.Identity;
using TravelMate.Domain.Entities.Authentications;

namespace TravelMate.Infrastructure.Contracts.Seeds.Authentications
{
    public static class UserSeed
    {
        public static List<User> UserList()
        {
            var hasher = new PasswordHasher<User>();
            return new List<User>()
            {
                new User {
                    FirstName="Admin",
                    LastName="Travl",
                    UserName="travelmatetest@gmail.com",
                    NormalizedUserName="TRAVELMATETEST@GMAIL.COM",
                    Email="travelmatetest@gmail.com",
                    NormalizedEmail="TRAVELMATETEST@GMAIL.COM",
                    PasswordHash=hasher.HashPassword(null,"TMAdmin77!!"),
                    EmailConfirmed=true,
                    SecurityStamp = Guid.NewGuid().ToString("D")},

                 new User {
                    FirstName="User",
                    LastName="TravelMate",
                    UserName="erdieymendemir@gmail.com",
                    NormalizedUserName="ERDIEYMENDEMIR@GMAIL.COM",
                    Email="erdieymendemir@gmail.com",
                    NormalizedEmail="ERDIEYMENDEMIR@GMAIL.COM",
                    PasswordHash=hasher.HashPassword(null,"TMUser77!!"),
                    EmailConfirmed=true,
                    SecurityStamp = Guid.NewGuid().ToString("D")},

            };
        }
    }
}
