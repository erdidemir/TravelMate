using TravelMate.Application.Models.Authentications;
using TravelMate.Application.Models.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Queries.Authentications.GetUser.Login
{
    public class GetUserByEmailAndPasswordQuery : IRequest<ResponseViewModelBase<UserViewModel>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
   
        public GetUserByEmailAndPasswordQuery(string email, string password)
        {
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password = password ?? throw new ArgumentNullException(nameof(password));

        }
    }
}
