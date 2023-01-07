using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMate.Infrastructure.Contracts.Seeds.Authentications
{
    public static class UserRoleSeed
    {
        public static List<IdentityUserRole<int>> UserRoleList()
        {
            return new List<IdentityUserRole<int>>()
            {
                 new IdentityUserRole<int> { RoleId = 1, UserId = 1 },
                 new IdentityUserRole<int> { RoleId = 2, UserId = 2 },
            };
        }
    }
}
