using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Application.Models.Commons;

namespace TravelMate.Application.Features.Commands.Travels.Updates
{
    public class PublishOrUnPublishTravelCommand : IRequest<ResponseViewModelBase<NoContent>>
    {
        public int TravelId { get; set; }
        public bool IsActive { get; set; }
    }
}
