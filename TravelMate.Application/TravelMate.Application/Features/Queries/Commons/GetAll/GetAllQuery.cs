using TravelMate.Application.Models.Commons;
using MediatR;

namespace TravelMate.Application.Features.Queries.Commons.GetAll
{
    public class GetAllQuery<T> : IRequest<ResponseViewModelBase<IReadOnlyList<T>>> where T : class
    {
    }
}
