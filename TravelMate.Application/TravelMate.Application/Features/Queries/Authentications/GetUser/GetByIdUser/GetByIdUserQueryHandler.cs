using AutoMapper;
using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Models.Authentications;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Languages;
using TravelMate.Application.Settings;
using TravelMate.Domain.Entities.Authentications;
using TravelMate.Domain.Enums.Commons;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TravelMate.Application.Features.Queries.Authentications.GetUser.GetByIdUser
{
    public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQuery, ResponseViewModelBase<UserViewModel>>
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly ILanguageResourceService _languageResourceService;
        public GetByIdUserQueryHandler(UserManager<User> userManager, IMapper mapper, ILanguageResourceService languageResourceService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _languageResourceService = languageResourceService;
        }

        public async Task<ResponseViewModelBase<UserViewModel>> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
        {
            var userEntity = await _userManager.FindByIdAsync(request.Id.ToString());
            if (userEntity is null)
            {
                var responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.UserNotFound, LanguageInfo.Code);
                return ResponseViewModelBase<UserViewModel>.Fail(responseMessage, ResultTypeEnum.Error);
            }
            var returnEntity = _mapper.Map<UserViewModel>(userEntity);

            return ResponseViewModelBase<UserViewModel>.Success(returnEntity, ResultTypeEnum.Success);
        }
    }
}
