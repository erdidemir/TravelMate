using TravelMate.Application.Models.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Commands.Authentications.Adds.AddUserRole
{
    public class AddUserRoleCommand : IRequest<ResponseViewModelBase<NoContent>>
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
