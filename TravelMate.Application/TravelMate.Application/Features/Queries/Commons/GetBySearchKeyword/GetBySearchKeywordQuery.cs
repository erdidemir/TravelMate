using TravelMate.Application.Models.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Queries.Commons.GetBySearchKeyword
{
    public class GetBySearchKeywordQuery<T> : IRequest<ResponseViewModelBase<IReadOnlyList<T>>> where T : class
    {
        public string Keyword { get; set; }
    }
}
