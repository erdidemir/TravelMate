using TravelMate.Application.Models.Authentications;
using TravelMate.Application.Models.Commons;
using MediatR;

namespace TravelMate.Application.Features.Queries.Authentications.GetUser.GetByIdUser
{
    public class GetByIdUserQuery:IRequest<ResponseViewModelBase<UserViewModel>>
    {
        public int Id { get; set; }
    }
}
