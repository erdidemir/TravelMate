using AutoMapper;
using TravelMate.Application.Settings;
using TravelMate.Application.Constants.Languages;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Services.Authentications;
using TravelMate.Application.Services.Languages;
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

namespace TravelMate.Application.Features.Commands.Authentications.SignUp
{
    public class SignUpUserCommandHandler : IRequestHandler<SignUpUserCommand, ResponseViewModelBase<NoContent>>
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly ILanguageResourceService _languageResourceService;

        public SignUpUserCommandHandler(IMapper mapper, IUserService userService, ILanguageResourceService languageResourceService)
        {
            _mapper = mapper;
            _userService = userService;
            _languageResourceService = languageResourceService;
        }

        public async Task<ResponseViewModelBase<NoContent>> Handle(SignUpUserCommand request, CancellationToken cancellationToken)
        {
            var userEntity = _mapper.Map<User>(request);

            return await _userService.CreateAsync(userEntity, request.Password);

        }
    }
}
