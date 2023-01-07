using TravelMate.Application.Models.Commons;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Commands.Authentications.ForgotPassword.ResetPassword
{
    public class ResetPasswordCommand: IRequest<ResponseViewModelBase<NoContent>>
    {
        public int UserId { get; set; }
        public string Token { get; set; }
        public string Password { get; set; }    
    }
}
