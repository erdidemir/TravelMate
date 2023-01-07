using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Application.Models.Commons;
using TravelMate.Domain.Entities.Authentications;

namespace TravelMate.Application.Services.Authentications
{
    public interface IUserService
    {
        Task<ResponseViewModelBase<NoContent>> CreateAsync(User user, string password);
        Task<User> GetUserByEmail(string email);
    }
}
