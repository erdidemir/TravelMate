using Microsoft.AspNetCore.Identity;
using TravelMate.Domain.Entities.Travels;

namespace TravelMate.Domain.Entities.Authentications
{
    /// <summary>
    ///  This class inherents from Microsoft.AspNetCore.Identity.IdentityUser
    ///  int type used for the primary key for the role.
    ///  Represents an user in the identity system
    /// </summary>
    public class User : IdentityUser<int>
    {
       
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        /// <summary>
        /// Gets or sets user first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets user last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets Last Login Date 
        /// if there is no login for x days, user have to delete
        /// </summary>
        public DateTime LastLoginDate { get; set; }

        public ICollection<Location> Locations { get; set; }
        public ICollection<Travel> Travels { get; set; }
    }

}

   
