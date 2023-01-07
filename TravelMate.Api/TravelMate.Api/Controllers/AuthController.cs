using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TravelMate.Application.Features.Commands.Authentications.Adds.AddUserRole;
using TravelMate.Application.Features.Commands.Authentications.ChangePassword;
using TravelMate.Application.Features.Commands.Authentications.ForgotPassword.ResetPassword;
using TravelMate.Application.Features.Commands.Authentications.ForgotPassword.SendMail;
using TravelMate.Application.Features.Commands.Authentications.SignUp;
using TravelMate.Application.Features.Queries.Authentications.GetUser.GetAllUser;
using TravelMate.Application.Features.Queries.Authentications.GetUser.GetByIdUser;
using TravelMate.Application.Features.Queries.Authentications.GetUser.Login;
using TravelMate.Application.Features.Queries.Authentications.GetUserRole;
using TravelMate.Application.Models.Authentications;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Settings.Authentications;
using TravelMate.Domain.Enums.Commons;

namespace TravelMate.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly JwtSettings _jwtSettings;
        private readonly IMapper _mapper;

        public AuthController(IMediator mediator, IOptionsSnapshot<JwtSettings> jwtSettings, IMapper mapper)

        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _jwtSettings = jwtSettings.Value;
            _mapper = mapper;
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var UserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            if (User.FindFirst(ClaimTypes.Role).Value == "Admin")
            {
                UserId = id;
            }

            var response = await _mediator.Send(new GetByIdUserQuery() { Id = UserId });
            return CreateActionResult(response);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            var response = await _mediator.Send(new GetAllUserQuery());
            return CreateActionResult(response);
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(SignUpUserCommand signUpUserCommand)
        {
            var response = await _mediator.Send(signUpUserCommand);
            return CreateActionResult(response);
        }

        [Authorize]
        [HttpPost("UserRole")]
        public async Task<IActionResult> AddRole(AddUserRoleCommand addUserRoleCommand)
        {
            var response = await _mediator.Send(addUserRoleCommand);
            return CreateActionResult(response);
        }

        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn(SignInModel signInModel)
        {
            var query = new GetUserByEmailAndPasswordQuery(signInModel.Email, signInModel.Password);

            var response = await _mediator.Send(query);

            if (response.Data is null)
            {
                return CreateActionResult(response);
            }

            var token = GenerateJwt(response.Data);

            var loginResponse = _mapper.Map<LoginModel>(response.Data);
            loginResponse.Token = token;
            return CreateActionResult(ResponseViewModelBase<LoginModel>.Success(loginResponse, ResultTypeEnum.Success));
        }

        [Authorize]
        [HttpPut("ChangePassword")]
        public async Task<IActionResult> ChangePassword(ChangePasswordCommand request)
        {
            request.UserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var result = await _mediator.Send(request);
            return CreateActionResult(result);
        }

        [HttpPost("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword(ResetSendMailCommand request)
        {
            var result = await _mediator.Send(request);
            return CreateActionResult(result);
        }

        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordCommand request)
        {
            var result = await _mediator.Send(request);
            return CreateActionResult(result);
        }

        [HttpGet("UserRoles")]
        public async Task<IActionResult> UserRoles(string email)
        {
            var response = await _mediator.Send(new GetUserRoleCommand { Email = email });
            return CreateActionResult(response);
        }

        private string GenerateJwt(UserViewModel userModel)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, userModel.Id.ToString()),
                new Claim(ClaimTypes.Name, userModel.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, userModel.Id.ToString())
            };

            var roleClaims = userModel.Roles.Select(r => new Claim(ClaimTypes.Role, r));
            claims.AddRange(roleClaims);

            //Security  Key'in alıyoruz.
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret));

            //Şifrelenmiş kimliği oluşturuyoruz.
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //Bitiş Zamanını ayarlayabiliyoruz
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_jwtSettings.ExpirationInDays));

            // Oluşturulacak token ayarlarını veriyoruz.
            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Issuer,
                claims,
                expires: expires,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [NonAction]
        public IActionResult CreateActionResult<T>(ResponseViewModelBase<T> response)
        {
            if (response.ResultType == ResultTypeEnum.Error)
                return new ObjectResult(response) { StatusCode = 400 };

            return new ObjectResult(response) { StatusCode = 200 };
        }
    }
}
