using TravelMate.Application.Models.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Commands.Authentications.ForgotPassword.SendMail
{
    public class ResetSendMailCommand: IRequest<ResponseViewModelBase<NoContent>>
    {
        public string Email { get; set; }
   
    }
}
