using TravelMate.Domain.Entities.Authentications;

namespace TravelMate.Infrastructure.Contracts.Seeds.Authentications
{
    public static class RoleSeed
    {
        public static List<Role> RoleList()
        {
            return new List<Role>()
            {
                new Role { Name = "Admin", NormalizedName = "ADMIN" },
                new Role { Name = "User", NormalizedName = "USER" },

            };
        }

    }
}
