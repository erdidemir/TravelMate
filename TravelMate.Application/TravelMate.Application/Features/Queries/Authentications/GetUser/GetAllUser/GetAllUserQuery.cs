using TravelMate.Application.Models.Authentications;
using TravelMate.Application.Models.Commons;
using MediatR;
using System.Collections.Generic;

namespace TravelMate.Application.Features.Queries.Authentications.GetUser.GetAllUser
{
    public class GetAllUserQuery : IRequest<ResponseViewModelBase<IReadOnlyList<UserViewModel>>>
    {
    }
}
