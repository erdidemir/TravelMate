using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Authentications;
using TravelMate.Application.Services.Languages;
using TravelMate.Application.Settings.Informations;
using TravelMate.Application.Settings.Languages;
using TravelMate.Domain.Entities.Authentications;
using TravelMate.Domain.Enums.Commons;

namespace TravelMate.Infrastructure.Services.Authentications
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly ILanguageResourceService _languageResourceService;
        private readonly IOptions<DomainInfo> _domainInfo;


        public UserService(UserManager<User> userManager,
            ILanguageResourceService languageResourceService, IOptions<DomainInfo> domainInfo
           )
        {
            _userManager = userManager;
            _languageResourceService = languageResourceService;
            _domainInfo = domainInfo;
        }

        public async Task<ResponseViewModelBase<NoContent>> CreateAsync(User user, string password)
        {
            var responseMessage = "";
            user.UserName = user.Email;
            user.LastLoginDate = DateTime.Now;

            var userCreateResult = await _userManager.CreateAsync(user, password);

            var duplicate = userCreateResult.Errors.FirstOrDefault(x => x.Code == "DuplicateUserName");
            if (userCreateResult.Succeeded)
            {
                var userEntity = await _userManager.FindByEmailAsync(user.Email);
                var roleresult = _userManager.AddToRoleAsync(userEntity, "User");
              
                responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.WelcomeToDeliverist, LanguageInfo.Code);
                return ResponseViewModelBase<NoContent>.Success(responseMessage, ResultTypeEnum.Success);
            }
            else if (duplicate is not null)
            {
                responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.ThisEmailIsAlreadyRegistered, LanguageInfo.Code);

                return ResponseViewModelBase<NoContent>.Fail(responseMessage, ResultTypeEnum.Error);
            }
            else
            {
                responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.TransactionFailed, LanguageInfo.Code);

                return ResponseViewModelBase<NoContent>.Fail(responseMessage, ResultTypeEnum.Error);
            }
        }
        public async Task<User> GetUserByEmail(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            return user;
        }
    }
}
