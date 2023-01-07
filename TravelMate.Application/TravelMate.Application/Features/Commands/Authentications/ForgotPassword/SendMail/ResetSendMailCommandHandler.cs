using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Languages;
using TravelMate.Domain.Entities.Authentications;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using TravelMate.Application.Settings.Informations;

namespace TravelMate.Application.Features.Commands.Authentications.ForgotPassword.SendMail
{
    public class ResetSendMailCommandHandler : IRequestHandler<ResetSendMailCommand, ResponseViewModelBase<NoContent>>
    {
        private readonly UserManager<User> _userManager;
        private readonly ILanguageResourceService _languageResourceService;
        private readonly IOptions<DomainInfo> _domainInfo;
        public ResetSendMailCommandHandler(UserManager<User> userManager, ILanguageResourceService languageResourceService, IOptions<DomainInfo> domainInfo)
        {
            _userManager = userManager;
            _languageResourceService = languageResourceService;
            _domainInfo = domainInfo;
        }

        public async Task<ResponseViewModelBase<NoContent>> Handle(ResetSendMailCommand request, CancellationToken cancellationToken)
        {
            var responseMessage = "";
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user is null)
            {
                responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.ForgotPasswordEmailSent, LanguageInfo.Code);
                return ResponseViewModelBase<NoContent>.Success(responseMessage, ResultTypeEnum.Success);
            }             
            string resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);

            string link = _domainInfo.Value.Name+"/ResetPassword?token=" + resetToken + "&userId=" + user.Id;

            var mailData = new Dictionary<string, dynamic>();
            mailData.Add("userName", user.FullName);
            mailData.Add("resetUrl", link);

            //await _mailService.SendTemplateAsync("ForgotPassword", mailData,user.Email);

            responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.ForgotPasswordEmailSent, LanguageInfo.Code);
            return ResponseViewModelBase<NoContent>.Success(responseMessage, ResultTypeEnum.Success);
        }
    }
}