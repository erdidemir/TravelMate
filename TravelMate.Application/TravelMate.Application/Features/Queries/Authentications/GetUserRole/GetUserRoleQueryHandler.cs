using AutoMapper;
using TravelMate.Application.Constants.Languages;
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

namespace TravelMate.Application.Features.Queries.Authentications.GetUserRole
{
    public class GetUserRoleCommandHandler : IRequestHandler<GetUserRoleCommand, ResponseViewModelBase<IList<string>>>
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IMapper _mapper;
        private readonly ILanguageResourceService _languageResourceService;

        public GetUserRoleCommandHandler(UserManager<User> userManager, IMapper mapper, ILanguageResourceService languageResourceService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _languageResourceService = languageResourceService;
        }


        public async Task<ResponseViewModelBase<IList<string>>> Handle(GetUserRoleCommand request, CancellationToken cancellationToken)
        {
            var responseMessage = "";
            var user = _userManager.Users.SingleOrDefault(u => u.Email == request.Email);

            if (user is null)
            {
                responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.UserNotFound, LanguageInfo.Code);

                return ResponseViewModelBase<IList<string>>.Fail(responseMessage, ResultTypeEnum.Error);
            }

            var userRole = await _userManager.GetRolesAsync(user);



            return ResponseViewModelBase<IList<string>>.Success(userRole, ResultTypeEnum.Success);

        }


    }
}
