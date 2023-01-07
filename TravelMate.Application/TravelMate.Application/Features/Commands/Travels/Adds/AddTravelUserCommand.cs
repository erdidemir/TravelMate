using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Application.Models.Commons;

namespace TravelMate.Application.Features.Commands.Travels.Adds
{
    public class AddTravelUserCommand : IRequest<ResponseViewModelBase<NoContent>>
    {
        public int TravelId { get; set; }

        public int UserId { get; set; }

    }
}
