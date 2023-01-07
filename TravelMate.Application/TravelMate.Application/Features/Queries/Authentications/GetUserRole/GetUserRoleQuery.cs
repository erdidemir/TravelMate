using TravelMate.Application.Models.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Queries.Authentications.GetUserRole
{
    public class GetUserRoleCommand : IRequest<ResponseViewModelBase<IList<string>>>
    {
        public string Email { get; set; }
    }
    
}
