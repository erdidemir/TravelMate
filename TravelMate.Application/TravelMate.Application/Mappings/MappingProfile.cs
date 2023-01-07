using AutoMapper;
using TravelMate.Application.Features.Commands.Settings.Adds.AddCountry;
using TravelMate.Application.Features.Commands.Authentications.SignUp;
using TravelMate.Application.Features.Commands.Languages.Adds.AddLanguage;
using TravelMate.Application.Features.Commands.Languages.Adds.AddLanguageResource;
using TravelMate.Application.Features.Commands.Languages.Updates.UpdateLanguageResource;
using TravelMate.Application.Models.Authentications;
using TravelMate.Application.Models.Commons;
using TravelMate.Application.Models.Languages;
using TravelMate.Application.Services.Commons;
using TravelMate.Domain.Entities.Authentications;
using TravelMate.Domain.Entities.Languages;
using TravelMate.Domain.Entities.Settings;
using TravelMate.Domain.Enums.Settings;
using TravelMate.Application.Models.Settings;
using TravelMate.Domain.Entities.Travels;
using TravelMate.Application.Features.Commands.Travels.Adds;
using TravelMate.Application.Models.Travels;

namespace TravelMate.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            #region Authentications

            CreateMap<User, SignUpUserCommand>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<LoginModel, UserViewModel>().ReverseMap();

            #endregion

            #region Languages

            CreateMap<Language, AddLanguageCommand>().ReverseMap();
            CreateMap<Language, LanguageViewModel>().ReverseMap();

            CreateMap<LanguageResource, AddLanguageResourceCommand>().ReverseMap();
            CreateMap<LanguageResource, UpdateLanguageResourceCommand>().ReverseMap();
            CreateMap<LanguageResource, LanguageResourceViewModel>().ReverseMap();

            #endregion

            #region Settings
            CreateMap<EnumModel, BaseEnumViewModel>().ReverseMap();

            CreateMap<Country, AddCountryCommand>().ReverseMap();
            CreateMap<Country, CountryViewModel>().ReverseMap();
            CreateMap<Country, CountryNameAndPhoneCodeViewModel>().ReverseMap();
            CreateMap<CountryListModel, BaseEnumViewModel>().ReverseMap();

            #endregion

            #region Travels

            CreateMap<Travel, AddTravelCommand>().ReverseMap();
            CreateMap<Travel, TravelViewModel>().ReverseMap();

            #endregion
        }
    }
}
