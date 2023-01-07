using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Languages;
using TravelMate.Application.Settings;
using TravelMate.Domain.Entities.Authentications;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Commands.Authentications.ForgotPassword.ResetPassword
{
    public class ResetPasswordCommandHandler : IRequestHandler<ResetPasswordCommand, ResponseViewModelBase<NoContent>>
    {
        private readonly UserManager<User> _userManager;
        private readonly ILanguageResourceService _languageResourceService;


        public ResetPasswordCommandHandler(UserManager<User> userManager, ILanguageResourceService languageResourceService)
        {
            _userManager = userManager;
            _languageResourceService = languageResourceService;
        }

        public async Task<ResponseViewModelBase<NoContent>> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId.ToString());
            var result = await _userManager.ResetPasswordAsync(user, request.Token, request.Password);
            await _userManager.UpdateSecurityStampAsync(user);
            if (!result.Succeeded)
            {
                var responseMessage1 = await _languageResourceService.GetTranslateAsync(ResponseConstants.CouldNotChangePassword, LanguageInfo.Code);
                return ResponseViewModelBase<NoContent>.Fail(responseMessage1, ResultTypeEnum.Error);
            }
            var responseMessage2 = await _languageResourceService.GetTranslateAsync(ResponseConstants.ThePasswordWasChanged, LanguageInfo.Code);
            return ResponseViewModelBase<NoContent>.Success(responseMessage2, ResultTypeEnum.Success);

        }
    }
}
