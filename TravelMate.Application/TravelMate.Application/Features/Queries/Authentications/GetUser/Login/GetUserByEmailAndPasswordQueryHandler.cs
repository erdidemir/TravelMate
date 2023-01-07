using AutoMapper;
using TravelMate.Application.Settings;
using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Models.Authentications;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Languages;
using TravelMate.Domain.Entities.Authentications;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace TravelMate.Application.Features.Queries.Authentications.GetUser.Login
{
    public class GetUserByEmailAndPasswordQueryHandler : IRequestHandler<GetUserByEmailAndPasswordQuery, ResponseViewModelBase<UserViewModel>>
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;
        private readonly ILanguageResourceService _languageResourceService;

        public GetUserByEmailAndPasswordQueryHandler(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper, ILanguageResourceService languageResourceService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _languageResourceService = languageResourceService;
            _signInManager = signInManager;
        }

        public async Task<ResponseViewModelBase<UserViewModel>> Handle(GetUserByEmailAndPasswordQuery request, CancellationToken cancellationToken)
        {
            var responseMessage = "";
            var user = _userManager.Users.SingleOrDefault(u => u.Email == request.Email);
    
            if (user is null)
            {
                responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.EmailOrPassWordIncorrent, LanguageInfo.Code);

                return ResponseViewModelBase<UserViewModel>.Fail(responseMessage, ResultTypeEnum.Error);
            }
            var userModel = _mapper.Map<UserViewModel>(user);
            var userSigninResult = await _signInManager.PasswordSignInAsync(user, request.Password, true, false);

            var userSigninResultBool = await _userManager.CheckPasswordAsync(user, request.Password);

            if (userSigninResult.Succeeded)
            {
                userModel.Roles = await _userManager.GetRolesAsync(user);
            }
            else if(userSigninResultBool && userSigninResult.IsNotAllowed)
            {
                responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.PleaseConfirmMailAddress, LanguageInfo.Code);
                return ResponseViewModelBase<UserViewModel>.Fail(responseMessage, ResultTypeEnum.Error);
            }
            else
            {
                responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.EmailOrPassWordIncorrent, LanguageInfo.Code);
                return ResponseViewModelBase<UserViewModel>.Fail(responseMessage, ResultTypeEnum.Error);
            }
            
            return ResponseViewModelBase<UserViewModel>.Success(userModel, ResultTypeEnum.Success);

        }
    }
}
