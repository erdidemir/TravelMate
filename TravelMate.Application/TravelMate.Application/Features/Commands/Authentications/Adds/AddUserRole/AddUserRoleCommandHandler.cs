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

namespace TravelMate.Application.Features.Commands.Authentications.Adds.AddUserRole
{
    public class AddUserRoleCommandHandler : IRequestHandler<AddUserRoleCommand, ResponseViewModelBase<NoContent>>
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly UserManager<User> _userManager;
        private readonly ILanguageResourceService _languageResourceService;


        public AddUserRoleCommandHandler(RoleManager<Role> roleManager, UserManager<User> userManager, ILanguageResourceService languageResourceService)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _languageResourceService = languageResourceService;
           
        }

        public async Task<ResponseViewModelBase<NoContent>> Handle(AddUserRoleCommand request, CancellationToken cancellationToken)
        {
            var responseMessage = "";
            var userEntity= await _userManager.FindByIdAsync(request.UserId.ToString());
            if (userEntity is null)
            {
                responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.UserNotFound, LanguageInfo.Code);
                return ResponseViewModelBase<NoContent>.Fail(responseMessage, ResultTypeEnum.Error);
            }

            var roleEntity = await _roleManager.FindByIdAsync(request.RoleId.ToString());
            if (roleEntity is null)
            {
                responseMessage = await _languageResourceService.GetTranslateAsync(ResponseConstants.RoleNotFound, LanguageInfo.Code);
                return ResponseViewModelBase<NoContent>.Fail(responseMessage, ResultTypeEnum.Error);
            }
            if (roleEntity.Name=="Admin")
            {
                await _userManager.RemoveFromRoleAsync(userEntity, "User");
            }
            else if (roleEntity.Name=="User")
            {
                await _userManager.RemoveFromRoleAsync(userEntity, "Admin");
            }
           
            await _userManager.AddToRoleAsync(userEntity, roleEntity.Name);
            return ResponseViewModelBase<NoContent>.Success(ResponseConstants.AddingWasSuccessful, ResultTypeEnum.Success);
        }
    }
}
