using AutoMapper;
using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Models.Authentications;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Languages;
using TravelMate.Domain.Entities.Authentications;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace TravelMate.Application.Features.Queries.Authentications.GetUser.GetAllUser
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, ResponseViewModelBase<IReadOnlyList<UserViewModel>>>
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly ILanguageResourceService _languageResourceService;

        public GetAllUserQueryHandler(UserManager<User> userManager, IMapper mapper, ILanguageResourceService languageResourceService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _languageResourceService = languageResourceService;
        }

        public async Task<ResponseViewModelBase<IReadOnlyList<UserViewModel>>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var userList = _userManager.Users.ToList();
            if (userList is null)
            {
                var responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.UserNotFound, LanguageInfo.Code);
                return ResponseViewModelBase<IReadOnlyList<UserViewModel>>.Fail(responseMessage, ResultTypeEnum.Error);
            }
            var returnList = _mapper.Map<IReadOnlyList<UserViewModel>>(userList);

            return ResponseViewModelBase<IReadOnlyList<UserViewModel>>.Success(returnList, ResultTypeEnum.Success);
        }
    }
}
 